using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class BsCollapse : BsComponent
    {
        internal BsCollapse(object target, object options = null, IJSRuntime jsr = null) : base("Collapse", target, options, jsr)
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