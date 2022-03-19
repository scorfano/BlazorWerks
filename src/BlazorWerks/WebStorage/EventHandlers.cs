using Microsoft.AspNetCore.Components;
using System;


// see: https://docs.microsoft.com/en-us/aspnet/core/blazor/components/event-handling?view=aspnetcore-6.0
// see: https://developer.mozilla.org/en-US/docs/Web/API/Window/storage_event
/*
 Note: This won't work on the same page that is making the changes — it is really a way for other pages on 
 the domain using the storage to sync any changes that are made. Pages on other domains can't access the same 
 storage objects.
*/

namespace BlazorWerks.WebStorage
{   
    [EventHandler("onstorage", typeof(StorageEventArgs), true, true)]

    public static class EventHandlers
    {
        // do not rename class as must be "EventHandlers" to append events to global list
    }
}
