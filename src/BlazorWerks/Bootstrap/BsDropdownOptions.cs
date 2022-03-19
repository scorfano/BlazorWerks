using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorWerks.Bootstrap
{
    public class BsDropdownOptions
    {
        /// <summary>
        /// ElementReference or CSS selector. Overflow constraint boundary of the dropdown menu (applies only to Popper's preventOverflow modifier). By default it's 'clippingParents' and can accept an HTMLElement reference (via JavaScript only). For more information refer to Popper's detectOverflow docs.
        /// </summary>
        public object Boundary { get; set; }

        /// <summary>
        /// ElementReference or CSS selector. Reference element of the dropdown menu. Accepts the values of 'toggle', 'parent', an HTMLElement reference or an object providing getBoundingClientRect. For more information refer to Popper's constructor docs and virtual element docs. 
        /// </summary>
        public object Reference { get; set; }

        /// <summary>
        /// By default, we use Popper for dynamic positioning. Disable this with static.
        /// </summary>
        public string Display { get; set; }

        /// <summary>
        /// Offset of the dropdown relative to its target. You can pass a string in data attributes with comma separated values like: data-bs-offset="10,20"
        /// </summary>
        public int?[] Offset { get; set; }

        /// <summary>
        /// Configure the auto close behavior of the dropdown. See Bootstrap docs.
        /// </summary>
        public bool? AutoClose { get; set; }

        /// <summary>
        /// To change Bootstrap's default Popper config, see Bootstrap docs Popper configuration.
        /// </summary>
        public object PopperConfig { get; set; }
    }


}
