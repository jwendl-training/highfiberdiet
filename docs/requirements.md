# Application Requirements

## Project: High Fiber Diet Tracker

## Purpose

Help users discover, track, and optimize their daily dietary fiber intake through an easy-to-use web application. The app surfaces high-fiber foods, enables daily food logging, supports meal planning, and provides personalized recommendations and progress analytics — all with a focus on promoting a high-fiber diet for improved digestive health.

## Requirements

### User Authentication & Profile Management

- Users can create an account with email and password
- Users can log in and log out securely
- Users can set up a personal profile including:
  - Name, age, weight, and height
  - Dietary preferences and restrictions (e.g., vegetarian, vegan, gluten-free)
  - Daily fiber intake goal (default: 25–38 g/day based on age and gender)
- Users can update or delete their profile at any time
- User data is stored securely and privately

### Food Search & Discovery

- Users can search for foods by name using a search bar
- Search results show food name, serving size, and fiber content per serving
- Users can filter results by:
  - High fiber content (≥ 5 g per serving)
  - Food category (fruits, vegetables, grains, legumes, nuts & seeds)
- Users can view detailed nutritional information for any food, including:
  - Dietary fiber (soluble and insoluble)
  - Calories, protein, fat, carbohydrates
  - Key vitamins and minerals
- Search is fast and responsive (results within 1 second)

### Daily Food Log & Fiber Tracking

- Users can log meals and individual food items for any given day
- The daily log shows:
  - Each food logged, with serving size and fiber contribution
  - Total fiber consumed so far today vs. the user's daily goal
  - Visual progress indicator (e.g., progress bar) toward the fiber goal
- Users can edit or delete logged items
- Users can view their log history for past days

### Fiber Goal Setting

- Users can set a custom daily fiber intake goal
- The app provides a recommended goal based on the user's age and gender (per USDA guidelines)
- Users are notified (in-app) when they reach or exceed their daily fiber goal
- Users can adjust their goal at any time from their profile

### Progress Tracking & Dashboard

- Users see a dashboard summarizing:
  - Fiber intake for today vs. goal
  - Fiber intake trend over the past 7 and 30 days (charts)
  - Average daily fiber intake for the current week and month
  - Streak: number of consecutive days the user has met their goal
- Dashboards are updated in real time as the user logs food

### Meal Planning

- Users can create meal plans for the week, organized by day and meal (breakfast, lunch, dinner, snacks)
- Each meal plan entry shows fiber content per meal and totals per day
- Users can reuse meal plans from previous weeks
- Users can generate a shopping list from a meal plan

### High Fiber Recipe Suggestions

- Users can browse a curated library of high-fiber recipes
- Each recipe shows:
  - Ingredients with fiber content
  - Total fiber per serving
  - Preparation time and difficulty
- Users can filter recipes by category (breakfast, lunch, dinner, snack, dessert)
- Users can save favorite recipes to their profile

### Personalized Food Recommendations

- Users receive personalized high-fiber food recommendations based on:
  - Their food logging history and preferences
  - Foods they have rated highly
  - Seasonal and popular high-fiber foods
- Recommendations are shown on the dashboard and on a dedicated Discover page
- Users can mark recommendations as "not interested" to refine future suggestions

### Analytics & Reporting

- Users can view detailed analytics reports including:
  - Daily, weekly, and monthly fiber intake summaries
  - Top foods contributing to fiber intake
  - Days where fiber goal was met vs. missed
  - Progress trends over time (charts)
- Reports are exportable as PDF or CSV

## Constraints

- Use .NET / Microsoft technology stack
- Azure is the target deployment environment
- Use Blazor Server (hybrid mode) for the frontend and backend services
- Use Azure Functions for background tasks (e.g., generating recommendations, sending notifications)
- Use Azure SQL or Cosmos DB for data persistence
- Nutritional data sourced from the USDA FoodData Central API
- AI-powered recommendations may integrate with Azure OpenAI
- All user data must remain private and comply with applicable data privacy regulations

## User Stories

### US-001: User Authentication & Profile Management

**As a** user,  
**I want to** create an account and manage my profile,  
**So that** my dietary preferences and goals are saved and personalized to me.

**Acceptance Criteria:**
- User can register with email and password
- User can log in and log out
- User can set name, age, weight, height, dietary preferences, and fiber goal
- User can update or delete their profile
- User credentials are stored securely (hashed passwords)

---

### US-002: Food Search & Discovery

**As a** user,  
**I want to** search for foods by name or category,  
**So that** I can discover high-fiber options and understand their nutritional content.

**Acceptance Criteria:**
- Search bar on the main page
- Results show food name, serving size, and fiber content
- Filter by high-fiber (≥5g/serving) and food category
- Results load within 1 second
- Tapping/clicking a food shows full nutritional details

---

### US-003: Food Nutritional Information Display

**As a** user,  
**I want to** view detailed nutritional information for any food,  
**So that** I can make informed dietary choices to increase my fiber intake.

**Acceptance Criteria:**
- Detail page shows dietary fiber (total, soluble, insoluble), calories, protein, fat, carbohydrates
- Shows key vitamins and minerals
- Includes serving size information
- Data sourced from USDA FoodData Central

---

### US-004: Daily Food Log & Fiber Tracking

**As a** user,  
**I want to** log the foods I eat each day,  
**So that** I can track my fiber intake and see how close I am to my daily goal.

**Acceptance Criteria:**
- User can search for and add foods to their daily log
- Log shows each item with serving size and fiber contribution
- Total fiber consumed vs. goal shown with a progress bar
- User can edit serving sizes or remove items
- Past day logs are accessible and editable

---

### US-005: Fiber Goal Setting

**As a** user,  
**I want to** set and update my daily fiber intake goal,  
**So that** I have a personalized target that motivates me to eat more fiber.

**Acceptance Criteria:**
- App suggests a default goal based on age and gender (USDA guidelines)
- User can enter a custom goal
- In-app notification/badge when daily goal is reached
- Goal is editable from the profile page at any time

---

### US-006: Progress Tracking & Dashboard

**As a** user,  
**I want to** see a dashboard with my fiber intake progress,  
**So that** I can stay motivated and understand my dietary habits over time.

**Acceptance Criteria:**
- Dashboard shows today's fiber intake vs. goal
- 7-day and 30-day trend charts
- Average daily intake for current week and month
- Streak counter for consecutive days goal was met
- Dashboard updates in real time when food is logged

---

### US-007: Meal Planning

**As a** user,  
**I want to** create weekly meal plans using high-fiber foods,  
**So that** I can plan ahead and consistently meet my fiber goals.

**Acceptance Criteria:**
- User can create a meal plan organized by day and meal type
- Each meal entry shows fiber content; daily totals are shown
- User can copy a previous week's meal plan
- User can generate a shopping list from a meal plan

---

### US-008: High Fiber Recipe Suggestions

**As a** user,  
**I want to** browse and save high-fiber recipes,  
**So that** I have interesting and tasty ways to increase my fiber intake.

**Acceptance Criteria:**
- Recipe library with curated high-fiber recipes
- Each recipe shows ingredients, total fiber per serving, prep time, and difficulty
- Filter by meal category (breakfast, lunch, dinner, snack, dessert)
- User can save favorite recipes to their profile
- Recipes can be added directly to the meal planner

---

### US-009: Personalized Food Recommendations

**As a** user,  
**I want to** receive personalized recommendations for high-fiber foods and recipes,  
**So that** I can discover new options suited to my taste and eating habits.

**Acceptance Criteria:**
- Recommendations based on logging history, favorites, and preferences
- Shown on the dashboard and a dedicated Discover page
- User can dismiss a recommendation ("not interested")
- Dismissed items are excluded from future recommendations
- Recommendations refresh daily

---

### US-010: Analytics & Reporting

**As a** user,  
**I want to** view detailed reports on my fiber intake over time,  
**So that** I can understand my progress and identify areas for improvement.

**Acceptance Criteria:**
- Daily, weekly, and monthly fiber intake summaries
- Top foods contributing to fiber intake
- Days where goal was met vs. missed (calendar view)
- Progress trend charts
- Reports exportable as PDF or CSV

---

### US-011: Base Project Setup

**As a** developer,  
**I want to** have a base .NET/Blazor/Azure project scaffold in place,  
**So that** the team can build features on a consistent, well-structured foundation.

**Acceptance Criteria:**
- Blazor Server hybrid project created with .NET 8+
- Azure Functions project for background tasks
- Azure SQL or Cosmos DB configured for data persistence
- CI/CD pipeline set up with GitHub Actions targeting Azure
- Solution structure follows clean architecture principles
- Unit test project scaffolded
