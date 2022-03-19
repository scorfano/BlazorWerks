using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class BsScrollSpy : BsComponent
    {
        public BsScrollSpy(object target, object options = null, IJSRuntime jsr = null) : base(target, options, jsr)
        {
        }

        public override string Name { get => "ScrollSpy"; }

        public BsScrollSpy Refresh()
        { return Invoke<BsScrollSpy>("refresh"); }
    }
}