using GestionaleDipXml.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace GestionaleDipXml.Controllers
{
    public class ReportController : Controller
    {
        private readonly DipendentiDbConext _context;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OttieniSingoloReportReport() 
        {
            
            var dipendente =_context.Dipendenti.FirstOrDefault(); 

            if (dipendente != null && !string.IsNullOrEmpty(dipendente.DatiXml))
            {
                
                XDocument xmlDocument = XDocument.Parse(dipendente.DatiXml);

                
                xmlDocument.Save("dipendente.xml");
            }
            return View();
        }
            
                
    }
}
