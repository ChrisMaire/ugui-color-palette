using UnityEditor;
using UnityEngine;

namespace FunColors
{
    [CustomEditor(typeof(ColorPalette))]
    public class ColorPaletteEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            if (GUILayout.Button("Apply Palette"))
            {
                ColorPalette palette = (ColorPalette) target;

                ColorPaletteManager.CurrentPalette = palette;

                ApplyColorPaletteColorToGraphic[] applyTo = FindObjectsOfType<ApplyColorPaletteColorToGraphic>();
                foreach (var applyTarget in applyTo)
                {
                    applyTarget.ApplyColorPalette(palette);
                }

                //this isn't actually doing anything in edit mode?
                Canvas.ForceUpdateCanvases();
            }
        }
    }
}
