using UnityEngine.Events;

namespace FunColors
{
    public static class ColorPaletteManager
    {
        private static ColorPalette currentPalette;
        public static ColorPalette CurrentPalette
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

        public static ColorPaletteChangedEvent ColorPaletteChanged = new ColorPaletteChangedEvent();

        public static void PaletteChanged()
        {
            ColorPaletteChanged.Invoke(currentPalette);
        }
    }

    public class ColorPaletteChangedEvent : UnityEvent<ColorPalette>
    {
        
    }
}
