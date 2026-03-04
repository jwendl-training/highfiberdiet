# highfiberdiet
High Fiber Food

## Running Locally

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Steps

1. Clone the repository:

   ```bash
   git clone https://github.com/jwendl-training/highfiberdiet.git
   cd highfiberdiet
   ```

2. Restore dependencies and build the solution:

   ```bash
   dotnet build HighFiberDiet.sln
   ```

3. Run the web application:

   ```bash
   cd src/HighFiberDiet
   dotnet run
   ```

4. Open your browser and navigate to:
   - HTTP: [http://localhost:5176](http://localhost:5176)
   - HTTPS: [https://localhost:7040](https://localhost:7040)

### Running Tests

```bash
dotnet test HighFiberDiet.sln
```
