#nullable disable
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;
using System.Reflection;

namespace BlazorWerks.Twitter
{
    public abstract class BsComponent
    {

        // IMPORTANT: InvokeVoidAsync() will fail silently when javascript isn't loaded or when the object or methods names are wrong.
        // This can create difficult to understand errors and it's one thing to check when things stop working.

        const string JS_INVOKE = "BlazorWerks.Bootstrap.invoke";

        public BsComponent(string name, object target, IJSRuntime jsr = null)
        {
            Name = name;

            Target = target;

            JSR = jsr == null && Target is ElementReference ? GetJSRuntime((ElementReference)Target) : jsr;

            //if (options != null) JSR.InvokeVoidAsync(JS_INVOKE, Name, Target, options);

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



        protected IJSRuntime JSR { get; set; }

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
            JSR.InvokeVoidAsync(JS_INVOKE, Name, Target, method, args);
        }


        // Sames as plain Invoke, but returns the Bootstrap component which allows commands to be chained together.

        /// <summary>
        /// Invokes a Bootstrap component JavaScript method and returns "this" to allow chaining of commands.
        /// </summary>
        /// <param name="method">Method name</param>
        /// <param name="args">Optional method arguments</param>
        /// <returns>A Bootstrap component object</returns>
        public T Invoke<T>(string method, params object[] args)
        {
            Invoke(method, args);
            return (T)Convert.ChangeType(this, typeof(T));
        }




    }
}