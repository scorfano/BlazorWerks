using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class BsButton : BsComponent
    {
        internal BsButton(object target, object options = null, IJSRuntime jsr = null) : base("Button", target, options, jsr)
        {
        }

        public BsButton Toggle()
        { return Invoke<BsButton>("toggle"); }
    }
}