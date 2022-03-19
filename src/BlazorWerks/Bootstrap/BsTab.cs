using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class BsTab : BsComponent
    {
        internal BsTab(object target, object options = null, IJSRuntime jsr = null) : base("Tab", target, options, jsr)
        {
        }

        public BsTab Show()
        { return Invoke<BsTab>("show"); }
    }
}