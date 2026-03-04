# Training Steps

Use this as a quick, end-to-end guide for the class. It keeps the flow intact but adds a bit more clarity for first-time users.

## Requirements

1. Have an active GitHub account.
1. Ask Justin to add you to the jwendl-training organization.
1. Use your work GitHub account, or link your personal and work accounts.
    1. Reference docs:
        1. [Link Account](https://docs.opensource.microsoft.com/github/opensource/accounts/linking/#linking-your-microsoft-alias-to-your-github-account)
        1. [Join Microsoft Organization](https://docs.opensource.microsoft.com/github/opensource/accounts/linking/#join-organizations)

## Create a Private Repository

1. Send Justin your GitHub username.
1. Go to the [jwendl-training repositories page](https://github.com/orgs/jwendl-training/repositories).
1. Select New repository.
1. Set the owner to jwendl-training.
1. Enter a unique repository name.
1. Set visibility to Private.
1. Keep the rest as default, then create the repository.

## Fetch the Template Project

1. Install Git for Windows if you do not already have it.
    1. Run `winget install Git.Git` in PowerShell.
1. Clone the [instructions-and-configurations repo](https://github.com/jwendl-training/instructions-and-configurations) locally.
1. Clone the repository you just created locally.
1. Copy the files from the instructions-and-configurations repo into your new repo.
1. Commit and push the changes to your new repository.

## Create Requirements

1. Open docs/requirements.md in your new repo.
1. Write the requirements for the app you want the agents to build.
1. Use the example below for ideas.

### Example

``` markdown
# Project: Push to Talk Manage Games to Try

## Purpose

Assist users using a push to talk interface on the **Discover page** to find which games to try next, based on their gaming history across Xbox, Windows Store, and Steam.

## Requirements

### Core Discovery

- Push to talk interface **on the Discover page only**
  - Users can say **"show me games like [game name]"** to receive AI-powered game recommendations similar to the named title
  - Users can say natural language filter commands such as **"no sports besides skateboarding"** to dynamically filter recommendations during a discovery session
- Ability to swipe right to add to wishlist
- Ability to swipe left to reject the game and remove those types of game from recommendations
- Shows small game clips and information about the game to allow user to determine to swipe or not

### Recommendation Sources

Recommendations are generated from the following data sources:

- **Steam Wishlist** – Games the user has already wishlisted on Steam serve as signals of interest
- **Steam Achievements** – Higher achievement completion rates indicate stronger engagement with a game/genre
- **Xbox Achievements** – Achievement completion on Xbox signals engagement (used where accessible via public API data)
- **Play Time** – Hours played on both Steam and Xbox factor into genre weighting
- **Tag Matching** – Game tags (genre, theme, mechanics) from played/owned titles are matched against upcoming and recommended games to surface similar titles

> **Note – Xbox Wishlist**: The Xbox wishlist API is **not publicly accessible** without Microsoft partner-level API access. The existing `XboxWishlistSyncFunction` has been retained for potential future access, but **Xbox wishlist data is not used in recommendations** at this time. See the Architecture document for details.

### Analytics

- Runs back end analytics to identify games that the user likes to play
  - Including played hours analytics from Steam and Xbox
  - Including achievements on Xbox and Steam (more achievements assume more engagement)
  - Including tag-based similarity matching from game title metadata

## Constraints

- Try to use .NET / Microsoft tech
- Azure will be the end deployment goal
- Try to use Blazor server hybrid mode for frontend and backend services for UX
- Azure functions for background running tasks if needed
- AI-powered recommendation queries (PTT "show me games like...") should integrate with Azure OpenAI or the Steam/IGDB tag matching system
```

## Update MCP Servers

1. Follow the steps in [mcp-configurations.md](mcp-configurations.md).

## Create GitHub Issues

1. If MCP servers and secrets are set up, you can ask GitHub agents to create issues.
1. Open the Agents tab at the top of the repo.
1. In Sessions, enter a prompt to generate issues.
    1. Example: "Please look at requirements.md and build out a set of GitHub issues / user stories to handle those requirements."
1. Review the Issues list and evaluate the user stories.

## Create Architecture Documentation

1. Open the Agents tab.
1. Enter a prompt to generate architecture documentation.
    1. Example: "Please create the architectural documentation and diagrams required to fulfill the requirements for the project and ensure they are put in docs/architecture."
1. When the agent finishes, a pull request will appear. Review it when it is ready.

## Create the Base Project

1. Open the Agents tab.
1. Enter a prompt to create the base project.
    1. Example: "Create a set of base project(s) to accommodate the architecture and requirements of the project."
1. When the agent finishes, a pull request will appear. Review it when it is ready.

## Handle Pull Requests

1. You should now see two pull requests: one for docs and one for the base project.
1. Review the pull requests and leave comments if anything needs changes.
    1. Example: "@copilot - please update the code to handle this situation."
1. If you see a recurring pattern you want to change, ask Copilot to update the instructions.
    1. Example: "Hey @copilot - please change from using inline if statements to multi-line if statements, and update our instructions so we do not do that again."
1. When everything looks good, merge the pull requests to main.

> As an aside, this is the power and flexibility of GitHub Copilot Coding Agents: going through a full software lifecycle with feedback, and evolving requirements over time.

## Assign User Stories to Copilot

1. Find an issue you want Copilot to handle.
1. Open the issue and assign it to Copilot.
1. A new plan task will appear under Agents.
1. Wait for the pull request to move out of WIP status.
1. Review and merge using the pull request steps above.
