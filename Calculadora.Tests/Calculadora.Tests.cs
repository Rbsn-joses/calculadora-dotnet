using Xunit;

namespace CalculadoraTests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Somar_DeveRetornarASomaDeDoisNumeros()
        {
            // Arrange
            var calculadora = new Calculadora();
            int a = 5;
            int b = 10;

            // Act
            int resultado = calculadora.Somar(a, b);

            // Assert
            Assert.Equal(15, resultado);
        }

        // ... outros testes (subtração, multiplicação, etc.)
    }
}