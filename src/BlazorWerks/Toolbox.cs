using Microsoft.JSInterop;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorWerks
{
    public class Toolbox
    {
        protected IJSRuntime jsRuntime;


        public Toolbox()
        {

        }

        [ActivatorUtilitiesConstructor]
        public Toolbox(IJSRuntime jsr)
        {
            jsRuntime = jsr;
        }


        // see: https://developer.mozilla.org/en-US/docs/Web/API/Vibration_API

        public async void Vibrate(int milliseconds)
        {
            await jsRuntime.InvokeVoidAsync("window.navigator.vibrate", milliseconds);
        }

        public async void Vibrate(int[] sequence)
        {
            await jsRuntime.InvokeVoidAsync("window.navigator.vibrate", sequence); 
        }


        // Interesting Web API

        // Share
        // https://developer.mozilla.org/en-US/docs/Web/API/Web_Share_API

        // Cache
        // https://developer.mozilla.org/en-US/docs/Web/API/Cache

        // Geolocation
        // https://developer.mozilla.org/en-US/docs/Web/API/Geolocation

        // Speech
        // https://developer.mozilla.org/en-US/docs/Web/API/Web_Speech_API/Using_the_Web_Speech_API

        // Notifications
        // https://developer.mozilla.org/en-US/docs/Web/API/Notifications_API
        // https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events  (used by twitter)
        // https://developer.mozilla.org/en-US/docs/Web/API/Push_API

        // Sensors (limited browser support)
        // https://developer.mozilla.org/en-US/docs/Web/API/Sensor_APIs

        // Clipboard
        // https://developer.mozilla.org/en-US/docs/Web/API/Clipboard_API

        // Console
        // https://developer.mozilla.org/en-US/docs/Web/API/Console_API

        // History
        // https://developer.mozilla.org/en-US/docs/Web/API/History_API





    }
}
