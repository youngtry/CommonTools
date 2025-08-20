# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.0.5] - 2025-01-20

### Fixed
- Fixed "PUBLISHING.md has no meta file" error in Unity Package Manager
- Removed PUBLISHING.md from UPM package (development document, not for end users)
- Added development files to .gitignore to prevent future inclusion

### Removed
- PUBLISHING.md (moved to development-only files)
- Development scripts from package distribution

### Technical Details
- Package now only contains files relevant to end users
- No more Unity warnings about missing .meta files for development documents
- Cleaner package structure focused on user-facing content

## [1.0.4] - 2025-01-20

### Changed
- Renamed Documentation~ directory to Documentation (removed tilde)
- Updated .gitignore for new Documentation path
- Improved package structure consistency

### Technical Details
- All directory names now follow standard naming conventions without tildes
- Package structure is now fully standardized: Runtime/, Samples/, Documentation/
- All .meta files maintained during directory rename

## [1.0.3] - 2025-01-20

### Changed
- **BREAKING CHANGE**: Renamed Samples~ directory to Samples (removed tilde)
- Updated package.json to use correct Samples path
- Cleaned up package structure for better UPM compatibility

### Added
- Added missing .meta files for all Documentation files
- Complete .meta file coverage for all package assets

### Removed
- Removed sync_to_runtime.sh script from package (development tool, not needed in package)

### Fixed
- Fixed missing .meta files for Documentation directory contents
- Improved .gitignore patterns for Samples directory

### Technical Details
- Samples directory path changed from `Samples~/BasicUsage` to `Samples/BasicUsage`
- All Documentation files now have proper .meta files
- Package structure is now fully compliant with Unity Package Manager standards

## [1.0.2] - 2025-01-20

### Fixed
- Fixed "Runtime folder has no meta file" error in Unity Package Manager
- Added missing .meta files for all package folders (Runtime/, Samples~/, Documentation~/)
- Added missing .meta files for all Samples subdirectories
- Updated .gitignore to properly include folder .meta files

### Technical Details
- All UPM package folders now have proper Unity .meta files
- Package should now load completely without any folder-related warnings
- Improved .gitignore patterns for better .meta file inclusion

## [1.0.1] - 2025-01-20

### Fixed
- Fixed "Asset has no meta file" errors in Unity Package Manager
- Added missing .meta files for all Runtime scripts and assets
- Added missing .meta files for documentation and license files
- Added missing .meta files for Samples scripts
- Updated .gitignore to properly include necessary .meta files for UPM packages

### Added
- CommonToolsTest.cs for automatic package verification and testing
- sync_to_runtime.sh script for development workflow when maintaining dual versions

### Technical Details
- All UPM package files now have proper Unity .meta files
- Package should now load correctly without warnings in Unity Package Manager
- Added automatic package loading verification via RuntimeInitializeOnLoadMethod

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
