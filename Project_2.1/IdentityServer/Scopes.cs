using System.Collections.Generic;
using IdentityServer3.Core.Models;

namespace Project_2._1.IdentityServer
{
    public static class Scopes
    {
        public static IEnumerable<Scope> Get()
        {
            return new List<Scope> {
            StandardScopes.OpenId,
            StandardScopes.Profile,
            StandardScopes.Email,
            StandardScopes.Roles,
            StandardScopes.OfflineAccess
        };
        }
    }
}