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
        },
        new Food
        {
            Id = 13,
            Name = "Kidney Beans",
            FiberAmountGrams = 6.4m,
            Description = "Kidney beans are large, red legumes named for their distinctive shape. They are rich in fiber, protein, and folate, and are a popular ingredient in chili and stews.",
            ImageFileName = "kidney-beans.png"
        },
        new Food
        {
            Id = 14,
            Name = "Navy Beans",
            FiberAmountGrams = 10.5m,
            Description = "Navy beans, also called haricot beans, are small white legumes that are an excellent source of dietary fiber and protein, commonly used in baked beans.",
            ImageFileName = "navy-beans.png"
        },
        new Food
        {
            Id = 15,
            Name = "Edamame",
            FiberAmountGrams = 5.2m,
            Description = "Edamame are young, green soybeans harvested before they ripen. They are high in fiber, plant-based protein, and various vitamins and minerals.",
            ImageFileName = "edamame.png"
        },
        new Food
        {
            Id = 16,
            Name = "Sweet Potato",
            FiberAmountGrams = 3.0m,
            Description = "Sweet potatoes are root vegetables rich in fiber, beta-carotene, vitamins C and B6, and potassium. Eating the skin further boosts fiber content.",
            ImageFileName = "sweet-potato.png"
        },
        new Food
        {
            Id = 17,
            Name = "Artichoke",
            FiberAmountGrams = 8.6m,
            Description = "Artichokes are one of the highest-fiber vegetables available. They are also rich in antioxidants, folate, and vitamin K, and support liver health.",
            ImageFileName = "artichoke.png"
        },
        new Food
        {
            Id = 18,
            Name = "Raspberries",
            FiberAmountGrams = 6.5m,
            Description = "Raspberries are a delicious berry packed with dietary fiber, vitamin C, and powerful antioxidants that help combat inflammation.",
            ImageFileName = "raspberries.png"
        },
        new Food
        {
            Id = 19,
            Name = "Flaxseeds",
            FiberAmountGrams = 27.3m,
            Description = "Flaxseeds are tiny seeds loaded with omega-3 fatty acids, lignans, and a high amount of both soluble and insoluble fiber.",
            ImageFileName = "flaxseeds.png"
        },
        new Food
        {
            Id = 20,
            Name = "Sunflower Seeds",
            FiberAmountGrams = 8.6m,
            Description = "Sunflower seeds are a nutritious snack high in fiber, vitamin E, magnesium, and healthy fats that support cardiovascular health.",
            ImageFileName = "sunflower-seeds.png"
        },
        new Food
        {
            Id = 21,
            Name = "Brown Rice",
            FiberAmountGrams = 3.5m,
            Description = "Brown rice is a whole grain that retains its bran and germ layers, providing more fiber, vitamins, and minerals than refined white rice.",
            ImageFileName = "brown-rice.png"
        },
        new Food
        {
            Id = 22,
            Name = "Kale",
            FiberAmountGrams = 3.6m,
            Description = "Kale is a leafy green superfood packed with fiber, vitamins A, C, and K, calcium, and powerful antioxidants that support bone and eye health.",
            ImageFileName = "kale.png"
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
