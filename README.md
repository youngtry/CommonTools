# Common Tools for Unity

A comprehensive Unity utility package providing common tools for UI management, logging, time formatting, number formatting, currency symbols, and more.

## Features

- **UI Layout Management**: Force layout rebuilds and manage child objects
- **Enhanced Logging System**: Colored logs with complex object formatting support
- **Time Formatting**: Convert seconds to readable time formats and get UTC timestamps
- **Number Formatting**: Smart formatting for numbers with unit abbreviations
- **Currency Symbols**: Support for 100+ international currency symbols
- **Ordinal Numbers**: Convert numbers to English ordinal format (1st, 2nd, 3rd, etc.)
- **Sprite Management**: Utilities for working with Sprite Atlases
- **Singleton Pattern**: Generic singleton MonoBehaviour base class for easy singleton implementation
- **Rounded UI Components**: Custom UI components with rounded corners for enhanced visual design

## Installation

### Via Git URL (Recommended)

1. Open Unity Package Manager (Window → Package Manager)
2. Click the "+" button and select "Add package from git URL"
3. Enter the following URL:
   ```
   https://github.com/youngtry/CommonTools.git
   ```

### Via Git URL with Specific Version

To install a specific version, append the version tag:
```
https://github.com/youngtry/CommonTools.git#v1.0.0
```

### Manual Installation

1. Download or clone this repository
2. Copy the entire folder to your project's `Packages` directory
3. Unity will automatically detect and import the package

## Quick Start

```csharp
using CommonTools;

public class Example : MonoBehaviour
{
    void Start()
    {
        // Enable logging and set country
        Utils.ShowLog = true;
        Utils.Country = "US";
        
        // Log messages with different types
        Utils.Log("Game started!", Utils.LogType.Info);
        
        // Format time
        string gameTime = Utils.FormatTime(3725); // "01:02:05"
        
        // Format numbers
        string score = Utils.FormatDouble(1234567.89); // "1.23M"
        
        // Get currency symbol
        string currency = Utils.GetCurrencySymbol(); // "$"
        
        // Convert to ordinal
        string rank = Utils.ToOrdinal(1); // "1st"
        
        Utils.Log("Time: {0}, Score: {1}, Currency: {2}, Rank: {3}", 
                  Utils.LogType.Info, gameTime, score, currency, rank);
    }
}
```

## API Reference

### Static Properties

- `Utils.Country` (string): Current country code for currency formatting
- `Utils.ShowLog` (bool): Global toggle for logging output

### UI Management

- `Utils.ResizeLayout(GameObject container)`: Force rebuild layout
- `Utils.DeleteAllChildren(Transform parent)`: Delete all child objects (delayed)
- `Utils.DeleteAllChildrenImmediate(Transform parent)`: Delete all child objects (immediate)

### Logging

- `Utils.Log(string message, LogType type, params object[] args)`: Enhanced logging with formatting

### Time Utilities

- `Utils.FormatTime(int totalSeconds)`: Format seconds to HH:mm:ss or mm:ss
- `Utils.GetUtcTimestamp()`: Get UTC timestamp in seconds
- `Utils.GetUtcTimestampMilliseconds()`: Get UTC timestamp in milliseconds

### Number Formatting

- `Utils.FormatDouble(double number)`: Smart number formatting with decimals
- `Utils.Format(double value)`: Format large numbers with unit abbreviations

### Text Utilities

- `Utils.ToOrdinal(int number)`: Convert to English ordinal format

### Currency

- `Utils.GetCurrencySymbol()`: Get currency symbol for current country
- `Utils.GetAllCurrencySymbols()`: Get all supported currency symbols

### Sprite Management

- `Utils.GetSpriteFromAtlas(string spriteName, string atlasName)`: Get sprite from atlas

### Singleton Pattern

The `SingletonMonoBehaviour<T>` class provides a generic singleton pattern for MonoBehaviour components:

```csharp
using CommonTools;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    public override void Awake()
    {
        base.Awake(); // Important: call base.Awake()

        // Your initialization code here
        Utils.Log("GameManager initialized", Utils.LogType.Info);
    }

    public void DoSomething()
    {
        Utils.Log("Doing something...", Utils.LogType.Debug);
    }
}

// Usage from other scripts:
public class PlayerController : MonoBehaviour
{
    void Start()
    {
        // Access the singleton instance
        GameManager.Instance.DoSomething();

        // Check if singleton exists
        if (GameManager.Exists())
        {
            Utils.Log("GameManager is available", Utils.LogType.Info);
        }
    }
}
```

**Key Features:**
- Automatic singleton instance creation if none exists
- Automatic destruction of duplicate instances
- Thread-safe instance access
- `Exists()` method to check if instance is available
- `Reset()` method to clear the singleton instance

### Rounded UI Components

The `UIRoundedRawImage` component extends Unity's RawImage to provide rounded corners:

```csharp
using CommonTools;
using UnityEngine;
using UnityEngine.UI;

public class UIExample : MonoBehaviour
{
    void Start()
    {
        // Get or add the rounded raw image component
        UIRoundedRawImage roundedImage = GetComponent<UIRoundedRawImage>();

        // Configure the rounded corners
        roundedImage.Radius = 25f;        // Corner radius (smaller = more rounded)
        roundedImage.TriangleNum = 8;     // Smoothness (higher = smoother curves)

        // Set the texture
        roundedImage.texture = yourTexture;
    }
}
```

**Properties:**
- `Radius` (float): Controls the corner radius. Smaller values create more rounded corners
- `TriangleNum` (int): Number of triangles per corner. Higher values create smoother curves

**Usage Tips:**
- Use `Radius = 50f` for slightly rounded corners
- Use `Radius = 10f` for very rounded corners
- Use `TriangleNum = 6-12` for good performance/quality balance
- Higher `TriangleNum` values improve visual quality but may impact performance

## Examples

The package includes comprehensive examples in the Samples folder. To import:

1. Open Package Manager
2. Find "Common Tools" in the list
3. Expand "Samples" section
4. Click "Import" next to "Basic Usage Examples"

## Requirements

- Unity 2020.3 or later
- .NET Standard 2.0 compatible

## Supported Platforms

- All Unity supported platforms

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Add tests if applicable
5. Submit a pull request

## Support

If you encounter any issues or have questions:

1. Check the [documentation](Documentation~/CommonTools.md)
2. Look at the [examples](Samples~/BasicUsage/)
3. Create an issue on GitHub

## Changelog

See [CHANGELOG.md](CHANGELOG.md) for a detailed history of changes.
