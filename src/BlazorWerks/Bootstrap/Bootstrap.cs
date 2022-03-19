using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class Bootstrap : IBootstrap
    {
        protected IJSRuntime jsRuntime { get; set; }

        public Bootstrap() { }

        [ActivatorUtilitiesConstructor]
        public Bootstrap(IJSRuntime jsr)
        {
            jsRuntime = jsr;
        }

        // Static Methods
        // These are limited to using a ElementReference (@ref) as the target

#if NET5_0_OR_GREATER

        // The static methods are unavailable in .NET Core 3.1 as there is no ElementReference.Context that can be
        // used to get the JSRuntime without using DI.

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public static BsAlert Alert(ElementReference target, object options = null) => new BsAlert(target, options);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public static BsButton Button(ElementReference target, object options = null) => new BsButton(target, options);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public static BsCarousel Carousel(ElementReference target, object options = null) => new BsCarousel(target, options);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public static BsCollapse Collapse(ElementReference target, object options = null) => new BsCollapse(target, options);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public static BsDropdown Dropdown(ElementReference target, object options = null) => new BsDropdown(target, options);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public static BsModal Modal(ElementReference target, object options = null) => new BsModal(target, options);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public static BsOffcanvas Offcanvas(ElementReference target, object options = null) => new BsOffcanvas(target, options);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public static BsPopover Popover(ElementReference target, object options = null) => new BsPopover(target, options);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public static BsScrollSpy ScrollSpy(ElementReference target, object options = null) => new BsScrollSpy(target, options);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public static BsTab Tab(ElementReference target, object options = null) => new BsTab(target, options);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public static BsToast Toast(ElementReference target, object options = null) => new BsToast(target, options);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public static BsTooltip Tooltip(ElementReference target, object options = null) => new BsTooltip(target, options);

#endif

        // Instance Methods
        // These accept either an ElementReference or css selector string as the target


        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public BsAlert Alert(object target, object options = null) => new BsAlert(target, options, jsRuntime);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public BsButton Button(object target, object options = null) => new BsButton(target, options, jsRuntime);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public BsCarousel Carousel(object target, object options = null) => new BsCarousel(target, options, jsRuntime);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public BsCollapse Collapse(object target, object options = null) => new BsCollapse(target, options, jsRuntime);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public BsDropdown Dropdown(object target, object options = null) => new BsDropdown(target, options, jsRuntime);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public BsModal Modal(object target, object options = null) => new BsModal(target, options, jsRuntime);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public BsOffcanvas Offcanvas(object target, object options = null) => new BsOffcanvas(target, options, jsRuntime);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public BsPopover Popover(object target, object options = null) => new BsPopover(target, options, jsRuntime);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public BsScrollSpy ScrollSpy(object target, object options = null) => new BsScrollSpy(target, options, jsRuntime);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public BsTab Tab(object target, object options = null) => new BsTab(target, options, jsRuntime);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public BsToast Toast(object target, object options = null) => new BsToast(target, options, jsRuntime);

        /// <summary>
        /// Gets or creates a Bootstrap compoent associated with the document target element
        /// </summary>
        /// <param name="target">An ElementReference or css selector string</param>
        /// <param name="options">An anonymous object of component options</param>
        /// <returns>Bootstrap component</returns>

        public BsTooltip Tooltip(object target, object options = null) => new BsTooltip(target, options, jsRuntime);
    }
}