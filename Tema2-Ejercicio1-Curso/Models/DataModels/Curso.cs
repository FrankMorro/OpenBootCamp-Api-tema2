using System.ComponentModel.DataAnnotations;

namespace Tema2_Ejercicio1_Curso.Models.DataModels
{
	public class Curso : BaseEntity
	{
		[Required, StringLength(50)]
		public string Nombre { get; set; } = string.Empty;

		[Required, StringLength(280)]
		public string DescripcionCorta { get; set; } = string.Empty;

		[Required, StringLength(500)]
		public string DescripcionLarga { get; set; } = string.Empty;

		[Required]
		public string PublicoObjetivo { get; set; } = string.Empty;

		[Required]
		public string Objetivos { get; set; } = string.Empty;

		[Required]
		public string Requisitos { get; set; } = string.Empty;

		[Flags]
		public enum Nivel
		{
			Basico,
			Intermedio,
			Avanzado
		}
	}
}
