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
}