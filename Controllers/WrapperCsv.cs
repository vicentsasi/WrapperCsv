using Microsoft.AspNetCore.Mvc;
using practiquesIEI.Wrappers;

namespace WrapperCsv.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WrapperCsv : ControllerBase
    {
        [HttpGet("CsvToJson")]
        public async Task<IActionResult> WrapperCV()
        {
            try
            {
                string csvFileName = "CV.csv";
                string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Fuentes de datos", csvFileName);
                string jsonFromCsv = CsvWrapper.ConvertCsvToJson(csvFilePath);

                return Ok(jsonFromCsv);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error en el wrapper para WrapperCsv: {ex.Message}");
            }
        }
    }
}
