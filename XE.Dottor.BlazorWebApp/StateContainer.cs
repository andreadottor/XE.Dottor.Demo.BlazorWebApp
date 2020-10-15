namespace XE.Dottor.BlazorWebApp
{
    using System.Collections.Generic;
    using System.Linq;
    using XE.Dottor.BlazorWebApp.Models;

    /// <summary>
    /// Classe che permette di mantenere lo stato dell'applicazione
    /// utile per il passaggio di parametri tra pagine.
    /// </summary>
    public class StateContainer
    {

        public IEnumerable<PostViewModel> Posts { get; set; } = Enumerable.Empty<PostViewModel>();

        public UserDto CurrentUser { get; set; }
    }
    
}
