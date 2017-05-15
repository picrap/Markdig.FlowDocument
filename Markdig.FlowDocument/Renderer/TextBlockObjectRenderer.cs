// Markdig.FlowDocument - a Markdig extension to generate WPF FlowDocuments
// https://github.com/picrap/Markdig.FlowDocument
// MIT License

namespace Markdig.FlowDocument.Renderer
{
    using Renderers;
    using Syntax;

    /// <summary>
    ///     A base class for HTML rendering <see cref="Block" /> and <see cref="Markdig.Syntax.Inlines.Inline" /> Markdown
    ///     objects.
    /// </summary>
    /// <typeparam name="TObject">The type of the object.</typeparam>
    /// <seealso cref="Markdig.Renderers.IMarkdownObjectRenderer" />
    public abstract class TextBlockObjectRenderer<TObject> : MarkdownObjectRenderer<FlowDocumentRenderer, TObject>
        where TObject : MarkdownObject
    {
    }
}