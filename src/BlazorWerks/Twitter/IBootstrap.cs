
using Microsoft.AspNetCore.Components;

namespace BlazorWerks.Twitter
{
    public interface IBootstrap
    {
        // by ElementReference

        BsAlert Alert(ElementReference element);
        BsButton Button(ElementReference element);
        BsCarousel Carousel(ElementReference element);
        BsCollapse Collapse(ElementReference element);
        BsDropdown Dropdown(ElementReference element);
        BsModal Modal(ElementReference element);
        BsOffcanvas Offcanvas(ElementReference element);
        BsPopover Popover(ElementReference element);
        BsScrollSpy ScrollSpy(ElementReference element);
        BsTab Tab(ElementReference element);
        BsToast Toast(ElementReference element);
        BsTooltip Tooltip(ElementReference element);

        // by css selector string

        BsAlert Alert(string cssSelector);
        BsButton Button(string cssSelector);
        BsCarousel Carousel(string cssSelector);
        BsCollapse Collapse(string cssSelector);
        BsDropdown Dropdown(string cssSelector);
        BsModal Modal(string cssSelector);
        BsOffcanvas Offcanvas(string cssSelector);
        BsPopover Popover(string cssSelector);
        BsScrollSpy ScrollSpy(string cssSelector);
        BsTab Tab(string cssSelector);
        BsToast Toast(string cssSelector);
        BsTooltip Tooltip(string cssSelector);
    }
}
