# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.0.0] - 2025-01-20

### Added
- Initial release of Common Tools package
- Utils class with comprehensive utility functions
- UI Layout Management utilities
  - `ResizeLayout()` for forcing layout rebuilds
  - `DeleteAllChildren()` and `DeleteAllChildrenImmediate()` for child management
- Enhanced Logging System
  - Colored log output in Unity Editor
  - Support for complex object formatting (lists, dictionaries)
  - Multiple log types (Debug, Info, Warning, Error)
  - Global logging toggle via `ShowLog` property
- Time Formatting utilities
  - `FormatTime()` for converting seconds to readable format
  - `GetUtcTimestamp()` and `GetUtcTimestampMilliseconds()` for timestamps
- Number Formatting utilities
  - `FormatDouble()` for smart decimal formatting
  - `Format()` for large number abbreviations (K, M, B, etc.)
- Currency Symbol Management
  - Support for 100+ international currencies
  - `GetCurrencySymbol()` based on country code
  - `GetAllCurrencySymbols()` for complete currency list
- Text Utilities
  - `ToOrdinal()` for English ordinal number conversion (1st, 2nd, 3rd, etc.)
- Sprite Management
  - `GetSpriteFromAtlas()` for sprite atlas utilities
- Comprehensive documentation in English and Chinese
- Example scenes and scripts demonstrating all features
- UPM package structure for easy installation

### Technical Details
- Compatible with Unity 2020.3+
- .NET Standard 2.0 compatible
- Assembly Definition included for proper dependency management
- Samples included for easy integration testing

## [Unreleased]

### Planned Features
- Additional number formatting options
- More currency symbols and regional support
- Performance optimizations for logging system
- Additional UI utilities
- Editor tools and inspectors

---

## Version History

### Version Numbering
This project follows [Semantic Versioning](https://semver.org/):
- **MAJOR** version for incompatible API changes
- **MINOR** version for backwards-compatible functionality additions  
- **PATCH** version for backwards-compatible bug fixes

### Release Notes Format
- **Added** for new features
- **Changed** for changes in existing functionality
- **Deprecated** for soon-to-be removed features
- **Removed** for now removed features
- **Fixed** for any bug fixes
- **Security** for vulnerability fixes
