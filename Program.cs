namespace Calculator
{
    class Program
    {
        static void Main(String[] args)
        {
            PrintMenu();
            var operationType = GetOperationType();

            var firstValue = GetValue();
            var secondValue = GetValue();

            var result = GetOperationResult(operationType, firstValue, secondValue);

            Console.WriteLine("O resultado da operação é: " + result);
        }

        private static void PrintMenu()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("         MENU        ");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("*********************");
        }

        private static int GetOperationType()
        {
            Console.WriteLine("Escolha uma operação");
            var operationType = Convert.ToInt32(Console.ReadLine());

            while (operationType < 0 || operationType > 4)
            {
                Console.WriteLine("Valor inválido, tente novamente.");
                operationType = Convert.ToInt32(Console.ReadLine());
            }

            return operationType;
        }

        private static float GetOperationResult(int operationType, float firstValue, float secondValue)
            => operationType switch
            {
                1 => Soma(firstValue, secondValue),
                2 => Subtracao(firstValue, secondValue),
                3 => Divisao(firstValue, secondValue),
                4 => Multiplicacao(firstValue, secondValue),
                _ => throw new Exception("Operação não encontrada."),
            };

        private static float GetValue()
        {
            Console.WriteLine("Digite o valor desejado: ");
            return float.Parse(Console.ReadLine());
        }

        private static float Soma(float firstValue, float secondValue)
            => firstValue + secondValue;

        private static float Subtracao(float firstValue, float secondValue)
            => firstValue - secondValue;

        private static float Divisao(float firstValue, float secondValue)
            => firstValue / secondValue;

        private static float Multiplicacao(float firstValue, float secondValue)
            => firstValue * secondValue;
    }
}