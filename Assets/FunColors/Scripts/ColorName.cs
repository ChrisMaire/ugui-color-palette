namespace FunColors
{
    /// <summary>
    /// A way of creating a unique ID for each color represented in the game.
    /// Could be done w/ strings but enums (with fixed values) will make changing names
    /// easier / less unpredictable.
    ///  
    /// Think of each entry in this enum as being a CSS class I guess.
    /// </summary>
    public enum ColorName
    {
        None = 0,
        UIHeader = 1,
        UIParagraph = 2,
        UIImage = 3,
        NumColors
    }
}
