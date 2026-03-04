# Architecture Requirements

This document captures the architectural requirements derived from [`../requirements.md`](../requirements.md) and the user stories in [`../user-stories.md`](../user-stories.md).

## Technology Constraints

- **Runtime**: .NET Core (latest LTS)
- **Frontend**: Server-rendered HTML using Razor Pages or MVC views — no JavaScript
- **Styling**: Plain CSS (`wwwroot/css/site.css`)
- **Data Layer**: In-memory collection or EF Core with SQLite (no external database required)
- **Images**: Static files served from `wwwroot/images/foods/`

## Functional Requirements

| ID    | Requirement                                                                                 |
|-------|---------------------------------------------------------------------------------------------|
| FR-01 | Display a list of all high-fiber foods with name, fiber amount, and thumbnail image.        |
| FR-02 | Each food entry links to a detail page showing full name, larger image, fiber amount, and description. |
| FR-03 | A server-side search form on the food list page filters foods by name (case-insensitive).   |
| FR-04 | At least 10 high-fiber foods are pre-seeded with name, fiber amount, description, and image. |
| FR-05 | The app has a shared layout with consistent navigation across pages.                        |
| FR-06 | If a food image is missing, a meaningful fallback is shown.                                 |

## Non-Functional Requirements

| ID     | Requirement                                                                    |
|--------|--------------------------------------------------------------------------------|
| NFR-01 | All pages are server-rendered with no client-side JavaScript.                  |
| NFR-02 | The application must build and run with `dotnet run` without errors.           |
| NFR-03 | The layout must be functional and legible on standard desktop browser widths.  |
| NFR-04 | Food images must be optimized for web (reasonable file size).                  |

## Out of Scope

- User authentication / accounts
- Persistent database (external server)
- JavaScript frameworks or SPA patterns
- Mobile-specific responsive breakpoints (desktop legibility is sufficient)
