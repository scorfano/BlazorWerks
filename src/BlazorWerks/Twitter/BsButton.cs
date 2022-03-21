using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Twitter
{
    public class BsButton : BsComponent
    {
        internal BsButton(object target, IJSRuntime jsr = null) : base("Button", target, jsr)
        {
        }

        public BsButton Toggle()
        { return Invoke<BsButton>("toggle"); }
    }
}