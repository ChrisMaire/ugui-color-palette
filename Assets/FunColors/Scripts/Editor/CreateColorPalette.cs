using UnityEngine;
using System.Collections;
using System.IO;
using UnityEditor;

namespace FunColors
{
    public class CreateColorPalette
    {
        [MenuItem("Assets/Create/Color Palette")]
        public static ColorPalette Create()
        {
            ColorPalette asset = ScriptableObject.CreateInstance<ColorPalette>();
            asset.UpdateColorList();

            string path = AssetDatabase.GetAssetPath(Selection.activeObject);
            if (path == "")
            {
                path = "Assets";
            }
            else if (Path.GetExtension(path) != "")
            {
                path = path.Replace(Path.GetFileName(AssetDatabase.GetAssetPath(Selection.activeObject)), "");
            }

            AssetDatabase.CreateAsset(asset, path + "/NewColorPalette.asset");
            AssetDatabase.SaveAssets();
            return asset;
        }
    }
}