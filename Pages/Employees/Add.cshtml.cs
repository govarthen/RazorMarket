using RazorMarket.Data;
using RazorMarket.Models.Domain;
using RazorMarket.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorMarket.Pages.Employees
{
    public class AddModel : PageModel
    {
        public readonly MyDbContext myDbContext;
        public AddModel(MyDbContext dbContext)
        {
            this.myDbContext = dbContext;
        }


        [BindProperty]
        public AddEmployeeVM AddEmployeeRequest { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            //Convert ViewModel to DomainModel
            var employeeDbModel = new Employee
            {
                Name = AddEmployeeRequest.Name,
                Email = AddEmployeeRequest.Email,
                Salary = AddEmployeeRequest.Salary
            };

            myDbContext.Employees.Add(employeeDbModel);
            myDbContext.SaveChanges();

            ViewData["Message"] = "Employee Saved Successfully !";

        }
    }
}
