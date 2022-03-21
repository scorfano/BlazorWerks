using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Twitter
{
    public class BsCollapse : BsComponent
    {
        internal BsCollapse(object target, IJSRuntime jsr = null) : base("Collapse", target, jsr)
        {
        }

        public BsCollapse Hide()
        { return Invoke<BsCollapse>("hide"); }

        public BsCollapse Show()
        { return Invoke<BsCollapse>("show"); }

        public BsCollapse Toggle()
        { return Invoke<BsCollapse>("toggle"); }
    }
}