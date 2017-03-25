using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace FunColors
{
    /// <summary>
    /// Store a list of colors and their names (using the ColorName enum)
    /// This is gonna very quickly fall apart if we start adding and changing colors at runtime.
    /// </summary>
    [System.Serializable]
    public class ColorPalette : ScriptableObject
    {
        public string Name = "New Color Palette";

        public List<ColorPaletteColor> Colors = new List<ColorPaletteColor>();
        public Dictionary<ColorName, ColorPaletteColor> ColorsByName = new Dictionary<ColorName, ColorPaletteColor>();

        private bool initialized = false;

        /// <summary>
        /// Set up the ColorsByName dictionary so we can easily access colors later.
        /// Not happy with this implementation, but I also want to keep this using standard classes
        /// instead of pulling in an ObservableCollection class from .NET 4 (which I don't think Unity has yet)
        /// </summary>
        public void Initialize()
        {
            ColorsByName = Colors.ToDictionary(c => c.name);
        }

        public void UpdateColorList()
        {
            for (int i = 1; i < (int)ColorName.NumColors; i++)
            {
                ColorName name = (ColorName) i;
                bool hasColor = false;
                for (int j = 0; j < Colors.Count; j++)
                {
                    if (Colors[j].name == name)
                    {
                        hasColor = true;
                        break;
                    }
                }

                if (!hasColor)
                {
                    Colors.Add(new ColorPaletteColor(name, Color.white));
                }
            }
        }
    }
}

