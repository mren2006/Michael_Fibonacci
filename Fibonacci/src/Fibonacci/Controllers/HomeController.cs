using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fibonacci.Models;

namespace Fibonacci.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Calculate()
        {
            ViewData["Message"] = "Calculate Fibonacci Here.";

            return View();
        }



        public IActionResult Result(Fibo F)
        {
            int n = F.num;

            F.Iteration = FiboIteration(n);

            F.Recursion = FiboRecursion(n);

            return View(F);

        }

        int FiboIteration(int n)
        {

            if (n == 0) return 0;
            if (n == 1) return 1;

            int prev2 = 0;
            int prev1 = 1;
            int res = 0;

            for (int i = 2; i <= n; i++)
            {
                res = prev1 + prev2;
                prev2 = prev1;
                prev1 = res;
            }

            return res;
        }
        

        int FiboRecursion(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return FiboRecursion(n - 1) + FiboRecursion(n - 2);
        }
        
        public IActionResult Error()
        {
            return View();
        }
    }
}
