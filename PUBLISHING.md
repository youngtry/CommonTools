# Publishing Guide

This guide explains how to publish and maintain the Common Tools UPM package.

## Initial Setup

### 1. Update Package Information

Before publishing, update the following files with your actual information:

**package.json:**
```json
{
  "name": "com.yourcompany.commontools",
  "documentationUrl": "https://github.com/YOUR_USERNAME/CommonTools#readme",
  "changelogUrl": "https://github.com/YOUR_USERNAME/CommonTools/blob/main/CHANGELOG.md",
  "licensesUrl": "https://github.com/YOUR_USERNAME/CommonTools/blob/main/LICENSE",
  "author": {
    "name": "Your Name",
    "email": "your.email@example.com",
    "url": "https://github.com/YOUR_USERNAME"
  }
}
```

**README.md:**
- Update installation URLs
- Replace placeholder GitHub links

**Documentation files:**
- Update all GitHub URLs in documentation

### 2. Create GitHub Repository

1. Create a new repository on GitHub
2. Name it "CommonTools" (or your preferred name)
3. Make it public (required for UPM Git URL installation)
4. Initialize with README (optional, you'll overwrite it)

### 3. Prepare Repository Structure

The repository should have this structure:
```
CommonTools/
├── package.json
├── README.md
├── CHANGELOG.md
├── LICENSE
├── Runtime/
│   ├── Utils.cs
│   └── CommonTools.asmdef
├── Samples~/
│   └── BasicUsage/
│       ├── Scene/
│       └── Scripts/
├── Documentation~/
│   ├── CommonTools.md
│   ├── CommonTools_CN.md
│   └── Installation.md
└── .github/
    └── workflows/
        └── release.yml
```

## Publishing Process

### 1. Initial Commit

```bash
# Initialize git repository
git init

# Add all files
git add .

# Commit
git commit -m "Initial commit: Common Tools UPM package v1.0.0"

# Add remote origin
git remote add origin https://github.com/youngtry/CommonTools.git

# Push to GitHub
git push -u origin main
```

### 2. Create Release Tag

```bash
# Create and push version tag
git tag v1.0.0
git push origin v1.0.0
```

### 3. Create GitHub Release

1. Go to your repository on GitHub
2. Click "Releases" → "Create a new release"
3. Choose the tag you just created (v1.0.0)
4. Fill in release information:
   - **Release title**: "v1.0.0 - Initial Release"
   - **Description**: Copy from CHANGELOG.md
5. Publish the release

## Installation for Users

Once published, users can install your package using:

```
https://github.com/youngtry/CommonTools.git
```

Or with specific version:
```
https://github.com/youngtry/CommonTools.git#v1.0.0
```

## Updating the Package

### 1. Make Changes

- Update code in Runtime/
- Add new features
- Fix bugs
- Update documentation

### 2. Update Version

**package.json:**
```json
{
  "version": "1.1.0"
}
```

**CHANGELOG.md:**
```markdown
## [1.1.0] - 2025-01-21

### Added
- New feature X
- New utility function Y

### Fixed
- Bug fix Z
```

### 3. Commit and Tag

```bash
# Commit changes
git add .
git commit -m "Version 1.1.0: Add new features and bug fixes"

# Create new tag
git tag v1.1.0
git push origin main
git push origin v1.1.0
```

### 4. Create New Release

Repeat the GitHub release process with the new version.

## Best Practices

### Versioning

Follow [Semantic Versioning](https://semver.org/):
- **MAJOR** (1.0.0 → 2.0.0): Breaking changes
- **MINOR** (1.0.0 → 1.1.0): New features, backwards compatible
- **PATCH** (1.0.0 → 1.0.1): Bug fixes, backwards compatible

### Documentation

- Always update CHANGELOG.md
- Keep README.md current
- Update API documentation for new features
- Include examples for new functionality

### Testing

- Test the package in a clean Unity project
- Verify all samples work correctly
- Test installation via Git URL
- Check compatibility with target Unity versions

### Git Workflow

- Use meaningful commit messages
- Tag every release
- Keep main branch stable
- Use feature branches for development

## Troubleshooting

### Common Issues

**Package not found:**
- Ensure repository is public
- Check URL spelling
- Verify package.json is in root directory

**Import errors:**
- Check Unity version compatibility
- Verify assembly definitions are correct
- Ensure all dependencies are listed

**Samples not working:**
- Check Samples~ folder structure
- Verify sample scripts have correct namespaces
- Test samples in clean project

### Support

- Monitor GitHub Issues
- Respond to user questions
- Update documentation based on feedback
- Consider creating a Discord/Forum for community

## Maintenance

### Regular Tasks

- Update Unity compatibility as new versions release
- Monitor for security issues
- Keep dependencies updated
- Review and merge community contributions

### Long-term Planning

- Plan major version updates
- Consider additional features
- Maintain backwards compatibility
- Archive old versions when necessary
