# MCP Server Configuration

## Repository Settings

1. Go into the repository settings for your created repository.
1. Click on Copilot
1. Click on Coding agent
1. Under the section called Model Context Protocol (MCP) add the following json

``` json
{
  "mcpServers": {
    "Azure": {
      "type": "local",
      "command": "npx",
      "args": [
        "-y",
        "@azure/mcp@latest",
        "server",
        "start"
      ],
      "tools": ["*"]
    },
    "eraser": {
      "type": "local",
      "command": "npx",
      "args": ["@eraserlabs/eraser-mcp"],
      "tools": ["*"],
      "env": {
        "ERASER_API_TOKEN": "COPILOT_MCP_ERASER_API_TOKEN",
        "ERASER_API_URL": "https://app.eraser.io/api/mcp"
      }
    },
    "github-issues-write": {
      "type": "http",
      "url": "https://api.githubcopilot.com/mcp",
      "tools": ["*"],
      "headers": {
        "Authorization": "Bearer ${COPILOT_MCP_GITHUB_TOKEN}",
        "X-MCP-Toolsets": "repos,issues,users,pull_requests,code_security,secret_protection,actions,web_search"
      }
    }
  }
}
```

1. Then go to Environments
1. Then select copilot
1. Create a secret named COPILOT_MCP_ERASER_API_TOKEN
    1. The value will either be your Eraser IO API key if you have one, or ask Justin for his
1. Create a secret named COPILOT_MCP_GITHUB_TOKEN
    1. The value will be a PAT token you create for GitHub with only access to your repo (see below)

## Creating a PAT for the secret

1. Go under your account (upper right) and select Settings
1. On the left go down to Developer Settings
1. Click on Personal access tokens
1. Click on Fine-grained tokens
1. Click on Generate new token
1. Name it something like MCP Server
1. Under Repository access choose Only select repositories
1. Select the repository you created under the jwendl-training org
1. Click Add permissions
1. Choose Read access to code and metadata
1. Choose Read and Write access to issues and pull requests
