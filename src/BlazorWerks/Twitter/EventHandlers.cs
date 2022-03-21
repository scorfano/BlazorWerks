using Microsoft.AspNetCore.Components;
using System;


// see: https://docs.microsoft.com/en-us/aspnet/core/blazor/components/event-handling?view=aspnetcore-6.0

namespace BlazorWerks.Twitter
{   
    [EventHandler("onbootstrap", typeof(BootstrapEventArgs), true, true)]

    public static class EventHandlers
    {

        // public static event EventHandler<BootstrapEventArgs> BootstrapEvent;
        
        // do not rename class as must be "EventHandlers" to append events to global list
    }
}
