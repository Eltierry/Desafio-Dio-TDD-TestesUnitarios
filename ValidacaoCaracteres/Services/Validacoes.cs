using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
        foreach (var c in entrada)
        {
            if (!"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".Contains(c)) 
                return false;  
        } 
        return true;
    }

    public bool SomenteLetrasMaiusculas(string entrada)
    {
        foreach (var c in entrada)
        {
            if (!"ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(c)) 
                return false;  
        } 
        return true;
    }

    public bool SomenteLetrasMinusculas(string entrada)
    {
        foreach (var c in entrada)
        {
            if (!"abcdefghijklmnopqrstuvwxyz".Contains(c)) 
                return false;  
        } 
        return true;
    }
}
