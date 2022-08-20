using Microsoft.EntityFrameworkCore;
using Tema2_Ejercicio1_Curso.Models.DataModels;

namespace Tema2_Ejercicio1_Curso.DataAccess
{
	public class CursoOBDBContext : DbContext
	{
		public CursoOBDBContext(DbContextOptions<CursoOBDBContext> options) : base(options)
		{

		}

		public DbSet<Curso>?Cursos { get; set; }

	}
}
