using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Twitter
{
    public class BsTab : BsComponent
    {
        internal BsTab(object target, IJSRuntime jsr = null) : base("Tab", target, jsr)
        {
        }

        public BsTab Show()
        { return Invoke<BsTab>("show"); }
    }
}