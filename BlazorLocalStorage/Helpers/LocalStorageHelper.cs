using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorLocalStorage.Helpers
{
    public class LocalStorageHelper : ILocalStorageHelper
    {
        private readonly IJSRuntime _javaScript;

        public LocalStorageHelper(IJSRuntime javaScript)
        {
            _javaScript = javaScript;   
        }

        public async Task SetItem(string key, string value)
        {
            await _javaScript.InvokeAsync<string>("LocalStorageActions.setItem", key, value);
        }

        public async Task<string> GetItem(string key)
        {
            return await _javaScript.InvokeAsync<string>("LocalStorageActions.getItem", key);
        }

        public async Task RemoveItem(string key)
        {
            await _javaScript.InvokeAsync<string>("LocalStorageActions.removeItem", key);
        }

        public async Task ClearData()
        {
            await _javaScript.InvokeAsync<string>("LocalStorageActions.clearData");
        }
    }
}
