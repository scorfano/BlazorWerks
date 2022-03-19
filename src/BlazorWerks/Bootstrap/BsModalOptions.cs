using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorWerks.Bootstrap
{
    public class BsModalOptions
    {
        /// <summary>
        /// boolean or the string 'static'	true  Includes a modal-backdrop element. Alternatively, specify static for a backdrop which doesn't close the modal on click.
        /// </summary>
        public bool? Backdrop { get; set; }

        /// <summary>
        /// Closes the modal when escape key is pressed
        /// </summary>
        public bool? Keyboard { get; set; }

        /// <summary>
        /// Puts the focus on the modal when initialized.
        /// </summary>
        public bool? Focus { get; set; }

    }
}
