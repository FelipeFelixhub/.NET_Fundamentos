using Calculadora.Service;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImp _calc;

    public CalculadoraTestes()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10eRetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;

        // Act
        int resutado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(15, resutado);
    }

     [Fact]
    public void DeveSomar10Com10eRetornar20()
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;

        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        // Arrange
        int numero = 4;

        // Act
        bool resultado = _calc.EhPar(numero);

        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void VerificandoSeOsNumerosSaoParOuImpar(int[] numeros)
    {
        // Act / Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));

    }
}