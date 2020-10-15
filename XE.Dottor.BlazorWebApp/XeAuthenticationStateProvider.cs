namespace XE.Dottor.BlazorWebApp
{
    using Microsoft.AspNetCore.Components.Authorization;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using System.Xml.Linq;
    using XE.Dottor.BlazorWebApp.Models;

    /// <summary>
    /// Permette di simulare il processo di autenticazione senza doversi appoggiare
    /// a provider esterni.
    /// Ritorna sempre lo stesso utente, con gli stessi claims definiti qui sotto
    /// DA NON UTILIZZARE IN PRODUZIONE :)
    /// </summary>
    public class XeAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly StateContainer _stateContainer;

        public XeAuthenticationStateProvider(StateContainer stateContainer) => _stateContainer = stateContainer;

        public static bool IsAuthenticated { get; set; }
        public static bool IsAuthenticating { get; set; }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            // https://chrissainty.com/securing-your-blazor-apps-authentication-with-clientside-blazor-using-webapi-aspnet-core-identity/
            ClaimsIdentity identity;

            if (IsAuthenticating)
            {
                return null;
            }
            else if (IsAuthenticated)
            {
                var user = _stateContainer.CurrentUser;

                identity = new ClaimsIdentity(new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, user.Name),      // userName
                            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())   // userId
                        }, "XeAuth");
            }
            else
            {
                identity = new ClaimsIdentity();
            }

            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity)));
        }

        public void NotifyAuthenticationStateChanged()
        {
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
    }
}
