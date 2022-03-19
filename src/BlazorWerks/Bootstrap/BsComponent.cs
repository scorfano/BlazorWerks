#nullable disable
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Reflection;

namespace BlazorWerks.Bootstrap
{
    public abstract class BsComponent 
    {
        const string JS_INVOKE = "BlazorTools.Bootstrap.invoke";


        public BsComponent(string name, object target, object options = null, IJSRuntime jsr = null) 
        {
            Name = name;

            Target = target;

            jsRuntime = jsr == null && Target is ElementReference ? GetJSRuntime((ElementReference)Target) : jsr;

            if (options != null) jsRuntime.InvokeVoidAsync(JS_INVOKE, Name, Target, options);

        }



        // A fallback method to pull the JSRuntime from an ElementReferece via reflection.
        // Must use reflection, which has some overhead, as the property is not public.

        internal static IJSRuntime GetJSRuntime(ElementReference element)
        {

#if NET5_0_OR_GREATER

            if (!(element.Context is WebElementReferenceContext context))
            {
                throw new InvalidOperationException("ElementReference is unassigned or not configured correctly.");
            }

            //JSRuntime is marked internal in WebElementReferenceContext so must get value using reflection

            IJSRuntime jsr = context.GetType()
                ?.GetProperty("JSRuntime", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                ?.GetValue(context) as IJSRuntime;

            if (jsr == null) throw new InvalidOperationException("No JavaScript runtime found.");

            return jsr;

#else
            // Method fails with .NET Core 3.1 because ElementReference.Context does not exist.
            // However, shouldn't reach this point as the static methods, which would require this,
            // are disabled in 3.1 as it must use the DI instance (which has all the same methods).

            return null;
#endif
        }



        protected IJSRuntime jsRuntime { get; set; }

        protected readonly string Name = "";

        protected object Target { get; set; }

        // TODO - Might be possible in .NET +5.0 to invoke the Bootstrap methods using a
        // JSObjectReferece without the need for a custom JavaScript function, as now.
        // Low priority as the existing way works with .NET Core 3.1 and up.

        /// <summary>
        /// Invokes a Bootstrap component JavaScript method.
        /// </summary>
        /// <param name="method">Method name</param>
        /// <param name="args">Optional method arguments</param>
        protected void Invoke(string method, params object[] args)
        {
            jsRuntime?.InvokeVoidAsync(JS_INVOKE, Name, Target, null, method, args);
        }
        /// <summary>
        /// Invokes a Bootstrap component JavaScript method.
        /// </summary>
        /// <typeparam name="T">Type of return value</typeparam>
        /// <param name="method">Method name</param>
        /// <param name="args">Optional method arguments</param>
        /// <returns></returns>
        protected T Invoke<T>(string method, params object[] args)
        {
            Invoke(method, args);
            return (T)Convert.ChangeType(this, typeof(T));
        }
    }
}