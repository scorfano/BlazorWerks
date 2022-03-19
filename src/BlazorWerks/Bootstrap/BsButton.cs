using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class BsButton : BsComponent
    {
        public BsButton(object target, object options = null, IJSRuntime jsr = null) : base(target, options, jsr)
        {
        }

        public override string Name { get => "Button"; }

        public BsButton Toggle()
        { return Invoke<BsButton>("toggle"); }
    }
}