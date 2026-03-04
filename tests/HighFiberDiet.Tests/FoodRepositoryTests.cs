using HighFiberDiet.Data;

namespace HighFiberDiet.Tests;

public class FoodRepositoryTests
{
    private readonly FoodRepository _repository;

    public FoodRepositoryTests()
    {
        _repository = new FoodRepository();
    }

    [Fact]
    public void GetAll_WithNoSearch_ReturnsAllFoods()
    {
        var foods = _repository.GetAll();

        Assert.NotNull(foods);
        Assert.True(foods.Count() >= 10);
    }

    [Fact]
    public void GetAll_WithNullSearch_ReturnsAllFoods()
    {
        var allFoods = _repository.GetAll(null);
        var emptySearch = _repository.GetAll(string.Empty);

        Assert.Equal(allFoods.Count(), emptySearch.Count());
    }

    [Fact]
    public void GetAll_WithMatchingSearch_ReturnsFilteredFoods()
    {
        var foods = _repository.GetAll("lentil");

        Assert.NotNull(foods);
        Assert.Single(foods);
        Assert.Equal("Lentils", foods.First().Name);
    }

    [Fact]
    public void GetAll_WithCaseInsensitiveSearch_ReturnsFilteredFoods()
    {
        var lower = _repository.GetAll("oats");
        var upper = _repository.GetAll("OATS");
        var mixed = _repository.GetAll("Oats");

        Assert.Equal(lower.Count(), upper.Count());
        Assert.Equal(lower.Count(), mixed.Count());
        Assert.Single(lower);
    }

    [Fact]
    public void GetAll_WithNonMatchingSearch_ReturnsEmptyCollection()
    {
        var foods = _repository.GetAll("zzznomatch");

        Assert.NotNull(foods);
        Assert.Empty(foods);
    }

    [Fact]
    public void GetById_WithValidId_ReturnsFood()
    {
        var food = _repository.GetById(1);

        Assert.NotNull(food);
        Assert.Equal(1, food.Id);
        Assert.Equal("Lentils", food.Name);
    }

    [Fact]
    public void GetById_WithInvalidId_ReturnsNull()
    {
        var food = _repository.GetById(9999);

        Assert.Null(food);
    }

    [Fact]
    public void AllFoods_HaveRequiredProperties()
    {
        var foods = _repository.GetAll();

        foreach (var food in foods)
        {
            Assert.True(food.Id > 0);
            Assert.False(string.IsNullOrWhiteSpace(food.Name));
            Assert.True(food.FiberAmountGrams > 0);
            Assert.False(string.IsNullOrWhiteSpace(food.ImageFileName));
        }
    }
}
