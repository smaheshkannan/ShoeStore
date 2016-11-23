using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoeStore.Controllers
{
    public class IssueController : Controller
    {
        //
        // GET: /Issue/

        public ActionResult Index()
        {
            return PartialView("Index", ShoeStore.Models.Issue.GetIssues());
        }

        public ActionResult ReportIssue()
        {
            return PartialView("ReportIssue");
        }

        public ActionResult NewIssue(ShoeStore.Models.IssueViewModel issue)
        {
            ShoeStore.Models.Issue.ReportIssue(new ShoeStore.Models.Issue() { description = issue.description, title = issue.title, Severity = (ShoeStore.Models.Severity)Enum.Parse(typeof(ShoeStore.Models.Severity), issue.Severity) });
            ViewBag.Issues = true;
            return View("../Home/Index");
        }

    }
}
