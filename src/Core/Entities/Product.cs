namespace Core.Entities;

public class Product : BaseEntity
{
    public required string Name { get; init; }
    public required string Description { get; init; }
    public decimal Price { get; init; }
    public required string PictureUrl { get; init; }
    public required string Type { get; init; }
    public required string Brand { get; init; }
    public int QuantityInStock { get; init; }
}