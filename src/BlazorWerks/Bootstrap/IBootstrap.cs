
namespace BlazorWerks.Bootstrap
{
    public interface IBootstrap
    {
        BsAlert Alert(object target, object options = null);

        BsButton Button(object target, object options = null);

        BsCarousel Carousel(object target, object options = null);

        BsCollapse Collapse(object target, object options = null);

        BsDropdown Dropdown(object target, object options = null);

        BsModal Modal(object target, object options = null);

        BsOffcanvas Offcanvas(object target, object options = null);

        BsPopover Popover(object target, object options = null);

        BsScrollSpy ScrollSpy(object target, object options = null);

        BsTab Tab(object target, object options = null);

        BsToast Toast(object target, object options = null);

        BsTooltip Tooltip(object target, object options = null);
    }
}
