using System;
using Microsoft.JSInterop;

namespace BlazorWerks.Bootstrap
{
    public class BsCarousel : BsComponent
    {
        internal BsCarousel(object target, object options = null, IJSRuntime jsr = null) : base("Carousel", target, options, jsr)
        {
        }
        
        public BsCarousel Cycle()
        { return Invoke<BsCarousel>("cycle"); }

        public BsCarousel Next()
        { return Invoke<BsCarousel>("next"); }

        public BsCarousel Pause()
        { return Invoke<BsCarousel>("pause"); }

        public BsCarousel Prev()
        { return Invoke<BsCarousel>("prev"); }

        public BsCarousel To(object slideNumber)
        { return Invoke<BsCarousel>("to", Convert.ToInt32(slideNumber)); }

    }
}