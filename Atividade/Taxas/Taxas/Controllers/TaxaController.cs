using Microsoft.AspNetCore.Mvc;
using Taxas.Models;
using Taxas.Services;

namespace Taxas.Controllers
{
    [ApiController]
    public class TaxaController : ControllerBase
    {
        [HttpGet("Brasil/{valor:double}")]
        public IActionResult TaxaBrasil(double valor)
        {
            var valorTaxa = new TaxaService(new BrasilTaxa());
            return Ok(valorTaxa.Service(new ValorTaxa(valor)));
        }
        [HttpGet("EUA/{valor:double}")]
        public IActionResult TaxaEUA(double valor)
        {
            var valorTaxa = new TaxaService(new EUATaxa());
            return Ok(valorTaxa.Service(new ValorTaxa(valor)));
        }
    }
}
