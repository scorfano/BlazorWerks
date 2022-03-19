using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class BsTooltip : BsComponent
    {
        public BsTooltip(object target, object options = null, IJSRuntime jsr = null) : base(target, options, jsr)
        {
        }

        public override string Name { get => "Tooltip"; }

        public BsTooltip Disable()
        { return Invoke<BsTooltip>("disable"); }

        public BsTooltip Enable()
        { return Invoke<BsTooltip>("enable"); }

        public BsTooltip Hide()
        { return Invoke<BsTooltip>("hide"); }

        public BsTooltip Show()
        { return Invoke<BsTooltip>("show"); }

        public BsTooltip Toggle()
        { return Invoke<BsTooltip>("toggle"); }
        
        public BsTooltip ToggleEnabled()
        { return Invoke<BsTooltip>("toggleEnabled"); }

        public BsTooltip Update()
        { return Invoke<BsTooltip>("update"); }
    }
}