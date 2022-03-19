#define NEWTONSOFT
#nullable disable

#if NEWTONSOFT
    using Newtonsoft.Json;
#else
    using System.Text.Json;
    using System.Text.Json.Serialization;
#endif

using Microsoft.JSInterop;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using System;

/// <summary>
/// Newtonsoft is used for serialization as it automatically handles dynamic, anonymous, and polymorphic values.
/// These features are not currently available with System.Text.Json, which usually corrupts or delete such data. This 
/// might change in the future, but for now Newtonsoft provides more consistent and expected results.
/// </summary>

namespace BlazorWerks.WebStorage
{
    public class LocalStorage : ILocalStorage
    {
        // STORAGE = window.localStorage or window.sessionStorage

        protected string STORAGE { get; set; } = "BlazorTools.WebStorage.localStorage";

        protected readonly IJSRuntime jsRuntime;

        public LocalStorage()
        {
        }

        [ActivatorUtilitiesConstructor]
        public LocalStorage(IJSRuntime jsr)
        {
            jsRuntime = jsr;
        }

        /// <summary>
        /// The number of items stored in the Storage object.
        /// </summary>
        /// <returns>int</returns>

        public async ValueTask<int> LengthAsync()
        {
            return await jsRuntime.InvokeAsync<int>(STORAGE + ".length");
        }

        /// <summary>
        /// When passed a number n, this method will return the name of the nth key in the storage.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public async ValueTask<string> KeyAsync(int index)
        {
            return await jsRuntime.InvokeAsync<string>(STORAGE + ".key", index);
        }

        /// <summary>
        /// Returns an array of all key names
        /// </summary>
        /// <returns></returns>
        public async ValueTask<string[]> KeysAsync()
        {
            return await jsRuntime.InvokeAsync<string[]>(STORAGE + ".keys");
        }

        /// <summary>
        /// Clears all items from the storage area
        /// </summary>

        public async ValueTask Clear()
        {
            await jsRuntime.InvokeVoidAsync(STORAGE + ".clear");
        }
        /// <summary>
        /// Removes the key and value from storage.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public async ValueTask RemoveItem(string key)
        {
            await jsRuntime.InvokeVoidAsync(STORAGE + ".removeItem", key);
        }

#if NEWTONSOFT

        // use Newtonsoft json converter

        protected JsonSerializerSettings Settings = new JsonSerializerSettings()
        {
            TypeNameHandling = TypeNameHandling.Auto
        };

        /// <summary>
        /// /Saves a key:value pair to the storage area
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
      
        public async ValueTask SetItem(string key, object value)
        {
            string json = JsonConvert.SerializeObject(value, Settings);
            await jsRuntime.InvokeVoidAsync(STORAGE + ".setItem", key, json);
        }

        /// <summary>
        /// Returns the value for the key from the storage area or DefaultValue when not found 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public async ValueTask<T> GetItemAsync<T>(string key, T defaultValue = default(T))
        {
            var json = await jsRuntime.InvokeAsync<string>(STORAGE + ".getItem", key);
            if (String.IsNullOrWhiteSpace(json)) return defaultValue;
            return JsonConvert.DeserializeObject<T>(json, Settings);
        }

#else
        // Use native json converter

        protected JsonSerializerOptions Settings = new JsonSerializerOptions(JsonSerializerDefaults.Web)
        {
            // tweaks as required
            
        };

        /// <summary>
        /// /Saves a key:value pair to the storage area
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public async ValueTask SetItem(string key, object value)
        {
            string json = JsonSerializer.Serialize(value, Settings);
            await jsRuntime.InvokeVoidAsync(STORAGE + ".setItem", key, json);
        }

        /// <summary>
        /// Returns the value for the key from the storage area or DefaultValue when not found 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public async ValueTask<T> GetItemAsync<T>(string key, T defaultValue = default(T))
        {
            string json = await jsRuntime.InvokeAsync<string>(STORAGE + ".getItem", key);
            if (String.IsNullOrWhiteSpace(json)) return defaultValue;
            return System.Text.Json.JsonSerializer.Deserialize<T>(json, Settings);
        }
#endif 
    }
}
