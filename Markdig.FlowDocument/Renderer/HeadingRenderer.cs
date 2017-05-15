// Markdig.FlowDocument - a Markdig extension to generate WPF FlowDocuments
// https://github.com/picrap/Markdig.FlowDocument
// MIT License

namespace Markdig.FlowDocument.Renderer
{
    using System.Windows.Documents;
    using System.Windows.Media;
    using Syntax;

    public class HeadingRenderer : TextBlockObjectRenderer<HeadingBlock>
    {
        protected override void Write(FlowDocumentRenderer renderer, HeadingBlock headingBlock)
        {
            renderer.Push(new Span {Foreground = new SolidColorBrush(Colors.Red)}, headingBlock.Inline);
        }
    }
}