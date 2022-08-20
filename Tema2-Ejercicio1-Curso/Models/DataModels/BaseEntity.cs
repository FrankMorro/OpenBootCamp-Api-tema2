using System.ComponentModel.DataAnnotations;
namespace Tema2_Ejercicio1_Curso.Models.DataModels
{
	public class BaseEntity
	{
		[Required]
		[Key]
		public int Id { get; set; }
		public string CreatedBy { get; set; } = string.Empty;
		public DateTime CreatedAt { get; set; } = DateTime.Now;
		public string UpdatedBy { get; set; } = string.Empty;
		public DateTime? UpdatedAt { get; set; }
		public bool IsDeleted { get; set; } = false;
		public string DeletedBy { get; set; } = string.Empty;
		public DateTime? DeletedAt { get; set; }
	}
}
