# SmartNumericKeypad

A lightweight Windows Forms control that provides a borderless, draggable on-screen numeric keypad popup for `TextBox` and `NumericUpDown` controls.

---

## 🎯 Purpose

Physical keyboards aren't always available in touch-screen or kiosk-style desktop applications. **NumericKeypad** provides a popup keypad that attaches to any `TextBox` or `NumericUpDown`, letting users enter numeric values by tapping on screen instead.

## ✨ Features

- Borderless, draggable popup window (drag by the top bar)
- Works with both `TextBox` and `NumericUpDown` targets
- Placeholder-aware input — clears placeholder text on the first keystroke
- Doesn't steal focus from the target control (`WS_EX_NOACTIVATE`)
- Portuguese (pt-PT) locale — comma decimal separator, Portuguese labels
- Digits 0–9, decimal separator, backspace, and close button

## 🏗️ Architecture

| Project | Role |
|---|---|
| `NumericKeypad.csproj` | Class library (.NET Framework 4.7.2) containing the `NumericKeypad` popup form |

| File | Purpose |
|---|---|
| `NumericKeypad.cs` | Form logic — constructor, event handlers, target control interaction |
| `NumericKeypad.Designer.cs` | Designer-generated layout (buttons, top bar, labels) |
| `NumericKeypad.resx` | Designer resources for the form |
| `Properties/AssemblyInfo.cs` | Assembly metadata and version info |

## 🛠️ Tech Stack

- **Language**: C#
- **Framework**: .NET Framework 4.7.2
- **UI**: Windows Forms (`System.Windows.Forms`, `System.Drawing`)
- **Packaging**: NuGet package `SmartNumericKeypad`

## 🚀 Quick Start

### Prerequisites
- Visual Studio 2019+ (or MSBuild) with the .NET Framework 4.7.2 targeting pack installed

### Setup
```bash
msbuild NumericKeypad.csproj /p:Configuration=Release /p:Platform=AnyCPU
```
Output: `bin/Release/NumericKeypad.dll`

### Usage
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

## 📋 Configuration

No configuration files are required — behavior is controlled entirely through the constructor:

```csharp
public NumericKeypad(Control target, string placeholderText = null)
```

- `target` — the `TextBox` or `NumericUpDown` to receive input; throws `ArgumentException` if it's neither
- `placeholderText` — optional placeholder value that gets cleared on the first digit press

## 🧪 Testing

No automated test project is included in this repository. Verify changes manually by attaching the keypad to a `TextBox` and a `NumericUpDown` in a test form and exercising digits, backspace, decimal separator, dragging, and close.

## 📦 Distribution

Packaging and publishing to NuGet.org is automated via `nugetPackagePush.cmd`:

```bash
nugetPackagePush.cmd
```

This builds the project (Release), commits/pushes to `main`, packs `NumericKeypad.nuspec`, pushes the package to nuget.org, and tags the release.

> **Note**: The script contains a hardcoded NuGet API key and version numbers (`1.0.0` → `1.0.1`) that must be updated manually before each release. Treat the API key as a secret.

## 📚 Documentation

See [claude.md](claude.md) for the full architecture breakdown, designer layout details, and event-handler reference.

## 🌐 Localization

UI text and decimal-separator behavior are hardcoded to Portuguese (pt-PT): "Teclado Numérico" title, "Fechar" close button, comma (`,`) as the decimal separator.

## 📝 License & Support

- **Author**: João Costa
- **NuGet Package**: [SmartNumericKeypad](https://www.nuget.org/packages/SmartNumericKeypad)
