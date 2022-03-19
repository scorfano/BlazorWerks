using System.Threading.Tasks;

namespace BlazorWerks.WebStorage
{
    public interface ILocalStorage 
    {
        public ValueTask<string> KeyAsync(int index);
        public ValueTask<int> LengthAsync();
        public ValueTask<string[]> KeysAsync( );
        public ValueTask Clear();
        public ValueTask RemoveItem(string key);
        public ValueTask<T> GetItemAsync<T>(string key, T defaultValue = default(T)); 
        public ValueTask SetItem(string key, object value);
    }
}
