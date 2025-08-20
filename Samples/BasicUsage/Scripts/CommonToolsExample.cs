using UnityEngine;
using UnityEngine.UI;
using CommonTools;

namespace CommonTools.Examples
{
    /// <summary>
    /// Example script demonstrating the usage of CommonTools utilities
    /// </summary>
    public class CommonToolsExample : MonoBehaviour
    {
        [Header("UI References")]
        public Text logOutput;
        public Text timeDisplay;
        public Text numberDisplay;
        public Text currencyDisplay;
        public Text ordinalDisplay;
        public Transform containerToResize;
        public Transform parentWithChildren;

        [Header("Test Values")]
        public double testNumber = 1234567.89;
        public int testSeconds = 3725;
        public int testOrdinal = 1;

        void Start()
        {
            // Set up logging
            Utils.ShowLog = true;
            Utils.Country = "US";

            // Demonstrate logging
            DemonstrateLogging();

            // Demonstrate time formatting
            DemonstrateTimeFormatting();

            // Demonstrate number formatting
            DemonstrateNumberFormatting();

            // Demonstrate currency symbols
            DemonstrateCurrencySymbols();

            // Demonstrate ordinal numbers
            DemonstrateOrdinalNumbers();

            // Update UI displays
            UpdateUIDisplays();
        }

        void DemonstrateLogging()
        {
            Utils.Log("=== CommonTools Example Started ===", Utils.LogType.Info);
            Utils.Log("This is a debug message", Utils.LogType.Debug);
            Utils.Log("This is an info message", Utils.LogType.Info);
            Utils.Log("This is a warning message", Utils.LogType.Warning);
            Utils.Log("This is an error message", Utils.LogType.Error);

            // Log with parameters
            Utils.Log("User {0} scored {1} points", Utils.LogType.Info, "Player1", 12345);

            // Log complex objects
            var testList = new System.Collections.Generic.List<int> { 1, 2, 3, 4, 5 };
            var testDict = new System.Collections.Generic.Dictionary<string, int> 
            { 
                {"apples", 5}, 
                {"oranges", 3} 
            };
            Utils.Log("List: {0}, Dictionary: {1}", Utils.LogType.Debug, testList, testDict);
        }

        void DemonstrateTimeFormatting()
        {
            string formattedTime = Utils.FormatTime(testSeconds);
            Utils.Log("Formatted time for {0} seconds: {1}", Utils.LogType.Info, testSeconds, formattedTime);

            long timestamp = Utils.GetUtcTimestamp();
            long timestampMs = Utils.GetUtcTimestampMilliseconds();
            Utils.Log("UTC Timestamp: {0}, UTC Timestamp (ms): {1}", Utils.LogType.Info, timestamp, timestampMs);
        }

        void DemonstrateNumberFormatting()
        {
            string formattedNumber = Utils.FormatDouble(testNumber);
            string largeNumber = Utils.Format(testNumber);
            Utils.Log("Original: {0}, FormatDouble: {1}, Format: {2}", 
                     Utils.LogType.Info, testNumber, formattedNumber, largeNumber);

            // Test various numbers
            double[] testNumbers = { 123.456, 1000.0, 123.00, 1500000, 999999999 };
            foreach (double num in testNumbers)
            {
                Utils.Log("Number {0} formatted: {1}", Utils.LogType.Debug, num, Utils.FormatDouble(num));
            }
        }

        void DemonstrateCurrencySymbols()
        {
            string currentSymbol = Utils.GetCurrencySymbol();
            Utils.Log("Current currency symbol for {0}: {1}", Utils.LogType.Info, Utils.Country, currentSymbol);

            // Test different countries
            string[] countries = { "US", "CN", "JP", "GB", "EU", "KR" };
            foreach (string country in countries)
            {
                Utils.Country = country;
                string symbol = Utils.GetCurrencySymbol();
                Utils.Log("Currency for {0}: {1}", Utils.LogType.Debug, country, symbol);
            }

            // Reset to original
            Utils.Country = "US";
        }

        void DemonstrateOrdinalNumbers()
        {
            for (int i = 1; i <= 25; i++)
            {
                string ordinal = Utils.ToOrdinal(i);
                if (i <= 5 || i % 5 == 0)
                {
                    Utils.Log("Ordinal for {0}: {1}", Utils.LogType.Debug, i, ordinal);
                }
            }
        }

        void UpdateUIDisplays()
        {
            if (timeDisplay != null)
                timeDisplay.text = $"Time: {Utils.FormatTime(testSeconds)}";

            if (numberDisplay != null)
                numberDisplay.text = $"Number: {Utils.FormatDouble(testNumber)}";

            if (currencyDisplay != null)
                currencyDisplay.text = $"Currency: {Utils.GetCurrencySymbol()}";

            if (ordinalDisplay != null)
                ordinalDisplay.text = $"Ordinal: {Utils.ToOrdinal(testOrdinal)}";

            if (logOutput != null)
                logOutput.text = "Check Console for detailed logs";
        }

        // UI Button Methods
        public void OnResizeLayoutClicked()
        {
            if (containerToResize != null)
            {
                Utils.ResizeLayout(containerToResize.gameObject);
                Utils.Log("Layout resized for container: {0}", Utils.LogType.Info, containerToResize.name);
            }
        }

        public void OnDeleteChildrenClicked()
        {
            if (parentWithChildren != null)
            {
                int childCount = parentWithChildren.childCount;
                Utils.DeleteAllChildren(parentWithChildren);
                Utils.Log("Deleted {0} children from {1}", Utils.LogType.Info, childCount, parentWithChildren.name);
            }
        }

        public void OnDeleteChildrenImmediateClicked()
        {
            if (parentWithChildren != null)
            {
                int childCount = parentWithChildren.childCount;
                Utils.DeleteAllChildrenImmediate(parentWithChildren);
                Utils.Log("Immediately deleted {0} children from {1}", Utils.LogType.Info, childCount, parentWithChildren.name);
            }
        }

        public void OnToggleLoggingClicked()
        {
            Utils.ShowLog = !Utils.ShowLog;
            Utils.Log("Logging toggled: {0}", Utils.LogType.Info, Utils.ShowLog ? "ON" : "OFF");
        }

        public void OnChangeCountryClicked()
        {
            string[] countries = { "US", "CN", "JP", "GB", "EU", "KR" };
            int currentIndex = System.Array.IndexOf(countries, Utils.Country);
            int nextIndex = (currentIndex + 1) % countries.Length;
            Utils.Country = countries[nextIndex];
            
            UpdateUIDisplays();
            Utils.Log("Country changed to: {0}, Currency: {1}", 
                     Utils.LogType.Info, Utils.Country, Utils.GetCurrencySymbol());
        }
    }
}
