using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class BsCollapse : BsComponent
    {
        public BsCollapse(object target, object options = null, IJSRuntime jsr = null) : base(target, options, jsr)
        {
        }

        public override string Name { get => "Collapse"; }

        public BsCollapse Hide()
        { return Invoke<BsCollapse>("hide"); }

        public BsCollapse Show()
        { return Invoke<BsCollapse>("show"); }

        public BsCollapse Toggle()
        { return Invoke<BsCollapse>("toggle"); }
    }
}