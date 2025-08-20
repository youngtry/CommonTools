#!/bin/bash

# Sync script to copy Assets scripts to Runtime directory
# Usage: ./sync_to_runtime.sh

echo "🔄 Syncing Assets to Runtime directory..."

# Check if source file exists
if [ ! -f "Assets/CommonTools/Scripts/Utils.cs" ]; then
    echo "❌ Source file not found: Assets/CommonTools/Scripts/Utils.cs"
    exit 1
fi

# Check if Runtime directory exists
if [ ! -d "Runtime" ]; then
    echo "❌ Runtime directory not found"
    exit 1
fi

# Copy the file
cp "Assets/CommonTools/Scripts/Utils.cs" "Runtime/"

if [ $? -eq 0 ]; then
    echo "✅ Successfully synced Utils.cs to Runtime/"
    
    # Show git status
    echo ""
    echo "📊 Git status:"
    git status --porcelain Runtime/
    
    echo ""
    echo "💡 Next steps:"
    echo "   1. Review changes: git diff Runtime/Utils.cs"
    echo "   2. Test the package in Unity"
    echo "   3. Commit changes: git add Runtime/ && git commit -m 'Update Utils.cs'"
    echo "   4. Tag new version if needed: git tag v1.0.1"
else
    echo "❌ Failed to sync file"
    exit 1
fi
