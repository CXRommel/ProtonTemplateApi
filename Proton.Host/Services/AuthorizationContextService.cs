using System.Security.Claims;

namespace Proton.Host.Services;

public class AuthorizationContextService(HttpContext context)
{
    public readonly ClaimsPrincipal User = context.User;
}