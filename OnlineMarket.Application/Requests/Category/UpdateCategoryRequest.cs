namespace OnlineMarket.Application.Requests.Category;

public sealed record UpdateCategoryRequest(
    int Id, string Name, string? Description)
    : CreateCategoryRequest(Name: Name, Description: Description);
