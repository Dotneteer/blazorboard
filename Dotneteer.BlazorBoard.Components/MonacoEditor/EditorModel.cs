using System;

namespace Dotneteer.BlazorBoard.Components.MonacoEditor
{
    public class EditorModel
    {
        public string Script { get; set; } = "// Code goes here";
        public string Language { get; set; } = "javascript";
        public string Id { get; set; } = $"BlazorMonaco_{Guid.NewGuid()}";
    }
}
