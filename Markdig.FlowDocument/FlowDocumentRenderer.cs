// Markdig.FlowDocument - a Markdig extension to generate WPF FlowDocuments
// https://github.com/picrap/Markdig.FlowDocument
// MIT License

namespace Markdig.FlowDocument
{
    using System.Collections.Generic;
    using System.Windows.Documents;
    using Renderer;
    using Renderers;
    using Syntax;
    using TextBlock.Inlines;
    using Block = System.Windows.Documents.Block;

    public class FlowDocumentRenderer : RendererBase
    {
        public FlowDocument Root;
        internal BlockCollection Blocks;

        /// <summary>
        ///     Initializes a new instance of the <see cref="FlowDocumentRenderer" /> class.
        /// </summary>
        public FlowDocumentRenderer()
        {
            // Default block renderers
            ObjectRenderers.Add(new CodeBlockRenderer());
            ObjectRenderers.Add(new ListRenderer());
            ObjectRenderers.Add(new HeadingRenderer());
            ObjectRenderers.Add(new HtmlBlockRenderer());
            ObjectRenderers.Add(new ParagraphRenderer());
            ObjectRenderers.Add(new QuoteBlockRenderer());
            ObjectRenderers.Add(new ThematicBreakRenderer());

            // Default inline renderers
            ObjectRenderers.Add(new AutolinkInlineRenderer());
            ObjectRenderers.Add(new CodeInlineRenderer());
            ObjectRenderers.Add(new DelimiterInlineRenderer());
            ObjectRenderers.Add(new EmphasisInlineRenderer());
            ObjectRenderers.Add(new LineBreakInlineRenderer());
            ObjectRenderers.Add(new HtmlInlineRenderer());
            ObjectRenderers.Add(new HtmlEntityInlineRenderer());
            ObjectRenderers.Add(new LinkInlineRenderer());
            ObjectRenderers.Add(new LiteralInlineRenderer());
        }

        public override object Render(MarkdownObject markdownObject)
        {
            Root = new FlowDocument();
            Blocks = Root.Blocks;
            Write(markdownObject);
            return null;
        }

        public void Push(Block block, BlockCollection blocks, IEnumerable<MarkdownObject> children)
        {
            var currentBlocks = Blocks;
            Blocks.Add(block);
            Blocks = blocks;
            foreach (var child in children)
                Write(child);
            Blocks = currentBlocks;
        }

        public void Push(Block block)
        {
            Blocks.Add(block);
        }
    }
}