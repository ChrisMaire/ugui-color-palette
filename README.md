# ugui-color-palette
A basic system for creating color palettes for Unity GUIs.

Instructions:
Open the ColorName enum and add whatever colors you'll want to control via palettes (ie, '', 'hotbar background color' etc)
Right click anywhere in your Project view and press Create -> Color Palette
Call ColorPaletteManager.Instance.SetPalette(yourPalette), passing in a reference to the palette you made.

See the demo scene ColorPaletteTest and PaletteSwitcher script for an example.

To Do:
 - Add TextMesh Pro support! Currently this only supports things that inherits from UnityEngine.UI.Graphic (ie, Image and Text components).
 - Generate the ColorName enum from a list of strings elsewhere so it can be edited without using an IDE.
 - Editor-time color editing; currently this only really sets colors at run time, it'd be great to be able to use in-editor.
