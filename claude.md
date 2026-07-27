# NumericKeypad (SmartNumericKeypad)

A lightweight Windows Forms control library that provides a borderless, draggable on-screen numeric keypad popup for use with `TextBox` and `NumericUpDown` controls. Useful for touch-screen or kiosk-style desktop applications where a physical keyboard may not be convenient.

- **Language**: C#
- **Target Framework**: .NET Framework 4.7.2
- **Output Type**: Class Library (DLL)
- **Root Namespace / Assembly Name**: `NumericKeypad`
- **NuGet Package Id**: `SmartNumericKeypad`
- **Author**: João Costa

---

## File and Folder Structure

```
numeric-keypad/
├── NumericKeypad.cs              # Main Form logic (event handlers, target control interaction)
├── NumericKeypad.Designer.cs     # Designer-generated layout (buttons, panel, labels)
├── NumericKeypad.resx            # Designer resources for the form
├── Properties/
│   └── AssemblyInfo.cs           # Assembly metadata and version info
├── NumericKeypad.csproj          # MSBuild project file (.NET Framework 4.7.2, Library)
├── NumericKeypad.csproj.user     # User-specific MSBuild settings
├── NumericKeypad.slnx            # Solution file
├── NumericKeypad.nuspec          # NuGet package manifest
├── nugetPackagePush.cmd          # Build/pack/push automation script
├── README.md                     # Minimal project readme
└── .gitignore
```

---

## Main Modules & Classes

### `NumericKeypad` (`NumericKeypad.cs` / `NumericKeypad.Designer.cs`)

A borderless popup `Form` (`FormBorderStyle.None`, no taskbar entry, no icon) that renders a numeric keypad and forwards digit/backspace/decimal-separator input to a target control.

#### Key Features
- **Target binding**: Constructed with a target `Control` that must be either a `TextBox` or `NumericUpDown` — throws `ArgumentException` otherwise.
- **Placeholder-aware input**: Optional `placeholderText` is cleared automatically the first time a digit is entered into a `TextBox` showing placeholder text.
- **No focus stealing**: Overrides `CreateParams` to add the `WS_EX_NOACTIVATE` extended window style (`0x08000000`), so clicking the keypad doesn't take focus away from the target control.
- **Draggable window**: The top bar (`TopBar` panel + `LTitle` label) supports mouse-drag repositioning via `MouseDown` / `MouseMove` / `MouseUp` handlers.
- **Portuguese locale**: Decimal separator button inserts a comma (`,`); UI text ("Teclado Numérico", "Fechar") is in Portuguese.
- **NumericUpDown support**: Since `NumericUpDown` has no direct text-append API, digits/backspace/comma are delivered via `SendKeys.Send(...)` after focusing the control.

#### Layout (Designer)
A 246×436 px popup with:
- `TopBar` — draggable gray header with title label (`LTitle`) and close glyph label (`LClose`, "✕")
- Digit buttons `Btn0`–`Btn9` in a 3-column grid
- `BtnComma` (",") for decimal separator
- `BtnBack` ("⌫", orange) for backspace
- `BtnPlus` ("+")
- `BtnCloseKeypad` ("Fechar", red) — closes the form

#### Constructor
```csharp
public NumericKeypad(Control target, string placeholderText = null)
```
- `target`: the `TextBox` or `NumericUpDown` to receive input (required)
- `placeholderText`: optional placeholder value to clear on first keystroke

#### Key Event Handlers
- `TopBar_MouseDown/MouseMove/MouseUp` — implements window dragging via the header
- `DigitButton_Click` — appends the clicked button's `Text` (digit) to a `TextBox`, or sends it as keystrokes to a `NumericUpDown`
- `DecimalSeparatorButton_Click` — inserts `,` if the target doesn't already contain `,` or `.`
- `BackspaceButton_Click` — removes the last character from a `TextBox` (or clears placeholder text), or sends `{BACKSPACE}` to a `NumericUpDown`
- `CloseButton_Click` — closes the popup form

---

## Dependencies & Libraries

### System Libraries (via `NumericKeypad.csproj`)
- **System**, **System.Core** — core framework types
- **System.Drawing** — `Point`, `Color`, `Font` for layout/styling
- **System.Windows.Forms** — `Form`, `Button`, `Panel`, `Label`, `TextBox`, `NumericUpDown`, `SendKeys`
- **System.Data**, **System.Data.DataSetExtensions**, **System.Xml**, **System.Xml.Linq** — default template references (not actively used by the control logic)
- **System.Net.Http**, **Microsoft.CSharp** — default template references

No external NuGet package dependencies are declared (`NumericKeypad.nuspec` lists no dependencies for `.NETFramework4.7.2`).

---

## Usage Instructions

### Building the Project

```bash
msbuild NumericKeypad.csproj /p:Configuration=Release /p:Platform=AnyCPU
```

Output: `bin/Release/NumericKeypad.dll`

### Using the Control in Code

```csharp
using NumericKeypad;

// Attach to a TextBox
var textBox = new TextBox { Text = "Enter amount..." };
var keypad = new NumericKeypad(textBox, placeholderText: "Enter amount...");
keypad.Show();

// Attach to a NumericUpDown
var numericUpDown = new NumericUpDown();
var keypad2 = new NumericKeypad(numericUpDown);
keypad2.Show();
```

Typical pattern: show the keypad on `Enter`/`Click` of the target control, positioned near it, and let the user tap digits, backspace, comma, or "Fechar" to close.

### Packaging / Publishing (`nugetPackagePush.cmd`)

A Windows batch script that automates the release flow:
1. Builds the project in `Release` configuration
2. Commits and pushes to the `main` branch with a version-tagged message
3. Packs the NuGet package via `nuget pack NumericKeypad.nuspec`
4. Pushes the package to nuget.org
5. Creates a git tag for the version
6. Cleans up generated `.nupkg` files

```bash
nugetPackagePush.cmd
```

> **Note**: This script contains a hardcoded NuGet API key and version numbers (`1.0.0` → `1.0.1`) that must be updated manually before each release. Treat the API key as a secret and avoid committing real credentials.

---

## Notes

- **Framework Target**: .NET Framework 4.7.2 — not directly compatible with .NET Core/.NET 5+ without porting.
- **Localization**: UI strings and decimal separator behavior are hardcoded to Portuguese (pt-PT) conventions.
- **Window Behavior**: The form uses `WS_EX_NOACTIVATE` and manual dragging instead of standard title-bar chrome, since `FormBorderStyle` is `None`.
- **`NumericUpDown` input**: Relies on `SendKeys`, which simulates keystrokes at the OS level — this requires the target window to be focusable and may behave unexpectedly if other input is queued at the same time.
