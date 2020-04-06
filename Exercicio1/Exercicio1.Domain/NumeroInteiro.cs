namespace Exercicio1.Domain
{
    using System;

    public class NumeroInteiro
    {

        public int Numero { get; set; }
        
        public NumeroInteiro(int numero)
        {
            Numero = numero;
        }

        public string ConverterParaRomano(int numero)
        {

            if (numero< 0 || numero >3999)
                throw new Exception("O numero inserido está fora dos limites");
            if (numero < 1)
                return "";
            string value = string.Empty;
            if (numero >= 1000)
            {

                return "M" + ConverterParaRomano(numero - 1000);
            }
            if (numero >= 900)
            {
                return "CM" + ConverterParaRomano(numero - 900);
            }
            if (numero > 500)
            {

                return "D" + ConverterParaRomano(numero - 500);
            }
            if (numero >= 400)
            {
                return "CD" + ConverterParaRomano(numero - 400);
            }
            if (numero >= 100)
            {

                return value += "C" + ConverterParaRomano(numero - 100);
            }
            if (numero >= 90)
            {
                return value += "XC" + ConverterParaRomano(numero - 90);
            }
            if (numero >= 50)
            {

                return value += "L" + ConverterParaRomano(numero - 50);
            }
            if (numero >= 40)
            {
                return value += "XL" + ConverterParaRomano(numero - 40);
            }
            if (numero >= 10)
            {

                return value += "X" + ConverterParaRomano(numero - 10);
            }
            if (numero >= 9)
            {

                return value += "IX" + ConverterParaRomano(numero - 9);
            }
            if (numero >= 5)
            {

                return value += "V" + ConverterParaRomano(numero - 5);
            }
            if (numero >= 4)
            {

                return value += "IV" + ConverterParaRomano(numero - 4);
            }
            if (numero >= 1)
            {

                return value += "I" + ConverterParaRomano(numero - 1);
            }
            return string.Empty;
        }
    }
}
