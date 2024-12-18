using businesslayer.concrete;
using businesslayer.validationrules;
using dataaccesslayer.entityframework;
using entitylayer.concrete;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;
using Microsoft.AspNetCore.Authorization;

namespace core_proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PortfolioController : Controller
    {
        PortfolioManager portfoliomenager = new PortfolioManager(new efportfoliodal());
        public IActionResult Index()
        {
            var values = portfoliomenager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPortfolio(portfolio p)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult results = validations.Validate(p);
            if (results.IsValid)
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            else
            {
                portfoliomenager.Tadd(p);
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult DeletePortfolio(int id) 
        {
            var values = portfoliomenager.TGetByID(id);
            portfoliomenager.Tdelete(values);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            var values = portfoliomenager.TGetByID(id);
            return View(values);
        }
        public IActionResult EditPortfolio(portfolio portfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(portfolio);
            if (result.IsValid)
            {
                portfoliomenager.Tupdate(portfolio);
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            portfoliomenager.Tupdate(portfolio);
            return RedirectToAction("index");
        }
    }
}
