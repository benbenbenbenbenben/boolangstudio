using BooLangService;
using Microsoft.VisualStudio.Package;
using Microsoft.VisualStudio.TextManager.Interop;

namespace Boo.BooLangService
{
    public class BooViewFilter : ViewFilter
    {
        public BooViewFilter(CodeWindowManager mgr, IVsTextView view) : base(mgr, view)
        {}

        public override bool HandleSmartIndent()
        {
            return new HandleSmartIndentAction((ISource)Source, TextView)
                .Execute();
        }
    }
}