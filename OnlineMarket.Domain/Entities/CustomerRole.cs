using Microsoft.AspNetCore.Identity;

namespace OnlineMarket.Domain.Entities;

public class CustomerRole : IdentityRole
{
    public string? Description { get; set; }
}
