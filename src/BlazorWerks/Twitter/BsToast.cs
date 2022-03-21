using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Twitter
{
    public class BsToast : BsComponent
    {
        public BsToast(object target, IJSRuntime jsr = null) : base("Toast", target, jsr)
        {
        }

        public BsToast Hide()
        { return Invoke<BsToast>("hide"); }

        public BsToast Show()
        { return Invoke<BsToast>("show"); }
    }
}