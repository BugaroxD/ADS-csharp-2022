using Models;
using Microsoft.EntityFrameworkCore;
namespace Repository
{
 public class Context : DbContext
 {
 public DbSet<Sala> Salas { get; set; }
 public DbSet<Agendamento> Agendamentos { set; get; }
 public DbSet<Especialidade> Especialidades { set; get; }
 public DbSet<Dentista> Dentistas { set; get; }
 public DbSet<Paciente> Pacientes { set; get; }
 public DbSet<Procedimento> Procedimentos { set; get; }

 protected override void OnConfiguring(DbContextOptionsBuilder options)
 => options.UseMySql("Server=localhost;User Id=root;Database=dentista");
 }
}