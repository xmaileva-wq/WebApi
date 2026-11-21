using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Curso
    {
        public int Id { get; set; }
        
        [StringLength(50)]
        public string Grado { get; set; }

        [Range(0, 50)]
        public int CantidadDeAlumnos { get; set; }

        public int? NivelId { get; set; }

        [ForeignKey(nameof(NivelId))]
        public virtual Nivel Nivel { get; set; }
    }
}
