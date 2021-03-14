namespace XE.Dottor.BlazorWebApp.Services
{
    using Microsoft.JSInterop;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using XE.Dottor.ApplicationCore.Models;

    public class JsFunctionService
    {
        private readonly IJSRuntime _jsRuntime;

        public JsFunctionService(IJSRuntime jsRuntime) 
            => _jsRuntime = jsRuntime;

        /// <summary>
        /// Leggo le informazioni che mi vengono ritornate dalla funzione javascript readINFOS
        /// </summary>
        public async Task<Dictionary<int, PostExtDto>> ReadInfo(string userName) 
                => await _jsRuntime.InvokeAsync<Dictionary<int, PostExtDto>>("readINFOS", userName);

        /// <summary>
        /// Salvo le informazioni utilizzando la funzione javascript saveINFOS
        /// </summary>
        public async Task SaveInfo(string userName, Dictionary<int, PostExtDto> data)
                => await _jsRuntime.InvokeVoidAsync("saveINFOS", data, userName);

        /// <summary>
        /// Chiamo la funzione javascript getGravatar che mi ritorna l'url da utilizzare 
        /// per visualizzare l'immagine Gravatar
        /// </summary>
        public async Task<string> GetGravatarUrl(string email)
                => await _jsRuntime.InvokeAsync<string>("getGravatar", email, 100);

    }
}
