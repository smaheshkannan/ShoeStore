using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoeStore.Models
{
    public enum Severity { Low, Medium, High, Critical };
    public class Issue
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Severity Severity { get; set; }

        #region Static Values
        private static List<Issue> issues;
        static Issue()
        {
            // Default Temp Issues
            issues = new List<Issue>();
            issues.Add(new Issue() { Id = 1, description = "Testing Issue", Severity = Severity.Low, title = "Shoe missing" });
            issues.Add(new Issue() { Id = 2, description = "The respective shoes are missing.", Severity = Severity.Critical, title = "2" });
            issues.Add(new Issue() { Id = 3, description = "1. Open rb shoe site 2. Click December month link 3. Verify that if no shoe present it should show Coming Soon text. Actual: December page shows blank without any message", Severity = Severity.Medium, title = "December month page shows blank page" });
            issues.Add(new Issue() { Id = 4, description = "1. Open rb shoe site 2. Click November month link 3. Verify that page should show image of shoe. November month page does not show shoe image", Severity = Severity.High, title = "November month page does not show shoe image" });
        }
        #endregion Static Values

        #region Static Methods
        public static List<Issue> GetIssues()
        {
            return issues;
        }

        public static void ReportIssue(Issue issue)
        {
            issue.Id = issues.Count + 1;
            issues.Add(issue);
        }
        #endregion Static Methods
    }
}