namespace Exercicio1.Domain.Tests
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using Bogus;
    using Xunit;

    [ExcludeFromCodeCoverage]
    public class NumeroInteiroTest
    {
        [Fact]
        public void Converter_Numero_ConverterParaRomanoComSucesso()
        {
            //Arrange
            var numero = new Faker().Random.Int(1, 3999);
            var NumeroInteiro = new NumeroInteiro(numero);

            //Act
            NumeroInteiro.ConverterParaRomano(numero);

            //Assert
            Assert.Equal(numero, NumeroInteiro.Numero);

        }

        [Fact]
        public void Converter_Numero_ThrowExceptionEVerificaMensagemComNumerosNegativos()
        {
            //Arrange
            var numero = new Faker().Random.Int(-1000, 0);
            var NumeroInteiro = new NumeroInteiro(numero);

            //Act
            var exception = Assert.Throws<Exception>(() => NumeroInteiro.ConverterParaRomano(numero));

            //Assert
            Assert.Equal("O numero inserido está fora dos limites", exception.Message);

        }

        [Fact]
        public void Converter_Numero_ThrowExceptionEVerificaMensagemComNumerosMaioresQue3999()
        {
            //Arrange
            var numero = new Faker().Random.Int(4000,9000);
            var NumeroInteiro = new NumeroInteiro(numero);

            //Act
            var exception = Assert.Throws<Exception>(() => NumeroInteiro.ConverterParaRomano(numero));

            //Assert
            Assert.Equal("O numero inserido está fora dos limites", exception.Message);

        }
    }
}
