using Microsoft.EntityFrameworkCore;
using ConcesionariaFinal.Aplicacion.Entidades;

namespace ConcesionariaFinal;

public class ConcesionariaFinalContext : DbContext
{

#nullable disable
public DbSet<Titular> Titular { get; set; }
public DbSet<Vehiculo> Vehiculo { get; set; }
public DbSet<Poliza> Poliza { get; set; }
public DbSet<Siniestro> Siniestro { get; set; }
public DbSet<Tercero> Tercero { get; set; }
#nullable restore

protected override void OnConfiguring(DbContextOptionsBuilder
optionsBuilder)
    {
        optionsBuilder.UseSqlite("data source=ConcesionariaFinal.sqlite");
    }
}