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


        public static BsAlert Alert(ElementReference target, object options = null) => new BsAlert(target, options);

        public static BsButton Button(ElementReference target, object options = null) => new BsButton(target, options);

        public static BsCarousel Carousel(ElementReference target, object options = null) => new BsCarousel(target, options);

        public static BsCollapse Collapse(ElementReference target, object options = null) => new BsCollapse(target, options);

        public static BsDropdown Dropdown(ElementReference target, object options = null) => new BsDropdown(target, options);

        public static BsModal Modal(ElementReference target, object options = null) => new BsModal(target, options);

        public static BsOffcanvas Offcanvas(ElementReference target, object options = null) => new BsOffcanvas(target, options);

        public static BsPopover Popover(ElementReference target, object options = null) => new BsPopover(target, options);

        public static BsScrollSpy ScrollSpy(ElementReference target, object options = null) => new BsScrollSpy(target, options);

        public static BsTab Tab(ElementReference target, object options = null) => new BsTab(target, options);

        public static BsToast Toast(ElementReference target, object options = null) => new BsToast(target, options);

        public static BsTooltip Tooltip(ElementReference target, object options = null) => new BsTooltip(target, options);

#endif

        // Instance Methods
        // These accept either an ElementReference or css selector string as the target



        public BsAlert Alert(object target) => new BsAlert(target, null, jsRuntime);

        public BsButton Button(object target) => new BsButton(target, null, jsRuntime);

        public BsCarousel Carousel(object target, BsCarouselOptions options = null) => new BsCarousel(target, options, jsRuntime);

        public BsCollapse Collapse(object target, BsCollapseOptions options = null) => new BsCollapse(target, options, jsRuntime);

        public BsDropdown Dropdown(object target, BsDropdownOptions options = null) => new BsDropdown(target, options, jsRuntime);

        public BsModal Modal(object target, BsModalOptions options = null) => new BsModal(target, options, jsRuntime);

        public BsOffcanvas Offcanvas(object target, object options = null) => new BsOffcanvas(target, options, jsRuntime);

        public BsPopover Popover(object target, object options = null) => new BsPopover(target, options, jsRuntime);

        public BsScrollSpy ScrollSpy(object target, object options = null) => new BsScrollSpy(target, options, jsRuntime);

        public BsTab Tab(object target, object options = null) => new BsTab(target, options, jsRuntime);

        public BsToast Toast(object target, object options = null) => new BsToast(target, options, jsRuntime);

        public BsTooltip Tooltip(object target, object options = null) => new BsTooltip(target, options, jsRuntime);
    }
}