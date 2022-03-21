using Microsoft.JSInterop;
using System;

namespace BlazorWerks.Twitter
{
    public class BsModal : BsComponent
    {
        internal BsModal(object target, IJSRuntime jsr = null) : base("Modal", target, jsr)
        {
        }

        public BsModal HandleUpdate()
        { return Invoke<BsModal>("handleUpdate"); }

        public BsModal Hide()
        { return Invoke<BsModal>("hide"); }

        public BsModal Show()
        { return Invoke<BsModal>("show"); }

        public BsModal Toggle()
        { return Invoke<BsModal>("toggle"); }
    }
}