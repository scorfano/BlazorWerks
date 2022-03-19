using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class BsAlert : BsComponent
    {
        public BsAlert(object target, object options = null, IJSRuntime jsr = null) : base(target, options, jsr)
        {
        }

        public override string Name { get => "Alert"; }

        public BsAlert Close()
        { return Invoke<BsAlert>("close"); }
    }
}