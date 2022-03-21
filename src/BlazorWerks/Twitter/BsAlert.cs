using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorWerks.Twitter
{
    public class BsAlert : BsComponent
    {
        internal BsAlert(object target, IJSRuntime jsr = null) : base("Alert", target, jsr)
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