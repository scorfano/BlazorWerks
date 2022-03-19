using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class BsPopover : BsComponent
    {
        public BsPopover(object target, object options = null, IJSRuntime jsr = null) : base(target, options, jsr)
        {
        }

        public override string Name { get => "Popover"; }

        public BsPopover Disable()
        { return Invoke<BsPopover>("disable"); }

        public BsPopover Enable()
        { return Invoke<BsPopover>("enable"); }

        public BsPopover Hide()
        { return Invoke<BsPopover>("hide"); }

        public BsPopover Show()
        { return Invoke<BsPopover>("show"); }

        public BsPopover Toggle()
        { return Invoke<BsPopover>("toggle"); }
        
        public BsPopover ToggleEnabled()
        { return Invoke<BsPopover>("toggleEnabled"); }

        public BsPopover Update()
        { return Invoke<BsPopover>("update"); }
    }
}