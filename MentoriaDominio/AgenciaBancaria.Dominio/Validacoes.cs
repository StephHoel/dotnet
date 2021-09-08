using System;

namespace AgenciaBancaria.Dominio
{
    public static class Validacoes
    {
        public static string ValidaStringVazia (this string texto)
        {
            return String.IsNullOrWhiteSpace(texto) ? throw new Exception("Propriedade deve estar preenchida.") : texto;
        }
    }
}
