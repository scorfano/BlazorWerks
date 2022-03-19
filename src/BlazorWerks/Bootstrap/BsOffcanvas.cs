using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class BsOffcanvas : BsComponent
    {
        internal BsOffcanvas(object target, object options = null, IJSRuntime jsr = null) : base("Offcanvas", target, options, jsr)
        {
        }

        public BsOffcanvas Hide()
        { return Invoke<BsOffcanvas>("hide"); }

        public BsOffcanvas Show()
        { return Invoke<BsOffcanvas>("show"); }

        public BsOffcanvas Toggle()
        { return Invoke<BsOffcanvas>("toggle"); }
    }
}