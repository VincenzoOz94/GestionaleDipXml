using GestionaleDipXml.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace GestionaleDipXml.Controllers
{
    public class ReportController : Controller
    {
        private readonly DipendentiDbConext _context;
        public ReportController(DipendentiDbConext context)
        {
            _context = context;
        }
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

                // Salva il documento XML in un file
                xmlDocument.Save("dipendente.xml");
            }
            return View();
        }
            
            public IActionResult OttieniReportCompleto()
        {
            var dipendenti = _context.Dipendenti.ToList(); 

            
            XElement rootElement = new XElement("Dipendenti");

            
            foreach (var dipendente in dipendenti)
            {
                if (!string.IsNullOrEmpty(dipendente.DatiXml))
                {
                   
                    XDocument xmlDocument = XDocument.Parse(dipendente.DatiXml);

                    
                    XElement dipendenteElement = xmlDocument.Root;

                    
                    rootElement.Add(dipendenteElement);
                }
            }

            
            XDocument finalXmlDocument = new XDocument(rootElement);
            finalXmlDocument.Save("dipendenti.xml");

            return View();
        }
    }    
}

