# Installation Guide

This guide explains how to install the Common Tools package in your Unity project.

## Method 1: Git URL (Recommended)

This is the easiest way to install and update the package.

### Steps:

1. **Open Unity Package Manager**
   - In Unity, go to `Window → Package Manager`

2. **Add Package from Git URL**
   - Click the `+` button in the top-left corner
   - Select `Add package from git URL...`

3. **Enter the Git URL**
   ```
   https://github.com/youngtry/CommonTools.git
   ```

4. **Install Specific Version (Optional)**
   To install a specific version, append the version tag:
   ```
   https://github.com/youngtry/CommonTools.git#v1.0.0
   ```

5. **Wait for Installation**
   - Unity will download and install the package automatically
   - The package will appear in the Package Manager under "In Project"

## Method 2: Download and Import

If you prefer to download the package manually:

### Steps:

1. **Download the Package**
   - Go to the [GitHub repository](https://github.com/youngtry/CommonTools)
   - Click `Code → Download ZIP`
   - Extract the ZIP file

2. **Copy to Packages Folder**
   - Navigate to your Unity project folder
   - Open the `Packages` folder
   - Copy the extracted `CommonTools` folder into `Packages`

3. **Refresh Unity**
   - Return to Unity
   - The package should appear automatically in Package Manager

## Method 3: Clone Repository

For developers who want to contribute or modify the package:

### Steps:

1. **Navigate to Packages Folder**
   ```bash
   cd YourUnityProject/Packages
   ```

2. **Clone the Repository**
   ```bash
   git clone https://github.com/youngtry/CommonTools.git
   ```

3. **Refresh Unity**
   - The package will be detected automatically

## Verification

After installation, verify the package is working:

1. **Check Package Manager**
   - The package should appear under "In Project"
   - Version should match what you installed

2. **Import Samples (Optional)**
   - In Package Manager, find "Common Tools"
   - Expand the "Samples" section
   - Click "Import" next to "Basic Usage Examples"

3. **Test Basic Functionality**
   ```csharp
   using CommonTools;
   
   public class TestScript : MonoBehaviour
   {
       void Start()
       {
           Utils.Log("Common Tools is working!", Utils.LogType.Info);
       }
   }
   ```

## Updating the Package

### For Git URL Installation:
1. Open Package Manager
2. Find "Common Tools" in the list
3. Click "Update" if available
4. Or remove and re-add with new version tag

### For Manual Installation:
1. Delete the old package folder from `Packages`
2. Download and copy the new version
3. Unity will refresh automatically

## Troubleshooting

### Package Not Appearing
- Check that the URL is correct
- Ensure you have internet connection
- Try refreshing Package Manager (`Window → Package Manager`)

### Git URL Not Working
- Verify the repository is public
- Check if your Unity version supports Git packages (2019.3+)
- Try using HTTPS instead of SSH

### Import Errors
- Check Unity version compatibility (requires 2020.3+)
- Ensure .NET Standard 2.0 is selected in Player Settings
- Check for conflicting packages

### Sample Import Issues
- Make sure the package is properly installed first
- Check that Samples~ folder exists in the package
- Try reimporting the samples

## Requirements

- **Unity Version**: 2020.3 or later
- **Scripting Backend**: .NET Standard 2.0 compatible
- **Internet Connection**: Required for Git URL installation

## Support

If you encounter issues:

1. Check the [GitHub Issues](https://github.com/youngtry/CommonTools/issues)
2. Review the [Documentation](CommonTools.md)
3. Try the [Examples](../Samples~/BasicUsage/)
4. Create a new issue if needed
