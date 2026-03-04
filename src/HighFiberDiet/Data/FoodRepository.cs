using HighFiberDiet.Models;

namespace HighFiberDiet.Data;

public class FoodRepository
{
    private static readonly List<Food> _foods =
    [
        new Food
        {
            Id = 1,
            Name = "Lentils",
            FiberAmountGrams = 7.9m,
            Description = "Lentils are edible legumes packed with protein and fiber. They are a staple food in many cultures and are excellent for digestive health.",
            ImageFileName = "lentils.png"
        },
        new Food
        {
            Id = 2,
            Name = "Chickpeas",
            FiberAmountGrams = 7.6m,
            Description = "Also known as garbanzo beans, chickpeas are a versatile legume rich in fiber, protein, and essential minerals.",
            ImageFileName = "chickpeas.png"
        },
        new Food
        {
            Id = 3,
            Name = "Black Beans",
            FiberAmountGrams = 8.7m,
            Description = "Black beans are a nutrient-dense legume that provides a substantial amount of fiber per serving, supporting gut health.",
            ImageFileName = "black-beans.png"
        },
        new Food
        {
            Id = 4,
            Name = "Avocado",
            FiberAmountGrams = 6.7m,
            Description = "Avocado is a unique fruit high in healthy monounsaturated fats and dietary fiber, making it great for heart health.",
            ImageFileName = "avocado.png"
        },
        new Food
        {
            Id = 5,
            Name = "Oats",
            FiberAmountGrams = 10.6m,
            Description = "Oats are a whole grain cereal rich in beta-glucan, a soluble fiber known to help reduce cholesterol levels.",
            ImageFileName = "oats.png"
        },
        new Food
        {
            Id = 6,
            Name = "Chia Seeds",
            FiberAmountGrams = 34.4m,
            Description = "Chia seeds are one of the most fiber-rich foods available. They absorb water and form a gel-like substance that aids digestion.",
            ImageFileName = "chia-seeds.png"
        },
        new Food
        {
            Id = 7,
            Name = "Broccoli",
            FiberAmountGrams = 2.6m,
            Description = "Broccoli is a cruciferous vegetable rich in fiber, vitamins C and K, and various antioxidants that support overall health.",
            ImageFileName = "broccoli.png"
        },
        new Food
        {
            Id = 8,
            Name = "Pears",
            FiberAmountGrams = 3.1m,
            Description = "Pears are a sweet and juicy fruit with a good amount of dietary fiber, especially when eaten with the skin.",
            ImageFileName = "pears.png"
        },
        new Food
        {
            Id = 9,
            Name = "Almonds",
            FiberAmountGrams = 12.5m,
            Description = "Almonds are tree nuts high in fiber, healthy fats, vitamin E, and magnesium. They make a great high-fiber snack.",
            ImageFileName = "almonds.png"
        },
        new Food
        {
            Id = 10,
            Name = "Quinoa",
            FiberAmountGrams = 2.8m,
            Description = "Quinoa is a whole grain that is also a complete protein. It contains all essential amino acids alongside a decent fiber content.",
            ImageFileName = "quinoa.png"
        },
        new Food
        {
            Id = 11,
            Name = "Split Peas",
            FiberAmountGrams = 8.3m,
            Description = "Split peas are dried, hulled peas that are very high in fiber and protein, often used in soups and stews.",
            ImageFileName = "split-peas.png"
        },
        new Food
        {
            Id = 12,
            Name = "Brussels Sprouts",
            FiberAmountGrams = 3.8m,
            Description = "Brussels sprouts are cruciferous vegetables loaded with fiber, vitamins K and C, and beneficial plant compounds.",
            ImageFileName = "brussels-sprouts.png"
        }
    ];

    public IEnumerable<Food> GetAll(string? search = null)
    {
        if (string.IsNullOrWhiteSpace(search))
        {
            return _foods;
        }

        return _foods.Where(f => f.Name.Contains(search, StringComparison.OrdinalIgnoreCase));
    }

    public Food? GetById(int id)
    {
        return _foods.FirstOrDefault(f => f.Id == id);
    }
}
