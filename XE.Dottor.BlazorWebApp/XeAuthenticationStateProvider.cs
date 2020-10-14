namespace XE.Dottor.BlazorWebApp
{
    using Microsoft.AspNetCore.Components.Authorization;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;

    /// <summary>
    /// Permette di simulare il processo di autenticazione senza doversi appoggiare
    /// a provider esterni.
    /// Ritorna sempre lo stesso utente, con gli stessi claims definiti qui sotto
    /// DA NON UTILIZZARE IN PRODUZIONE :)
    /// </summary>
    public class XeAuthenticationStateProvider : AuthenticationStateProvider
    {
        public static bool IsAuthenticated { get; set; }
        public static bool IsAuthenticating { get; set; }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            ClaimsIdentity identity;

            if (IsAuthenticating)
            {
                return null;
            }
            else if (IsAuthenticated)
            {
                identity = new ClaimsIdentity(new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, "XE-User"),      // userName
                            new Claim(ClaimTypes.NameIdentifier, "1")   // userId
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
