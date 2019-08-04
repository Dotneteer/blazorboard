using System;

namespace Dotneteer.BlazorBoard.Components.Themes
{
    /// <summary>
    /// This attribute signs that a specific Theme property is not a
    /// CSS variable.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class NonCssAttribute: Attribute
    {
    }
}
