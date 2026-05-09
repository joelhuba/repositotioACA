using TokerBackend.Infrastructure.Helpers;

namespace MsrBack.Tests;

public class PasswordHashHelperTests
{
    [Fact]
    public void HashPassword_WithValidPassword_ReturnsHashAndSalt()
    {
        const string password = "Admin123*";

        var (hash, salt) = PasswordHashHelper.HashPassword(password);

        Assert.False(string.IsNullOrWhiteSpace(hash));
        Assert.False(string.IsNullOrWhiteSpace(salt));
        Assert.NotEqual(password, hash);
        Assert.NotEmpty(Convert.FromBase64String(hash));
        Assert.NotEmpty(Convert.FromBase64String(salt));
    }

    [Fact]
    public void VerifyPassword_WithOriginalPassword_ReturnsTrue()
    {
        const string password = "Admin123*";
        var (hash, salt) = PasswordHashHelper.HashPassword(password);
        var saltBytes = Convert.FromBase64String(salt);

        var isValid = PasswordHashHelper.VerifyPassword(password, hash, saltBytes);

        Assert.True(isValid);
    }

    [Fact]
    public void VerifyPassword_WithDifferentPassword_ReturnsFalse()
    {
        const string originalPassword = "Admin123*";
        const string wrongPassword = "Admin12345*";
        var (hash, salt) = PasswordHashHelper.HashPassword(originalPassword);
        var saltBytes = Convert.FromBase64String(salt);

        var isValid = PasswordHashHelper.VerifyPassword(wrongPassword, hash, saltBytes);

        Assert.False(isValid);
    }
}
