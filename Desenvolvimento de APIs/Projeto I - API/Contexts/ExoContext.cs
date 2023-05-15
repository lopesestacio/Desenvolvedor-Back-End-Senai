using Exo.WebApi.Models;
using Microsoft.EntityFrameworkCore; 
using System.Data.SqlClient; 
using Microsoft.Data.SqlClient;

namespace Exo.WebApi.Contexts 
{ 
    public class ExoContext : DbContext 
    { 
        public ExoContext() 
        { 
        } 

        public ExoContext(DbContextOptions<ExoContext> options) : base(options) 
        { 
        } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        { 
            if (!optionsBuilder.IsConfigured) 
            { 
                // Essa string de conexão depende da SUA máquina. 
                // Exemplo 1 de string de conexão: 
                string connectionString = "User ID=sa;Password=Felipelopes*3;Server=.;Database=ExoApi;Trusted_Connection=False;"; 
                
                optionsBuilder.UseSqlServer(connectionString); 
            } 
        } 

        public DbSet<Projeto> Projetos { get; set; } 
    } 
}
