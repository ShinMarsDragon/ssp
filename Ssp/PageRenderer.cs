using Stubble.Core;

namespace Ssp
{
    public class PageRenderer
    {
        private StubbleVisitorRenderer Stubble {get;}
        private string Template {get;}
        public PageRenderer(StubbleVisitorRenderer stubble, string template)
        {
            Stubble = stubble;
            Template = template;
        }

        public string Render(PageData data)
        {
            return Stubble.Render(Template, data);
        }
    }
}