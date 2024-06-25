
namespace BlazorLocalStorage.Helpers
{
    public interface ILocalStorageHelper
    {
        Task ClearData();
        Task<string> GetItem(string key);
        Task RemoveItem(string key);
        Task SetItem(string key, string value);
    }
}