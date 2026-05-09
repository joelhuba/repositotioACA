using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.Extensions.Logging.Abstractions;
using MsrBack.Core.DTOs.Commons;
using TokerBackend.Infrastructure.Helpers;

namespace MsrBack.Tests;

public class GenerateTokenHelperTests
{
    [Fact]
    public async Task GenerateTokenAsync_WithValidUser_ReturnsJwtWithExpectedClaims()
    {
        var user = new AuthUserDTO
        {
            IdUser = 7,
            Email = "qa@adstra.local",
            Name = "QA",
            LastName = "Tester",
            IdCompany = 12,
            IsSystemAdmin = false,
            IsActive = true,
            Role = new List<string> { "Administrador" },
            IdRoles = new List<int> { 3 },
            IdCompanyBranches = new List<int> { 4 },
            CompanyBranchesName = new List<string> { "Sede Principal" }
        };

        const string secret = "clave-super-secreta-para-pruebas-unitarias-2026";

        var token = await GenerateTokenHelper.GenerateTokenAsync(
            user,
            secret,
            hours: 1,
            NullLogger.Instance,
            idCompany: "12"
        );

        var jwt = new JwtSecurityTokenHandler().ReadJwtToken(token);

        Assert.False(string.IsNullOrWhiteSpace(token));
        Assert.Contains(jwt.Claims, claim => claim.Type == "Email" && claim.Value == "qa@adstra.local");
        Assert.Contains(jwt.Claims, claim => claim.Type == "IdUser" && claim.Value == "7");
        Assert.Contains(jwt.Claims, claim => claim.Type == "IdCompany" && claim.Value == "12");
        Assert.Contains(jwt.Claims, claim =>
            (claim.Type == ClaimTypes.Role || claim.Type == "role")
            && claim.Value == "Administrador");
        Assert.True(jwt.ValidTo > DateTime.UtcNow);
    }
}
