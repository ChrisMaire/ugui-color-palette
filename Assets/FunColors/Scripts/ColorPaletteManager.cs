using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace FunColors
{
    public class ColorPaletteManager : MonoBehaviour
    {
        private ColorPalette currentPalette;
        public ColorPalette CurrentPalette
        {
            get
            {
                return currentPalette;
            }

            set
            {
                currentPalette = value;

                CurrentPalette.Initialize();

                PaletteChanged();
            }
        }

        private static ColorPaletteManager instance;
        public static ColorPaletteManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = FindObjectOfType<ColorPaletteManager>();
                    if (instance == null)
                    {
                        instance = GameObject.Instantiate<ColorPaletteManager>(Resources.Load<ColorPaletteManager>("Prefabs/ColorPaletteManager"));
                    }
                }
                return instance;
            }
        }

        public ColorPaletteChangedEvent ColorPaletteChanged = new ColorPaletteChangedEvent();

        public void SetPalette(ColorPalette newPalette)
        {
            CurrentPalette = newPalette;
        }

        public void PaletteChanged()
        {
            ColorPaletteChanged.Invoke(currentPalette);
        }
    }

    public class ColorPaletteChangedEvent : UnityEvent<ColorPalette>
    {
        
    }
}
