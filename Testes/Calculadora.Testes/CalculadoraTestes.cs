using System;
using Xunit;

namespace Calculadora.Testes
{
    public class CalculadoraTestes
    {
        [Fact]
        public void Calculadora_Somar_RetornarTotal()
        {
            //Arrange
            var calculadora = new Calculadora();
            //Act
            var resultado = calculadora.Somar(2, 2);
            //Assert
            Assert.Equal(4, resultado);

        }
    }
}
