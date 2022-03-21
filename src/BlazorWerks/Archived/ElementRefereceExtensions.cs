using Microsoft.AspNetCore.Components;

namespace BlazorWerks.Bootstrap
{
    public static class ElementReferenceExtensions
    {

        public static BsAlert Alert(this ElementReference target) => new BsAlert(target);

        public static BsButton Button(this ElementReference target) => new BsButton(target);

        public static BsCarousel Carousel(this ElementReference target) => new BsCarousel(target);

        public static BsCollapse Collapse(this ElementReference target) => new BsCollapse(target);

        public static BsDropdown Dropdown(this ElementReference target) => new BsDropdown(target);

        public static BsModal Modal(this ElementReference target) => new BsModal(target);

        public static BsOffcanvas Offcanvas(this ElementReference target) => new BsOffcanvas(target);

        public static BsPopover Popover(this ElementReference target) => new BsPopover(target);

        public static BsScrollSpy ScrollSpy(this ElementReference target) => new BsScrollSpy(target);

        public static BsTab Tab(this ElementReference target) => new BsTab(target);

        public static BsToast Toast(this ElementReference target) => new BsToast(target);

        public static BsTooltip Tooltip(this ElementReference target) => new BsTooltip(target);
    }
}