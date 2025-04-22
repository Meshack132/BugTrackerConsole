# BugTrackerConsole - CLI Bug Tracking System

## 📝 Overview
A simple command-line bug tracking system built with C# that allows you to:
- Add, view, update, and delete bugs
- Filter bugs by status (Open, In Progress, Resolved)
- Assign bugs to developers
- Track severity levels (Low, Medium, High, Critical)
- Persist data to JSON file

## 🚀 Features
- **Bug Management**:
  - Create new bugs with title, description, and severity
  - View all bugs in the system
  - Filter bugs by status
  - Assign bugs to developers
- **Data Persistence**:
  - Automatically saves bugs to `bugs.json`
  - Loads existing bugs on startup
- **User-Friendly CLI**:
  - Simple menu-driven interface
  - Clear error messages

## 🛠️ Installation
1. Ensure you have [.NET 6.0+](https://dotnet.microsoft.com/download) installed
2. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/BugTrackerConsole.git
   ```
3. Navigate to the project directory:
   ```bash
   cd BugTrackerConsole
   ```
4. Restore dependencies:
   ```bash
   dotnet restore
   ```

## 🏃‍♂️ Running the Application
```bash
dotnet run
```

## 🗂️ Project Structure
```
BugTrackerConsole/
├── Models/
│   ├── Bug.cs            # Bug entity definition
│   ├── Severity.cs       # Severity enum (Low, Medium, High, Critical)
│   ├── Status.cs         # Status enum (Open, In Progress, Resolved)
├── Services/
│   ├── BugService.cs     # Core business logic
│   ├── FileService.cs    # JSON file operations
├── Program.cs            # Main application entry point
```

## 🧩 OOP Principles Applied
- **Encapsulation**: Private fields with public methods in `BugService`
- **Abstraction**: JSON operations hidden behind `FileService`
- **Polymorphism**: Enums used for consistent status/severity behavior
- **Separation of Concerns**: Clear division between models, services, and UI

## 📅 Future Improvements
- [ ] Add unit tests
- [ ] Implement bug update functionality
- [ ] Add sorting by date/severity
- [ ] Support multiple projects
- [ ] Add authentication system
- [ ] Implement search functionality

## 🤝 Contributing
Contributions are welcome! Please open an issue or submit a pull request.

## 📄 License
MIT License

---

**Author**: Meshack Mthimkhulu
**Version**: 1.0.0  
