using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Twitter
{
    public class BsDropdown : BsComponent
    {
        internal BsDropdown(object target, IJSRuntime jsr = null) : base("Dropdown", target, jsr)
        {
        }

        public BsDropdown Hide()
        { return Invoke<BsDropdown>("hide"); }

        public BsDropdown Show()
        { return Invoke<BsDropdown>("show"); }

        public BsDropdown Toggle()
        { return Invoke<BsDropdown>("toggle"); }

        public BsDropdown Update()
        { return Invoke<BsDropdown>("update"); }
    }
}