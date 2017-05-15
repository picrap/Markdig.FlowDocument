// Markdig.FlowDocument - a Markdig extension to generate WPF FlowDocuments
// https://github.com/picrap/Markdig.FlowDocument
// MIT License

namespace Markdig.FlowDocument.TextBlock.Inlines
{
    using Renderer;
    using Syntax.Inlines;

    /// <summary>
    ///     A HTML renderer for a <see cref="HtmlEntityInline" />.
    /// </summary>
    /// <seealso cref="HtmlEntityInline" />
    public class HtmlEntityInlineRenderer : TextBlockObjectRenderer<HtmlEntityInline>
    {
        protected override void Write(FlowDocumentRenderer renderer, HtmlEntityInline htmlEntityInline)
        {
        }
    }
}