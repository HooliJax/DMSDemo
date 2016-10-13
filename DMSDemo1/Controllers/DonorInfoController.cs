using DMSDemo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMSDemo1.Controllers
{
    public class DonorInfoController : Controller
    {
        private readonly List <DonorInfo>donors = new List<DonorInfo>()
    {
        new DonorInfo { Id = 1, FirstName = "Julio", Middle = "A", LastName = "Avellaneda", Title = "Mr.", Suffix = "", CompanyName = "Google", Address = "", City = "Jacksonville", State = "FL", Zip = 33225, Email = "julito_gtu@hotmail.com", Phone = "", Birthday = "11/12/1991", Gender = "Male", Relationship = "N/A", Identity = "" },
        new DonorInfo { Id = 2, FirstName = "Bob", Middle = "B", LastName = "Smith", Title = "Mr.", Suffix = "", CompanyName = "Ajax", Address = "", City = "Jacksonville", State = "FL", Zip = 33285, Email = "bob@hotmail.com", Phone = "", Birthday = "08/12/1991", Gender = "Male", Relationship = "N/A", Identity = "" },
        new DonorInfo { Id = 3, FirstName = "Tom", Middle = "C", LastName = "Ford", Title = "Mr.", Suffix = "", CompanyName = "FSCJ", Address = "", City = "Jacksonville", State = "FL", Zip = 33223, Email = "tom@hotmail.com", Phone = "", Birthday = "06/06/1982", Gender = "Male", Relationship = "N/A", Identity = "" },
        new DonorInfo { Id = 4, FirstName = "Lupe", Middle = "D", LastName = "Fiasco", Title = "Mr.", Suffix = "", CompanyName = "FNF", Address = "", City = "Jacksonville", State = "FL", Zip = 30025, Email = "lupe@hotmail.com", Phone = "", Birthday = "08/08/1986", Gender = "Male", Relationship = "N/A", Identity = "" },
        new DonorInfo { Id = 5, FirstName = "Kendrick", Middle = "E", LastName = "Lamar", Title = "Mr.", Suffix = "", CompanyName = "TDE", Address = "", City = "Jacksonville", State = "FL", Zip = 30205, Email = "kdot@hotmail.com", Phone = "", Birthday = "04/24/1975", Gender = "Male", Relationship = "N/A", Identity = "" },
        new DonorInfo { Id = 6, FirstName = "Warren", Middle = "F", LastName = "Buffett", Title = "Mr.", Suffix = "", CompanyName = "", Address = "", City = "Jacksonville", State = "FL", Zip = 31115, Email = "cashmoney@hotmail.com", Phone = "", Birthday = "01/22/1978", Gender = "Male", Relationship = "N/A", Identity = "" },
        new DonorInfo { Id = 7, FirstName = "Karthik", Middle = "G", LastName = "Umapathy", Title = "Mr.", Suffix = "", CompanyName = "UNF", Address = "", City = "Jacksonville", State = "FL", Zip = 31235, Email = "seniorproj@hotmail.com", Phone = "", Birthday = "02/10/1988", Gender = "Male", Relationship = "N/A", Identity = "" },
    };
        
        public ActionResult Index()
        {
            return View(donors);
        }
    }
}