namespace NumericKeypad
{
    partial class NumericKeypad
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.TopBar = new System.Windows.Forms.Panel();
            this.LClose = new System.Windows.Forms.Label();
            this.LTitle = new System.Windows.Forms.Label();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnComma = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnCloseKeypad = new System.Windows.Forms.Button();
            this.TopBar.SuspendLayout();
            this.SuspendLayout();
            //
            // TopBar
            //
            this.TopBar.BackColor = System.Drawing.Color.Gray;
            this.TopBar.Controls.Add(this.LClose);
            this.TopBar.Controls.Add(this.LTitle);
            this.TopBar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(246, 42);
            this.TopBar.TabIndex = 0;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            //
            // LTitle
            //
            this.LTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.LTitle.ForeColor = System.Drawing.Color.White;
            this.LTitle.Location = new System.Drawing.Point(0, 0);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(246, 42);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "Teclado Numérico";
            this.LTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.LTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.LTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            //
            // LClose
            //
            this.LClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LClose.ForeColor = System.Drawing.Color.White;
            this.LClose.Location = new System.Drawing.Point(200, 0);
            this.LClose.Name = "LClose";
            this.LClose.Size = new System.Drawing.Size(46, 42);
            this.LClose.TabIndex = 1;
            this.LClose.Text = "✕";
            this.LClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LClose.Click += new System.EventHandler(this.CloseButton_Click);
            //
            // Btn7
            //
            this.Btn7.BackColor = System.Drawing.Color.White;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Btn7.Location = new System.Drawing.Point(12, 50);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(66, 58);
            this.Btn7.TabIndex = 10;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.DigitButton_Click);
            //
            // Btn8
            //
            this.Btn8.BackColor = System.Drawing.Color.White;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Btn8.Location = new System.Drawing.Point(90, 50);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(66, 58);
            this.Btn8.TabIndex = 11;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.DigitButton_Click);
            //
            // Btn9
            //
            this.Btn9.BackColor = System.Drawing.Color.White;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Btn9.Location = new System.Drawing.Point(168, 50);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(66, 58);
            this.Btn9.TabIndex = 12;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.DigitButton_Click);
            //
            // Btn4
            //
            this.Btn4.BackColor = System.Drawing.Color.White;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Btn4.Location = new System.Drawing.Point(12, 116);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(66, 58);
            this.Btn4.TabIndex = 13;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.DigitButton_Click);
            //
            // Btn5
            //
            this.Btn5.BackColor = System.Drawing.Color.White;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Btn5.Location = new System.Drawing.Point(90, 116);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(66, 58);
            this.Btn5.TabIndex = 14;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.DigitButton_Click);
            //
            // Btn6
            //
            this.Btn6.BackColor = System.Drawing.Color.White;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Btn6.Location = new System.Drawing.Point(168, 116);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(66, 58);
            this.Btn6.TabIndex = 15;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.DigitButton_Click);
            //
            // Btn1
            //
            this.Btn1.BackColor = System.Drawing.Color.White;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Btn1.Location = new System.Drawing.Point(12, 182);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(66, 58);
            this.Btn1.TabIndex = 16;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.DigitButton_Click);
            //
            // Btn2
            //
            this.Btn2.BackColor = System.Drawing.Color.White;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Btn2.Location = new System.Drawing.Point(90, 182);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(66, 58);
            this.Btn2.TabIndex = 17;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.DigitButton_Click);
            //
            // Btn3
            //
            this.Btn3.BackColor = System.Drawing.Color.White;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Btn3.Location = new System.Drawing.Point(168, 182);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(66, 58);
            this.Btn3.TabIndex = 18;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.DigitButton_Click);
            //
            // BtnBack
            //
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(255, 165, 0);
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(12, 248);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(66, 58);
            this.BtnBack.TabIndex = 19;
            this.BtnBack.Text = "⌫";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BackspaceButton_Click);
            //
            // Btn0
            //
            this.Btn0.BackColor = System.Drawing.Color.White;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.Btn0.Location = new System.Drawing.Point(90, 248);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(66, 58);
            this.Btn0.TabIndex = 20;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.DigitButton_Click);
            //
            // BtnComma
            //
            this.BtnComma.BackColor = System.Drawing.Color.White;
            this.BtnComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnComma.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.BtnComma.Location = new System.Drawing.Point(168, 248);
            this.BtnComma.Name = "BtnComma";
            this.BtnComma.Size = new System.Drawing.Size(66, 58);
            this.BtnComma.TabIndex = 21;
            this.BtnComma.Text = ",";
            this.BtnComma.UseVisualStyleBackColor = false;
            this.BtnComma.Click += new System.EventHandler(this.DecimalSeparatorButton_Click);
            //
            // BtnPlus
            //
            this.BtnPlus.BackColor = System.Drawing.Color.White;
            this.BtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlus.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.BtnPlus.Location = new System.Drawing.Point(90, 314);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(66, 58);
            this.BtnPlus.TabIndex = 22;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = false;
            this.BtnPlus.Click += new System.EventHandler(this.DigitButton_Click);
            //
            // BtnCloseKeypad
            //
            this.BtnCloseKeypad.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.BtnCloseKeypad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseKeypad.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.BtnCloseKeypad.ForeColor = System.Drawing.Color.White;
            this.BtnCloseKeypad.Location = new System.Drawing.Point(12, 380);
            this.BtnCloseKeypad.Name = "BtnCloseKeypad";
            this.BtnCloseKeypad.Size = new System.Drawing.Size(222, 44);
            this.BtnCloseKeypad.TabIndex = 23;
            this.BtnCloseKeypad.Text = "Fechar";
            this.BtnCloseKeypad.UseVisualStyleBackColor = false;
            this.BtnCloseKeypad.Click += new System.EventHandler(this.CloseButton_Click);
            //
            // NumericKeypad
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.ClientSize = new System.Drawing.Size(246, 436);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCloseKeypad);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnComma);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NumericKeypad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NumericKeypad";
            this.TopBar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Label LClose;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnComma;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnCloseKeypad;
    }
}
