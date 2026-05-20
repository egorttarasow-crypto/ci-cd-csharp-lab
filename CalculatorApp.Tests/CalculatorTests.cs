using CalculatorApp;
using Xunit;

namespace CalculatorApp.Tests;

public class CalculatorTests
{
    private readonly Calculator _calc = new();

    [Fact]
    public void Add_ReturnsSum()
    {
        Assert.Equal(15, _calc.Add(10, 5));
        Assert.Equal(0, _calc.Add(-5, 5));
    }

    [Fact]
    public void Subtract_ReturnsDifference()
    {
        Assert.Equal(5, _calc.Subtract(10, 5));
        Assert.Equal(-10, _calc.Subtract(-5, 5));
    }

    [Fact]
    public void Multiply_ReturnsProduct()
    {
        Assert.Equal(50, _calc.Multiply(10, 5));
        Assert.Equal(0, _calc.Multiply(0, 5));
    }

    [Fact]
    public void Divide_ReturnsQuotient()
    {
        Assert.Equal(2, _calc.Divide(10, 5));
        Assert.Equal(2.5, _calc.Divide(5, 2));
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Divide(10, 0));
    }
}