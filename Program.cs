namespace LogicaDeProgramacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Integral assinado 
            sbyte num1 = 10; // 8 bits, de -128 a 127
            short num2 = 20; // 16 bits, de -32.768 a 32.767
            int num3 = 30; // 32 bits, de -2.147.483.648 a 2.147.483.647
            long num4 = 40L; // 64 bits, de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            // A diferença entre os tipos de inteiros assinados e não assinados é que os assinados podem armazenar números negativos
           
            // Integral sem sinal
            byte num5 = 50; // 8 bits, de 0 a 255
            ushort num6 = 60; // 16 bits, de 0 a 65.535
            uint num7 = 70; // 32 bits, de 0 a 4.294.967.295
            ulong num8 = 80L; // 64 bits, de 0 a 18.446.744.073.709.551.615
        }
    } 
}