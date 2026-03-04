# User Stories — High Fiber Diet App

The following user stories are derived from [`requirements.md`](requirements.md) and are intended to be created as GitHub Issues.

---

## US-001 · Set up .NET Core web application project

**As a** developer,  
**I want** a scaffolded .NET Core web application,  
**So that** I have a solid foundation to build the High Fiber Diet app on.

### Acceptance Criteria

- [ ] A new .NET Core MVC or Razor Pages web application is created in the repository.
- [ ] The project builds and runs locally (`dotnet run`) without errors.
- [ ] A home/landing page is accessible at the root URL.
- [ ] The project is committed and the CI build passes.

### Technical Notes

- Use .NET Core (latest LTS) only — no JavaScript frameworks.
- Simple HTML output; CSS may be used for layout.

---

## US-002 · Create the Food data model

**As a** developer,  
**I want** a strongly-typed `Food` model class,  
**So that** each food item's details can be stored, retrieved, and rendered consistently.

### Acceptance Criteria

- [ ] A `Food` model class is created with at minimum:
  - `Id` (int or Guid)
  - `Name` (string, required)
  - `FiberAmountGrams` (decimal, required)
  - `Description` (string, optional)
  - `ImageFileName` (string — filename of the food image in `wwwroot/images/`)
- [ ] The model is placed in an appropriate namespace/folder.

### Technical Notes

- No JavaScript; server-side model only.

---

## US-003 · Seed the application with high-fiber food data

**As a** content author,  
**I want** a set of pre-loaded high-fiber foods in the application,  
**So that** the app is useful immediately without requiring manual data entry.

### Acceptance Criteria

- [ ] At least 10 high-fiber foods are seeded (e.g., lentils, chickpeas, black beans, avocado, oats, chia seeds, broccoli, pears, almonds, quinoa).
- [ ] Each food record includes a name, fiber amount (grams per 100 g), short description, and an image filename.
- [ ] Food images (`.jpg` or `.png`) are stored under `wwwroot/images/foods/`.

### Technical Notes

- Seed data may be hardcoded in an in-memory list, a JSON file, or EF Core seed data — whichever fits the chosen data layer.

---

## US-004 · Display a list of all foods with fiber amounts and images

**As a** user,  
**I want** to see a collection of foods with their fiber amounts and images on the main page,  
**So that** I can quickly browse which foods are high in fiber.

### Acceptance Criteria

- [ ] The home/index page renders a list (or grid) of all seeded food items.
- [ ] Each food entry shows:
  - Food name
  - Fiber amount (e.g., "8.5 g per 100 g")
  - A thumbnail image of the food
- [ ] The page is server-rendered HTML with no JavaScript.
- [ ] The layout is clean and readable in a standard browser.

### Technical Notes

- Use Razor (`.cshtml`) or Razor Pages.
- Images must come from `wwwroot/images/foods/`.

---

## US-005 · Display a food detail page

**As a** user,  
**I want** to click on a food item and see its full details,  
**So that** I can learn more about the food and its nutritional value.

### Acceptance Criteria

- [ ] Each food on the list page links to a detail page (e.g., `/foods/{id}`).
- [ ] The detail page shows:
  - Full food name
  - Larger image of the food
  - Fiber amount
  - Description / nutritional notes
- [ ] Navigating back to the list page works via an HTML link.
- [ ] The page is server-rendered with no JavaScript.

---

## US-006 · Add server-side search / filter for foods

**As a** user,  
**I want** to search or filter the food list by name,  
**So that** I can quickly find a specific food without scrolling through the entire list.

### Acceptance Criteria

- [ ] A search form (HTML `<form method="get">`) is present on the food list page.
- [ ] Submitting the form filters the displayed foods to those whose name contains the search term (case-insensitive).
- [ ] If the search term is empty, all foods are shown.
- [ ] No JavaScript is used — filtering is handled entirely on the server.

---

## US-007 · Add basic HTML/CSS styling

**As a** user,  
**I want** the app to have a clean and consistent visual style,  
**So that** it is pleasant to use and easy to read.

### Acceptance Criteria

- [ ] A shared layout (`_Layout.cshtml` or equivalent) provides consistent navigation and a page wrapper.
- [ ] A site-level CSS file (`wwwroot/css/site.css`) styles:
  - Page header / navigation bar
  - Food card/grid layout on the list page
  - Readable typography
- [ ] No inline JavaScript or JavaScript files are included.
- [ ] The design is functional and legible on desktop browser widths.

---

## US-008 · Add food images to the application

**As a** user,  
**I want** to see a representative image alongside each food item,  
**So that** I can visually identify the food quickly.

### Acceptance Criteria

- [ ] Each food in the seed data has a corresponding image file in `wwwroot/images/foods/`.
- [ ] Images are displayed on both the food list page (thumbnail) and the food detail page (larger view).
- [ ] If an image file is missing, the UI shows a meaningful fallback (e.g., placeholder text or a default image).
- [ ] Images are optimized for web (reasonable file size).

---
