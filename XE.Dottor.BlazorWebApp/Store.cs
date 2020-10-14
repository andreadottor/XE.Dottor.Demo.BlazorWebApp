namespace XE.Dottor.BlazorWebApp
{
    using System.Collections.Generic;
    using System.Linq;
    using XE.Dottor.BlazorWebApp.Models;

    /// <summary>
    /// Classe che permette di mantenere lo stato dell'applicazione
    /// utile per il passaggio di parametri tra pagine.
    /// </summary>
    public class Store
    {

        public Store()
        {
            Posts = Enumerable.Empty<PostViewModel>();
        }

        public IEnumerable<PostViewModel> Posts { get; set; }
    }
    
}
