using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Twitter
{
    public class BsScrollSpy : BsComponent
    {
        internal BsScrollSpy(object target, IJSRuntime jsr = null) : base("ScrollSpy", target, jsr)
        {
        }

        public BsScrollSpy Refresh()
        { return Invoke<BsScrollSpy>("refresh"); }
    }
}