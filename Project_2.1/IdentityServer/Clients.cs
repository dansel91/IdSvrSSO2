using System.Collections.Generic;
using IdentityServer3.Core;
using IdentityServer3.Core.Models;

namespace Project_2._1.IdentityServer
{
    public static class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    //The ClientId is the unique ID of the client. This will be referenced by any future client applications in order to interact with the Identity Server.
                    ClientId = "hybridclient02",
                    //ClientName will be the identifier displayed on any consent screens.
                    ClientName = "Example Hybrid Client 02",
                    //Enabled allows you to enable and disable individual clients.
                    Enabled = true,
                    //Flow is an enum that sets the OpenID Connect flow for the client.Available flows are: Implicit, AuthorizationCode, Hybrid, ClientCredentials, ResourceOwner and Custom (default is Implicit).
                    Flow = Flows.Hybrid,
                    //RequireConsent and AllowRememberConsent activate and control the consent screen for logins.These both default to true
                    RequireConsent = true,
                    //RedirectUris is a collection of URIs that tokens and authorisation codes can be returned to for this client.If a URI is not on this list, then it cannot interact with Identity Server using this client.
                    AllowRememberConsent = true,
                    //PostLogoutRedirectUris is a collection of URIs that Identity Server can redirect to upon logout. Otherwise the user will stay on the default logout success screen within the Identity Server.
                    RedirectUris =
                        new List<string> {"http://localhost:24624/"},
                    //ScopeRestrictions is a list of OpenID Connect scopes allowed to be requested and returned to this client.We can take advantage of the predefined enums provided by Identity Server here.Not setting this allows all scopes to be retrieved (defaults to an empty list).
                    PostLogoutRedirectUris =
                        new List<string> {"http://localhost:24624/"},
                    AllowedScopes = new List<string>
                    {
                        Constants.StandardScopes.OpenId,
                        Constants.StandardScopes.Profile,
                        Constants.StandardScopes.Roles,
                        Constants.StandardScopes.Email
                    },
                    //AccessTokenType defaults to JWT. The other option for this is Reference, which stores the JWT locally and instead sends the client a reference to it, allowing you to easily revoke the token.
                    AccessTokenType = AccessTokenType.Jwt
                },
                new Client
                {
                    ClientId = "hybridclient01",
                    ClientName = "Example Hybrid Client 01",
                    //ClientSecrets = new List<Secret>
                    //{
                    //    new Secret("idsrv3test".Sha256())
                    //},
                    Enabled = true,
                    Flow = Flows.Hybrid,
                    RequireConsent = true,
                    AllowRememberConsent = true,
                    RedirectUris = new List<string>
                    {
                        "http://localhost:5496/"
                    },
                    PostLogoutRedirectUris = new List<string>
                    {
                        "http://localhost:5496/"
                    },
                    AllowedScopes = new List<string>
                    {
                        Constants.StandardScopes.OpenId,
                        Constants.StandardScopes.Profile,
                        Constants.StandardScopes.Email,
                        Constants.StandardScopes.Roles,
                        Constants.StandardScopes.OfflineAccess
                    },
                    AccessTokenType = AccessTokenType.Jwt
                }
            };
        }
    }
}