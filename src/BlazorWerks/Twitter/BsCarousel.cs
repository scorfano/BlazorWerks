using System;
using Microsoft.JSInterop;

namespace BlazorWerks.Twitter
{
    public class BsCarousel : BsComponent
    {
        internal BsCarousel(object target, IJSRuntime jsr = null) : base("Carousel", target, jsr)
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

        public BsCarousel To(string slideNumber)
        { return Invoke<BsCarousel>("to", Convert.ToInt32(slideNumber)); }

        public BsCarousel To(int slideNumber)
        { return Invoke<BsCarousel>("to", slideNumber); }

    }
}