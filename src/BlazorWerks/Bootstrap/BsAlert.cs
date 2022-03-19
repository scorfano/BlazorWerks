using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class BsAlert : BsComponent
    {
        internal BsAlert(object target, object options = null, IJSRuntime jsr = null) : base("Alert", target, options, jsr)
        {
        }

        /// <summary>
        /// Programmatically closes the alert.
        /// </summary>
        /// <returns>this</returns>
        public BsAlert Close()
        { return Invoke<BsAlert>("close"); }
    }
}