using System.ComponentModel.DataAnnotations.Schema;
using WebApi.Models;

namespace WebApi.Dtos
{
    public class CursoDto
    {
        public int Id { get; set; }
        public string Grado { get; set; }
        public int CantidadDeAlumnos { get; set; }

        public int NivelId { get; set; }
    }
}