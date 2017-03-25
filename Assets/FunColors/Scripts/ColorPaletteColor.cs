using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FunColors
{
    [System.Serializable]
    public class ColorPaletteColor
    {
        public ColorName name;
        public Color color;

        public ColorPaletteColor() { }

        public ColorPaletteColor(ColorName name, Color color)
        {
            this.name = name;
            this.color = color;
        }
    }
}
