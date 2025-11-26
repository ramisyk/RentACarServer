using RentACarServer.Domain.Abstractions;
using RentACarServer.Domain.LoginTokens.ValueObjects;

namespace RentACarServer.Domain.LoginTokens;

public sealed class LoginToken
{
    private LoginToken() { }
    public LoginToken(Token token, IdentityId userId, ExpiresDate expiresDate)
    {
        Id = new IdentityId(Guid.CreateVersion7());
        SetToken(token);
        SetUserId(userId);
        SetIsActive(new(true));
        SetExpiresDate(expiresDate);
    }

    public IdentityId Id { get; private set; }
    public IsActive IsActive { get; private set; }
    public Token Token { get; private set; }
    public IdentityId UserId { get; private set; }
    public ExpiresDate ExpiresDate { get; private set; }

    #region Behaviors
    public void SetIsActive(IsActive isActive)
    {
        IsActive = isActive;
    }

    public void SetToken(Token token)
    {
        Token = token;
    }

    public void SetUserId(IdentityId userId)
    {
        UserId = userId;
    }

    public void SetExpiresDate(ExpiresDate expiresDate)
    {
        ExpiresDate = expiresDate;
    }

    #endregion
}