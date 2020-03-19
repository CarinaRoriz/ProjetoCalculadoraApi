using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Calculadora.Api
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        private readonly ILogger<CalculadoraController> _logger;
        
        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        [HttpPost("soma")] 
        public decimal Soma(Valores valores)
        {
            return new CalculadoraService().Soma(valores.Valor1, valores.Valor2);
        }

        [HttpPost("subtracao")]
        public decimal Subtracao(Valores valores)
        {
            return new CalculadoraService().Subtracao(valores.Valor1, valores.Valor2);
        }

        [HttpPost("multiplicacao")]
        public decimal Multiplicacao(Valores valores)
        {
            return new CalculadoraService().Multiplicacao(valores.Valor1, valores.Valor2);
        }

        [HttpPost("divisao")]
        public decimal Divisao(Valores valores)
        {
            return new CalculadoraService().Divisao(valores.Valor1, valores.Valor2);
        }
    }
}
