using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorWerks.Bootstrap
{
    public class BsCarouselOptions
    {
        /// <summary>
        /// The amount of time to delay between automatically cycling an item. If false, carousel will not automatically cycle.
        /// </summary>
        public int? Interval { get; set; }
        /// <summary>
        /// Whether the carousel should react to keyboard events.
        /// </summary>
        public bool? Keyboard { get; set; }
        /// <summary>
        /// If set to 'hover', pauses the cycling of the carousel on mouseenter and resumes the cycling of the carousel on mouseleave. If set to false, hovering over the carousel won't pause it.
        /// </summary>
        public bool? Pause { get; set; }
        /// <summary>
        /// Autoplays the carousel after the user manually cycles the first item. If set to 'carousel', autoplays the carousel on load.
        /// </summary>
        public bool? Ride { get; set; }
        /// <summary>
        /// Whether the carousel should cycle continuously or have hard stops.
        /// </summary>
        public bool? Wrap { get; set; }
        /// <summary>
        /// Whether the carousel should support left/right swipe interactions on touchscreen devices.
        /// </summary>
        public bool? Touch { get; set; }
    }

}
