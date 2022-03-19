
namespace BlazorWerks.Bootstrap
{
    public interface IBootstrap
    {
        BsAlert Alert(object target);

        BsButton Button(object target);

        BsCarousel Carousel(object target, BsCarouselOptions options = null);

        BsCollapse Collapse(object target, BsCollapseOptions options = null);

        BsDropdown Dropdown(object target, BsDropdownOptions options = null);

        BsModal Modal(object target, BsModalOptions options = null);

        BsOffcanvas Offcanvas(object target, object options = null);

        BsPopover Popover(object target, object options = null);

        BsScrollSpy ScrollSpy(object target, object options = null);

        BsTab Tab(object target, object options = null);

        BsToast Toast(object target, object options = null);

        BsTooltip Tooltip(object target, object options = null);
    }
}
