using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Twitter
{
    public class BsOffcanvas : BsComponent
    {
        internal BsOffcanvas(object target, IJSRuntime jsr = null) : base("Offcanvas", target, jsr)
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