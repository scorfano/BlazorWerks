using Microsoft.AspNetCore.Components;

namespace BlazorWerks.Bootstrap
{
    public static class ElementReferenceExtensions
    {
        public static BsAlert Alert(this ElementReference target) => new BsAlert(target);

        public static BsButton Button(this ElementReference target, object options = null) => new BsButton(target, options);

        public static BsCarousel Carousel(this ElementReference target, object options = null) => new BsCarousel(target, options);

        public static BsCollapse Collapse(this ElementReference target, object options = null) => new BsCollapse(target, options);

        public static BsDropdown Dropdown(this ElementReference target, object options = null) => new BsDropdown(target, options);

        public static BsModal Modal(this ElementReference target, object options = null) => new BsModal(target, options);

        public static BsOffcanvas Offcanvas(this ElementReference target, object options = null) => new BsOffcanvas(target, options);

        public static BsPopover Popover(this ElementReference target, object options = null) => new BsPopover(target, options);

        public static BsScrollSpy ScrollSpy(this ElementReference target, object options = null) => new BsScrollSpy(target, options);

        public static BsTab Tab(this ElementReference target, object options = null) => new BsTab(target, options);

        public static BsToast Toast(this ElementReference target, object options = null) => new BsToast(target, options);

        public static BsTooltip Tooltip(this ElementReference target, object options = null) => new BsTooltip(target, options);
    }
}