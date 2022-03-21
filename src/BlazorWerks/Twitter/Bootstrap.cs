using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;

namespace BlazorWerks.Twitter
{
    public class Bootstrap : IBootstrap
    {
        protected IJSRuntime JSR { get; set; }

        public Bootstrap() 
        { 
        }

        [ActivatorUtilitiesConstructor]
        public Bootstrap(IJSRuntime jsr)
        {
            JSR = jsr;
        }

        // by ElementReference
        
        public BsAlert Alert(ElementReference element) => new BsAlert(element, JSR);
        public BsButton Button(ElementReference element) => new BsButton(element, JSR);
        public BsCarousel Carousel(ElementReference element) => new BsCarousel(element, JSR);
        public BsCollapse Collapse(ElementReference element) => new BsCollapse(element, JSR);
        public BsDropdown Dropdown(ElementReference element) => new BsDropdown(element, JSR);
        public BsModal Modal(ElementReference element) => new BsModal(element, JSR);
        public BsOffcanvas Offcanvas(ElementReference element) => new BsOffcanvas(element, JSR);
        public BsPopover Popover(ElementReference element) => new BsPopover(element, JSR);
        public BsScrollSpy ScrollSpy(ElementReference element) => new BsScrollSpy(element, JSR);
        public BsTab Tab(ElementReference element) => new BsTab(element, JSR);
        public BsToast Toast(ElementReference element) => new BsToast(element, JSR);
        public BsTooltip Tooltip(ElementReference element) => new BsTooltip(element, JSR);

        // by css selector string

        public BsAlert Alert(string cssSelector) => new BsAlert(cssSelector, JSR);
        public BsButton Button(string cssSelector) => new BsButton(cssSelector, JSR);
        public BsCarousel Carousel(string cssSelector) => new BsCarousel(cssSelector, JSR);
        public BsCollapse Collapse(string cssSelector) => new BsCollapse(cssSelector, JSR);
        public BsDropdown Dropdown(string cssSelector) => new BsDropdown(cssSelector, JSR);
        public BsModal Modal(string cssSelector) => new BsModal(cssSelector, JSR);
        public BsOffcanvas Offcanvas(string cssSelector) => new BsOffcanvas(cssSelector, JSR);
        public BsPopover Popover(string cssSelector) => new BsPopover(cssSelector, JSR);
        public BsScrollSpy ScrollSpy(string cssSelector) => new BsScrollSpy(cssSelector, JSR);
        public BsTab Tab(string cssSelector) => new BsTab(cssSelector, JSR);
        public BsToast Toast(string cssSelector) => new BsToast(cssSelector, JSR);
        public BsTooltip Tooltip(string cssSelector) => new BsTooltip(cssSelector, JSR);
    }
}