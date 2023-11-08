using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsMVCAutograded6.Data;
using TechJobsMVCAutograded6.Models;

namespace TechJobsMVCAutograded6.Controllers;

public class SearchController : Controller
{
    List<Job> jobs = new List<Job>();

    // GET: /<controller>/
    public IActionResult Index()
    {
        ViewBag.columns = ListController.ColumnChoices;
        return View(jobs);
    }

    // TODO #3 - Create an action method to process a search request and render the updated search views.
    public IActionResult Results(string searchType, string searchTerm)
    {
        if (searchTerm == "all" || searchTerm == "")
        {
            jobs = JobData.FindAll();
        } else
        {
            jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
        }
        return View();

    }
}

