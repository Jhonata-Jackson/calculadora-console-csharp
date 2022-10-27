namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool runProgram = true;

            while (runProgram)
            {
                ShowMenu();

                var opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        Console.Clear();

                        Console.WriteLine("=====================");
                        Console.WriteLine("======= Adição ======");
                        Console.WriteLine("=====================");
                        Console.WriteLine();
                        Console.WriteLine("Informe o Primero número: ");
                        float sum1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o Segundo número: ");
                        float sum2 = float.Parse(Console.ReadLine());
                        float resultSoma = Soma(sum1, sum2);

                        Console.Clear();
                        Console.WriteLine($"O resultado da soma é : {resultSoma}");
                        Console.WriteLine();
                        Console.WriteLine("Deseja realizar outra operação?");
                        Console.WriteLine("1) Sim");
                        Console.WriteLine("2) Não");
                        Console.WriteLine();

                        var somaOpt = Console.ReadLine();
                        switch (somaOpt)
                        {
                            case "1": break;
                            case "2":
                                Console.Clear();
                                runProgram = false; break;
                            default: Console.WriteLine("Opção inválida"); break;
                        }

                        break;
                    case "2":
                        Console.Clear();

                        Console.WriteLine("=====================");
                        Console.WriteLine("===== Subtração =====");
                        Console.WriteLine("=====================");
                        Console.WriteLine();
                        Console.WriteLine("Informe o Primero número: ");
                        float sub1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o Segundo número: ");
                        float sub2 = float.Parse(Console.ReadLine());
                        float result = Subtracao(sub1, sub2);

                        Console.Clear();
                        Console.WriteLine($"O resultado da subtração é : {result}");
                        Console.WriteLine();
                        Console.WriteLine("Deseja realizar outra operação?");
                        Console.WriteLine("1) Sim");
                        Console.WriteLine("2) Não");
                        Console.WriteLine();

                        var subOpt = Console.ReadLine();
                        switch (subOpt)
                        {
                            case "1": break;
                            case "2":
                                Console.Clear();
                                runProgram = false; break;
                            default: Console.WriteLine("Opção inválida"); break;
                        }

                        break;
                    case "3":
                        Console.Clear();

                        Console.WriteLine("=====================");
                        Console.WriteLine("=== Multiplicação ===");
                        Console.WriteLine("=====================");
                        Console.WriteLine();
                        Console.WriteLine("Informe o Primero número: ");
                        float mult1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o Segundo número: ");
                        float mult2 = float.Parse(Console.ReadLine());
                        float resultMult = Multiplicacao(mult1, mult2);

                        Console.Clear();
                        Console.WriteLine($"O resultado da multiplicação é : {resultMult}");
                        Console.WriteLine();
                        Console.WriteLine("Deseja realizar outra operação?");
                        Console.WriteLine("1) Sim");
                        Console.WriteLine("2) Não");
                        Console.WriteLine();

                        var multOpt = Console.ReadLine();
                        switch (multOpt)
                        {
                            case "1": break;
                            case "2":
                                Console.Clear();
                                runProgram = false; break;
                            default: Console.WriteLine("Opção inválida"); break;
                        }

                        break;
                    case "4":
                        Console.Clear();

                        Console.WriteLine("=====================");
                        Console.WriteLine("======= Divisão =====");
                        Console.WriteLine("=====================");
                        Console.WriteLine();
                        Console.WriteLine("Informe o Primero número: ");
                        float div1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o Segundo número: ");
                        float div2 = float.Parse(Console.ReadLine());
                        float resultDiv = Divisao(div1, div2);

                        Console.Clear();
                        Console.WriteLine($"O resultado da soma é : {resultDiv}");
                        Console.WriteLine();
                        Console.WriteLine("Deseja realizar outra operação?");
                        Console.WriteLine("1) Sim");
                        Console.WriteLine("2) Não");
                        Console.WriteLine();

                        var divOpt = Console.ReadLine();
                        switch (divOpt)
                        {
                            case "1": break;
                            case "2":
                                Console.Clear();
                                runProgram = false; break;
                            default: Console.WriteLine("Opção inválida"); break;
                        }

                        break;
                    case "5":
                        Console.Clear();
                        runProgram = false;
                        break;
                    default: Console.WriteLine("Opção inválida"); break;
                }
            }

        }

        static void ShowMenu()
        {
            Console.Clear();

            Console.WriteLine("=====================");
            Console.WriteLine("==== Calculadora ====");
            Console.WriteLine("=====================");
            Console.WriteLine();
            Console.WriteLine("Informe a operação desejada: ");
            Console.WriteLine("1) Adição");
            Console.WriteLine("2) Subtração");
            Console.WriteLine("3) Multiplicação");
            Console.WriteLine("4) Divisão");
            Console.WriteLine("5) Sair");
            Console.WriteLine();

        }

        static float Soma(float num1, float num2)
        {
            return num1 + num2;
        }
        static float Subtracao(float num1, float num2)
        {
            return num1 - num2;
        }

        static float Multiplicacao(float num1, float num2)
        {
            return num1 * num2;
        }

        static float Divisao(float num1, float num2)
        {
            return num1 / num2;
        }
    }
}