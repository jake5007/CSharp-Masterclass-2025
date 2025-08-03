# CSharp-Masterclass-2025

This repository contains selected assignments and projects from the Udemy course **Ultimate C# Masterclass for 2025**.

## Projects

### 1. GameDataParser

- Reads JSON files containing game data
- Applies Single Responsibility Principle (SRP)
- Outputs structured results to console
- Writes Log file when exception occurs

### 2. CustomCache

- Implements a generic in-memory cache using `Dictionary<TKey, TValue>`
- Uses `Func<TKey, TData>` for lazy data retrieval
- Demonstrates the Decorator Design Pattern for modular behavior
- Includes layered components: SlowDataDownloader → Printing → Caching
- Avoids redundant operations by caching repeated data requests

### 3. CookiesCookBookLINQ

- Demonstrates usage of LINQ methods like `Select`, `Where`, `FirstOrDefault`, and `Count`
- Applies core OOP principles including **polymorphism**, **inheritance**, and **interfaces**
- Simulates a simple cookie recipe app with modular, reusable class structure
- Clean, object-oriented code with SRP and clear method separation

---

## How to Run

This repository contains multiple independent C# console applications.  
You can run each project individually using Visual Studio or the .NET CLI.

### Using Visual Studio

- Navigate to the desired project folder (e.g., `GameDataParser/`)
- Open the `.csproj` file
- Press `Ctrl + F5` to build and run the app

### Using .NET CLI

- In a terminal:
  ```bash
  cd GameDataParser
  dotnet run
  ```
