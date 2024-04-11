using GestionaleDipXml.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionaleDipXml.Data
{
    public class DipendentiDbConext:DbContext
    {
        public DipendentiDbConext(DbContextOptions<DipendentiDbConext> options)
            : base(options)
        {
        }
        public DbSet<Dipendente> Dipendenti { get; set; }
    }
}
