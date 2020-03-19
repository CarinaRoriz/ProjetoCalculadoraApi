using Xunit;
using Calculadora.Api;

namespace Calculadora.Testes
{
    public class CalculadoraTesteUnitario
    {
        private readonly CalculadoraService _calculadoraService;

        public CalculadoraTesteUnitario()
        {
            _calculadoraService = new CalculadoraService();
        }

        [Fact]
        public void IsSomaCorreta()
        {
            var result = _calculadoraService.Soma(1, 1);

            Assert.Equal(2, result);
        }

        [Fact]
        public void IsSubstracaoCorreta()
        {
            var result = _calculadoraService.Subtracao(10, 1);

            Assert.Equal(9, result);
        }

        [Fact]
        public void IsMultiplicacaoCorreta()
        {
            var result = _calculadoraService.Multiplicacao(10, 5);

            Assert.Equal(50, result);
        }

        [Fact]
        public void IsDivisaoCorreta()
        {
            var result = _calculadoraService.Divisao(100, 10);

            Assert.Equal(9, result);
        }
    }
}