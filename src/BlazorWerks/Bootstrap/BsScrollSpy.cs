using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class BsScrollSpy : BsComponent
    {
        internal BsScrollSpy(object target, object options = null, IJSRuntime jsr = null) : base("ScrollSpy", target, options, jsr)
        {
        }

        public BsScrollSpy Refresh()
        { return Invoke<BsScrollSpy>("refresh"); }
    }
}