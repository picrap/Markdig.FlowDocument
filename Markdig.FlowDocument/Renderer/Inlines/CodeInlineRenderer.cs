// Markdig.FlowDocument - a Markdig extension to generate WPF FlowDocuments
// https://github.com/picrap/Markdig.FlowDocument
// MIT License

namespace Markdig.FlowDocument.TextBlock.Inlines
{
    using Renderer;
    using Syntax.Inlines;

    public class CodeInlineRenderer : TextBlockObjectRenderer<CodeInline>
    {
        protected override void Write(FlowDocumentRenderer renderer, CodeInline codeInline)
        {
        }
    }
}