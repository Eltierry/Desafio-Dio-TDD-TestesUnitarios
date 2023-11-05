# TDD e testes unitários com C#

## Sobre o projeto
Desafio da DIO referente ao curso "Blindando Seu Código com TDD e Testes Unitários Usando .NET Core", onde a proposta foi aplicar as lições aprendidas para criar testes unitários usando a linguagem C#.
Nesse projeto foi desenvolvido um sistema de validação de caracteres.

## Documentação e fonte de pesquisa
* [Digital Innovation One](https://www.dio.me/) 
* [Microsoft](https://learn.microsoft.com/pt-br/dotnet/core/testing/unit-testing-with-dotnet-test)
* [Stack Overflow](https://pt.stackoverflow.com/questions/25924/como-fazer-a-remo%C3%A7%C3%A3o-de-caracteres-especiais-de-string-em-c)

## Tecnologias utilizadas
### Back end
- C#
### Testes
- Xunit
## Pré-requisitos
[.Net 6.0](https://dotnet.microsoft.com/pt-br/download/dotnet/6.0).


## Criar uma pasta. Por exemplo: Projeto-TDD
```bash
mkdir "Projeto-TDD"
```

## Criar projeto Principal (Dentro da pasta Projeto-TDD)
Programa contendo as validações de caracteres
```Csharp
dotnet new console -n "ValidacaoCaracteres" -f net6.0
```

Abaixo temos uma das funções que será testada.
```CSharp
public bool SomenteLetras(string entrada)
{
    foreach (var c in entrada)
    {
        if (!"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".Contains(c)) 
            return false;  
    } 
    return true;
}
```
## Criar projeto Teste (Dentro da pasta Projeto-TDD)
Programa de teste que injeta dados no prograna "ValidacaoCaracteres" e aguarda os resultados
```Csharp
dotnet new xunit -n "ValidacaoCaracteresTeste" -f net6.0
```

Abaixo temos uma das funções que executa os testes.
```CSharp
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
```

## Adicionar referência do projeto principal ao projeto de testes
Obs.: Deverá executar o comando abaixo dentro da pasta "Projeto-TDD" 
```bash
dotnet add ./ValicaoCaracteresTeste/ValicaoCaracteresTeste.csproj reference ./ValidacaoCaracteres/ValidacaoCaracteres.csproj
```



## Testes a serem executados
Funções dentro de "ValidacaoCaracteres" que serão testadas. Retorndo TRUE, significa o que teste está satisfeito

```CSharp
public bool SomenteNumeros(string entrada)
public void DeveTerSomenteLetras(string entrada)
public void DeveTerSomenteLetrasMaiusculas(string entrada)
public void DeveTerSomenteLetrasMinusculas(string entrada)
```


## Como executar a aplicação
Digitar o comando no terminal:
```
dotnet test
```


## Telas
### Resultado
Caso tenha alguma falha, será exibido no terminal a quantidade de teste(s) com falha(s), aprovado(s) e quantos testes foram executados.
```
Com falha! – Com falha:    17, Aprovado:     8, Ignorado:     0, Total:    25, Duração: 51 ms - ValidacaoCaracteresTeste.dll (net6.0)
```

Caso não haja falha(s) no(s) teste(s), o resultado aparecerá como Aprovado!
```
Aprovado!  – Com falha:     0, Aprovado:     4, Ignorado:     0, Total:     4, Duração: 3 ms - ValidacaoCaracteresTeste.dll (net6.0)
```



## Agradecimentos
[Digital Innovation One](https://www.dio.me/) 

## Contribuição
Os pull requests são bem-vindos. Para mudanças importantes, abra um problema primeiro para discutir o que você gostaria de mudar.
Certifique-se de atualizar os testes conforme apropriado.

## License
[![NPM](https://img.shields.io/npm/l/react)](https://github.com/Eltierry/Desafio-Dio-TDD-TestesUnitarios/blob/main/license)