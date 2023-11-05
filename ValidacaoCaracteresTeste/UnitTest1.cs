using ValidacaoCaracteres.Services;

namespace ValicaoCaracteresTeste;

public class UnitTest1
{
    private readonly Validacoes _validacoes = new Validacoes(); 

    [Theory]
    [InlineData("5")] //True
    [InlineData("6")] //True
    [InlineData("85")] //True
    [InlineData("8 5")] //False
    [InlineData("a85")] //False
    [InlineData("85a")] //False
    public void DeveTerSomenteNumeros(string entrada)
    {
        var resultado = _validacoes.SomenteNumeros(entrada);
        Assert.True(resultado);
    }

    [Theory]
    [InlineData("ação1")] //False
    [InlineData("acao1")] //False
    [InlineData("paçoca")] //False
    [InlineData("moça")] //False
    [InlineData("maçã")] //False
    [InlineData("maca")] //True
    [InlineData("Abacate")] //False
    public void DeveTerSomenteLetras(string entrada)
    {
        var resultado = _validacoes.SomenteLetras(entrada);
        Assert.True(resultado);
    }

    [Theory]
    [InlineData("ACAO")] //True
    [InlineData("AÇÃO")] //False
    [InlineData("MAÇÃ")] //False
    [InlineData("CA SA")] //False
    [InlineData("UNIDO")] //True
    public void DeveTerSomenteLetrasMaiusculas(string entrada)
    {
        var resultado = _validacoes.SomenteLetrasMaiusculas(entrada);
        Assert.True(resultado);
    }

    [Theory]
    [InlineData("AÇÂO")] //False
    [InlineData("casa")] //True
    [InlineData("casa1")] //False
    [InlineData("caça")] //False
    [InlineData("macã")] //False
    [InlineData("caça1")] //False
    [InlineData("ca sa")] //False
    public void DeveTerSomenteLetrasMinusculas(string entrada)
    {
        var resultado = _validacoes.SomenteLetrasMinusculas(entrada);
        Assert.True(resultado);
    }
}