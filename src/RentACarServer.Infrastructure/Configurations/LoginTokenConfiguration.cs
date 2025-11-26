using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACarServer.Domain.LoginTokens;

namespace RentACarServer.Infrastructure.Configurations;

internal sealed class LoginTokenConfiguration : IEntityTypeConfiguration<LoginToken>
{
    public void Configure(EntityTypeBuilder<LoginToken> builder)
    {
        builder.HasKey(x => x.Id);
        builder.OwnsOne(p => p.Token);
        builder.OwnsOne(p => p.IsActive);
        builder.OwnsOne(p => p.ExpiresDate);
    }
}