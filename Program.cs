namespace LogicaDeProgramacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region NumericasIntegrais
            // Integral assinado 
            //sbyte num1 = 10; // 8 bits, de -128 a 127
            //short num2 = 20; // 16 bits, de -32.768 a 32.767
            //int num3 = 30; // 32 bits, de -2.147.483.648 a 2.147.483.647
            //long num4 = 40L; // 64 bits, de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            //// A diferença entre os tipos de inteiros assinados e não assinados é que os assinados podem armazenar números negativos

            //// Integral sem sinal
            //byte num5 = 50; // 8 bits, de 0 a 255
            //ushort num6 = 60; // 16 bits, de 0 a 65.535
            //uint num7 = 70; // 32 bits, de 0 a 4.294.967.295
            //ulong num8 = 80L; // 64 bits, de 0 a 18.446.744.073.709.551.615

            //sbyte numero = 100;
            #endregion

            float real1 = 100f;  // 32 bits, intervalo de 1,5 x 10^-45 a 3,4 x 10^38, precisão de 7 dígitos, ex : 123.4567
            double real2 = 100.0; // 64 bits, intervalo de 5,0 x 10^-324 a 1,7 x 10^308, precisão de 15 dígitos, ex : 123.456789012345
            decimal real3 = 100.0m; // 128 bits, intervalo de 1,0 x 10^-28 a 7,9 x 10^28, precisão de 28 dígitos, ex : 123.4567890123456789012345678901   


        }

    } 
}