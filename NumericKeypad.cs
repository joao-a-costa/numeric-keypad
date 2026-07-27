using System;
using System.Drawing;
using System.Windows.Forms;

namespace NumericKeypad
{
    public partial class NumericKeypad : Form
    {
        private readonly Control _target; // Can be TextBox or NumericUpDown
        private readonly string _placeholderText;

        private Point _dragStart;
        private bool _dragging;

        // When true, allows targets other than TextBox/NumericUpDown; DigitButton_Click etc.
        // only know how to drive those two, so other controls won't receive input automatically.
        public static bool SkipTargetValidation { get; set; } = false;

        public NumericKeypad(Control target, string placeholderText = null)
        {
            if (target == null || (!SkipTargetValidation && !(target is TextBox) && !(target is NumericUpDown)))
                throw new ArgumentException("Target must be a TextBox or NumericUpDown");

            _target = target;
            _placeholderText = placeholderText;
            InitializeComponent();
        }

        // Prevents the keypad from stealing focus from the target textbox.
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x08000000; // WS_EX_NOACTIVATE
                return cp;
            }
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = true;
                _dragStart = e.Location;
            }
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
                Location = new Point(
                    Location.X + e.X - _dragStart.X,
                    Location.Y + e.Y - _dragStart.Y);
        }

        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void DigitButton_Click(object sender, EventArgs e)
        {
            if (_target == null || _target.IsDisposed)
                return;

            string digit = ((Button)sender).Text;

            if (_target is TextBox textBox)
            {
                if (!string.IsNullOrEmpty(_placeholderText) && textBox.Text == _placeholderText)
                    textBox.Text = string.Empty;
                textBox.AppendText(digit);
            }
            else if (_target is NumericUpDown numericUpDown)
            {
                numericUpDown.Focus();
                // Send the digit via keyboard simulation
                foreach (char c in digit)
                    SendKeys.Send(c.ToString());
            }
        }

        private void DecimalSeparatorButton_Click(object sender, EventArgs e)
        {
            if (_target == null || _target.IsDisposed)
                return;

            string separator = ","; // Portuguese locale uses comma

            if (_target is TextBox textBox)
            {
                if (!string.IsNullOrEmpty(_placeholderText) && textBox.Text == _placeholderText)
                    textBox.Text = string.Empty;

                // Only add separator if not already present
                if (!textBox.Text.Contains(",") && !textBox.Text.Contains("."))
                    textBox.AppendText(separator);
            }
            else if (_target is NumericUpDown numericUpDown)
            {
                numericUpDown.Focus();
                SendKeys.Send(",");
            }
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (_target == null || _target.IsDisposed)
                return;

            if (_target is TextBox textBox)
            {
                if (!string.IsNullOrEmpty(_placeholderText) && textBox.Text == _placeholderText)
                {
                    textBox.Text = string.Empty;
                    return;
                }

                if (textBox.Text.Length > 0)
                {
                    textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
                    textBox.Select(textBox.Text.Length, 0);
                }
            }
            else if (_target is NumericUpDown numericUpDown)
            {
                numericUpDown.Focus();
                SendKeys.Send("{BACKSPACE}");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
