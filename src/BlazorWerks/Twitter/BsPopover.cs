using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Twitter
{
    public class BsPopover : BsComponent
    {
        internal BsPopover(object target, IJSRuntime jsr = null) : base("Popover", target, jsr)
        {
        }

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