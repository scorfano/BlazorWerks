using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class BsToast : BsComponent
    {
        public BsToast(object target, object options = null, IJSRuntime jsr = null) : base(target, options, jsr)
        {
        }

        public override string Name { get => "Toast"; }

        public BsToast Hide()
        { return Invoke<BsToast>("hide"); }

        public BsToast Show()
        { return Invoke<BsToast>("show"); }
    }
}