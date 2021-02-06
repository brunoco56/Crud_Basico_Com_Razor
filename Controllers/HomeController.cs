using ContSelf.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ContSelf.Controllers
{
    public class HomeController : Controller 
    {
        private readonly FuncionarioContexto _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,  FuncionarioContexto context)
        {
            _logger = logger;
            _context = context;
        }
       
        public async Task<IActionResult> Index()
        {
            return View(await _context.funcionario.ToListAsync());
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
       

        //public async Task<IActionResult>Formulario(FuncionarioContexto funcionarios)
        //{


        //    if (nome == null)
        //    {
        //        return NotFound();
        //    }

        //    var funcionario = await _context.funcionario
        //        .FirstOrDefaultAsync(m => m.Nome =="bruno");
        //    if (funcionario == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(funcionario);
        //}
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
