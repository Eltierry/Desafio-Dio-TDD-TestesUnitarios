using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidacaoCaracteres.Services;

public class Validacoes
{
    public bool SomenteNumeros(string entrada)
    {
        return int.TryParse(entrada, out int resultado);
    }

    public bool SomenteLetras(string entrada)
    {
        foreach (char c in entrada)
        {
            if (!char.IsLetter(c))
            {
                return false;
            }
        };
        return true;
    }

    public bool SomenteLetrasMaiusculas(string entrada)
    {
        foreach (char c in entrada)
        {
            if (!char.IsUpper(c))
            {
                return false;
            }
        };
        return true;
    }

    public bool SomenteLetrasMinusculas(string entrada)
    {
        foreach (char c in entrada)
        {
            if (!char.IsLower(c))
            {
                return false;
            }
        }
        return true;
    }
}
