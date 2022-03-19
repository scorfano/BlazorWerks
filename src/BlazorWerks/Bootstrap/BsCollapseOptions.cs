using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorWerks.Bootstrap
{
    public class BsCollapseOptions
    {
        /// <summary>
        /// And ElementReference or CSS selector string. If parent is provided, then all collapsible elements under the specified parent will be closed when this collapsible item is shown. (similar to traditional accordion behavior - this is dependent on the card class). The attribute has to be set on the target collapsible area.
        /// </summary>
        public object Parent { get; set; }

        /// <summary>
        /// Toggles the collapsible element on invocation
        /// </summary>
        public bool? Toggle { get; set; }

    }
}
