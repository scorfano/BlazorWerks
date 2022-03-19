using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class BsTab : BsComponent
    {
        public BsTab(object target, object options = null, IJSRuntime jsr = null) : base(target, options, jsr)
        {
        }

        public override string Name { get => "Tab"; }

        public BsTab Show()
        { return Invoke<BsTab>("show"); }
    }
}