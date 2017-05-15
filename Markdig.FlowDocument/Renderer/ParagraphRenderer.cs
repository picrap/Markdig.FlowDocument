// Markdig.FlowDocument - a Markdig extension to generate WPF FlowDocuments
// https://github.com/picrap/Markdig.FlowDocument
// MIT License

namespace Markdig.FlowDocument.Renderer
{
    using System.Windows.Documents;
    using Syntax;

    public class ParagraphRenderer : TextBlockObjectRenderer<ParagraphBlock>
    {
        protected override void Write(FlowDocumentRenderer renderer, ParagraphBlock paragraphBlock)
        {
            renderer.Push(new Span(), paragraphBlock.Inline);
        }
    }
}