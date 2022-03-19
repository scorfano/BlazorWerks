namespace BlazorWerks.Bootstrap
{

    /// <summary>
    /// A pseudo enum helper of events names that can be compared to the BootstrapEventArgs.EventType property for branching and filtering.
    /// </summary>


    public class BootstrapEvents
    {
        private BootstrapEvents(string value) { Value = value; }

        public string Value { get; private set; }

        // Allows us to use the value directly like string s = BootstrapEvents.AlertClose; with the .Value being implicit.

        public static implicit operator string(BootstrapEvents item) 
        {
            return item.Value;
        }
        
        // Allows us to cast a string directly to new BootstrapEvents

        public static explicit operator BootstrapEvents(string value)
        {
            return new BootstrapEvents(value);
        }

        public static BootstrapEvents AlertClose => (BootstrapEvents) "close.bs.alert";
        public static BootstrapEvents AlertClosed => (BootstrapEvents) "closed.bs.alert";
        public static BootstrapEvents CarouselSlide => (BootstrapEvents) "slide.bs.carousel";
        public static BootstrapEvents CarouselSlid => (BootstrapEvents) "slid.bs.carousel";
        public static BootstrapEvents CollapseShow => (BootstrapEvents) "show.bs.collapse";
        public static BootstrapEvents CollapseShown => (BootstrapEvents) "shown.bs.collapse";
        public static BootstrapEvents CollapseHide => (BootstrapEvents) "hide.bs.collapse";
        public static BootstrapEvents CollapseHidden => (BootstrapEvents) "hidden.bs.collapse";
        public static BootstrapEvents DropdownShow => (BootstrapEvents) "show.bs.dropdown";
        public static BootstrapEvents DropdownShown => (BootstrapEvents) "shown.bs.dropdown";
        public static BootstrapEvents DropdownHide => (BootstrapEvents) "hide.bs.dropdown";
        public static BootstrapEvents DropdownHidden => (BootstrapEvents) "hidden.bs.dropdown";
        public static BootstrapEvents ModalShow => (BootstrapEvents) "show.bs.modal";
        public static BootstrapEvents ModalShown => (BootstrapEvents) "shown.bs.modal";
        public static BootstrapEvents ModalHide => (BootstrapEvents) "hide.bs.modal";
        public static BootstrapEvents ModalHidden => (BootstrapEvents) "hidden.bs.modal";
        public static BootstrapEvents ModalHidePrevented => (BootstrapEvents) "hidePrevented.bs.modal";
        public static BootstrapEvents OffcanvasShow => (BootstrapEvents) "show.bs.offcanvas";
        public static BootstrapEvents OffcanvasHide => (BootstrapEvents) "hide.bs.offcanvas";
        public static BootstrapEvents OffcanvasHidden => (BootstrapEvents) "hidden.bs.offcanvas";
        public static BootstrapEvents PopoverShow => (BootstrapEvents) "show.bs.popover";
        public static BootstrapEvents PopoverShown => (BootstrapEvents) "shown.bs.popover";
        public static BootstrapEvents PopoverHide => (BootstrapEvents) "hide.bs.popover";
        public static BootstrapEvents PopoverHidden => (BootstrapEvents) "hidden.bs.popover";
        public static BootstrapEvents PopoverInserted => (BootstrapEvents) "inserted.bs.popover";
        public static BootstrapEvents ScrollSpyActivate => (BootstrapEvents) "activate.bs.scrollspy";
        public static BootstrapEvents TabShow => (BootstrapEvents) "show.bs.tab";
        public static BootstrapEvents TabShown => (BootstrapEvents) "shown.bs.tab";
        public static BootstrapEvents TabHide => (BootstrapEvents) "hide.bs.tab";
        public static BootstrapEvents TabHidden => (BootstrapEvents) "hidden.bs.tab";
        public static BootstrapEvents ToastShow => (BootstrapEvents) "show.bs.toast";
        public static BootstrapEvents ToastShown => (BootstrapEvents) "shown.bs.toast";
        public static BootstrapEvents ToastHide => (BootstrapEvents) "hide.bs.toast";
        public static BootstrapEvents ToastHidden => (BootstrapEvents) "hidden.bs.toast";
        public static BootstrapEvents TooltipShow => (BootstrapEvents) "show.bs.tooltip";
        public static BootstrapEvents TooltipShown => (BootstrapEvents) "shown.bs.tooltip";
        public static BootstrapEvents TooltipHide => (BootstrapEvents) "hide.bs.tooltip";
        public static BootstrapEvents TooltipHidden => (BootstrapEvents) "hidden.bs.tooltip";
        public static BootstrapEvents TooltipInserted => (BootstrapEvents) "inserted.bs.tooltip";
    }
}
