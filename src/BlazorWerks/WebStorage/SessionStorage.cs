
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlazorWerks.WebStorage
{
    public class SessionStorage : LocalStorage, ISessionStorage
    {
        [ActivatorUtilitiesConstructor]
        public SessionStorage(IJSRuntime jsr) : base(jsr)
        {
            STORAGE = "BlazorWerks.WebStorage.sessionStorage";
        }
    }
}
