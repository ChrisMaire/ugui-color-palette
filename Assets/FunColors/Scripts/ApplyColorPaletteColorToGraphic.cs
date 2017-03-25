using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FunColors
{
    /// <summary>
    /// Component to be added to a graphic (ie, UGUI Text or Image) to have its color set by the current palette.
    /// </summary>
    public class ApplyColorPaletteColorToGraphic : MonoBehaviour
    {
        public ColorName color;
        [HideInInspector]
        public Graphic targetGraphic;

        public void Awake()
        {
            targetGraphic = GetComponent<Graphic>();
            ColorPaletteManager.Instance.ColorPaletteChanged.AddListener(ApplyColorPalette);
        }

        public void ApplyColorPalette(ColorPalette newPallete)
        {
            if (targetGraphic != null)
            {
                if (newPallete.ColorsByName.ContainsKey(color))
                {
                    targetGraphic.color = newPallete.ColorsByName[color].color;
                }
            }
        }
    }
}