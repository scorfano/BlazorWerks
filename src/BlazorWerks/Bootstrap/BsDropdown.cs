using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class BsDropdown : BsComponent
    {
        public BsDropdown(object target, object options = null, IJSRuntime jsr = null) : base(target, options, jsr)
        {
        }

        public override string Name { get => "Dropdown"; }

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