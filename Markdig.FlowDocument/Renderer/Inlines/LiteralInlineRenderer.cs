// Markdig.FlowDocument - a Markdig extension to generate WPF FlowDocuments
// https://github.com/picrap/Markdig.FlowDocument
// MIT License

namespace Markdig.FlowDocument.TextBlock.Inlines
{
    using System.Windows.Documents;
    using Renderer;
    using Syntax.Inlines;

    public class LiteralInlineRenderer : TextBlockObjectRenderer<LiteralInline>
    {
        protected override void Write(FlowDocumentRenderer renderer, LiteralInline literalInline)
        {
            renderer.Push(new Run(literalInline.Content.ToString()));
        }
    }
}