using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class BsOffcanvas : BsComponent
    {
        public BsOffcanvas(object target, object options = null, IJSRuntime jsr = null) : base(target, options, jsr)
        {
        }

        public override string Name { get => "Offcanvas"; }

        public BsOffcanvas Hide()
        { return Invoke<BsOffcanvas>("hide"); }

        public BsOffcanvas Show()
        { return Invoke<BsOffcanvas>("show"); }

        public BsOffcanvas Toggle()
        { return Invoke<BsOffcanvas>("toggle"); }
    }
}