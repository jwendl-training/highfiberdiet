namespace HighFiberDiet.Models;

public class Food
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public decimal FiberAmountGrams { get; set; }
    public string? Description { get; set; }
    public required string ImageFileName { get; set; }
    public string? ImageUrl { get; set; }
}
