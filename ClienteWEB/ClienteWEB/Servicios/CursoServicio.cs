using ClienteWEB.Models;

namespace ClienteWEB.Servicios
{
    public class CursoServicio
    {
        private readonly HttpClient _httpClient;

        private readonly string Ruta = "api/Cursos";

        public CursoServicio(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CursoDto>> ObtenerCursos()
        {
            var resultado = await _httpClient.GetFromJsonAsync<List<CursoDto>>(Ruta);
            if (resultado == null)
            {
                return new List<CursoDto>();
            }

            return resultado.ToList();

        }
    }
}
