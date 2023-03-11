using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorMarket.Data;
using RazorMarket.Models.Domain;

namespace RazorMarket.Pages.Employees
{
    public class ListModel : PageModel
    {
        private readonly MyDbContext myDbContext;

        public List<Employee> Employees { get; set; }
        public ListModel(MyDbContext dbContext) 
        { 
            this.myDbContext = dbContext;
        }
        public void OnGet()
        {
            Employees = myDbContext.Employees.ToList();
        }
    }
}
