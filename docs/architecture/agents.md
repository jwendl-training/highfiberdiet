# Agent Configuration

This file is referenced by [`copilot.yaml`](../../copilot.yaml) and provides guidance to GitHub Copilot Coding Agents working in this repository.

## Project Context

This is a **High Fiber Diet** web application built with ASP.NET Core. It displays a curated collection of high-fiber foods with images and nutritional information. The app is intentionally simple: server-rendered Razor views, no JavaScript, and an in-memory data store.

## Key Directories

| Path                         | Purpose                                              |
|------------------------------|------------------------------------------------------|
| `src/HighFiberDiet/`         | Main ASP.NET Core project                            |
| `src/HighFiberDiet/Controllers/` | MVC Controllers (`FoodsController`, `HomeController`) |
| `src/HighFiberDiet/Models/`  | Data models (`Food`)                                 |
| `src/HighFiberDiet/Views/`   | Razor views (`.cshtml`)                              |
| `src/HighFiberDiet/Data/`    | Seed data / repository                               |
| `src/HighFiberDiet/wwwroot/` | Static assets (CSS, food images)                     |
| `docs/architecture/`         | Architecture documentation and diagrams              |

## Coding Guidelines

- Use **ASP.NET Core MVC** (not Blazor, not Minimal API).
- All pages must be server-rendered using **Razor** (`.cshtml`). No `<script>` tags, no JavaScript files.
- Use **CSS only** for styling; no CSS frameworks (e.g. Bootstrap is optional but keep JS-free).
- Food images go in `wwwroot/images/foods/` and are referenced via `~/images/foods/<filename>`.
- The `Food` model must have at minimum: `Id`, `Name`, `FiberAmountGrams`, `Description`, `ImageFileName`.
- Seed at least 10 foods in `Data/FoodRepository.cs` (or equivalent).
- Search/filter must use `<form method="get">` and be handled by the controller action — not JavaScript.

## Architecture Documents

- [`architecture.md`](architecture.md) — Component overview and diagrams
- [`requirements.md`](requirements.md) — Functional and non-functional requirements
- [`data-model.png`](data-model.png) — Entity relationship diagram
- [`application-architecture.png`](application-architecture.png) — Application component diagram
- [`request-flow.png`](request-flow.png) — Request/response sequence diagram
- [`user-journey.png`](user-journey.png) — User journey flowchart
