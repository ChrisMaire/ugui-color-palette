using System.Collections.Generic;
using FunColors;
using UnityEngine;

public class PaletteSwitcher : MonoBehaviour
{
    public List<ColorPalette> palettes;
    private int currPalette = 0;

    void Start()
    {
        ColorPaletteManager.CurrentPalette = palettes[currPalette];
    }

	void Update () {
	    if (Input.GetKeyUp(KeyCode.LeftArrow))
	    {
            UpdatePalette(-1);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
	    {
	        UpdatePalette(1);
        }
    }

    void UpdatePalette(int dir)
    {
        currPalette += dir;

        if (currPalette >= palettes.Count)
        {
            currPalette = 0;
        } else if (currPalette < 0)
        {
            currPalette = palettes.Count - 1;
        }

        ColorPaletteManager.CurrentPalette = palettes[currPalette];
    }
}
