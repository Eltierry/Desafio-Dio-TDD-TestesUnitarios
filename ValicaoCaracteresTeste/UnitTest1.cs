using ValidacaoCaracteres.Services;

namespace ValicaoCaracteresTeste;

public class UnitTest1
{
    private readonly Validacoes _validacoes = new Validacoes(); 


    //[Theory]
    [InlineData("5")]
    [InlineData("6")]
    [InlineData("85")]
    public void DeveTerSomenteNumeros(string entrada)
    {
        var resultado = _validacoes.SomenteNumeros(entrada);
        Assert.True(resultado);
    }

    //[Theory]
    [InlineData("ação1")]
    [InlineData("moça")]
    [InlineData("maçã")]
    public void DeveTerSomenteLetras(string entrada)
    {
        var resultado = _validacoes.SomenteLetras(entrada);
        Assert.True(resultado);
    }

    [Theory]
    [InlineData("AÇÂO")]
    [InlineData("Casa")]
    [InlineData("UNIDO")]
    public void DeveTerSomenteLetrasMaiusculas(string entrada)
    {
        var resultado = _validacoes.SomenteLetrasMaiusculas(entrada);
        Assert.True(resultado);
    }

    //[Theory]
    [InlineData("AÇÂO")]
    [InlineData("casa")]
    [InlineData("caça1")]
    public void DeveTerSomenteLetrasMinusculas(string entrada)
    {
        var resultado = _validacoes.SomenteLetrasMinusculas(entrada);
        Assert.True(resultado);
    }
}