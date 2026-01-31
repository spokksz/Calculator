namespace Calculator
{
    internal class Operation
    {
        double x, y, soma, sub, div, mult, rest, pow;


        public void Soma()
        {
            x = 0;
            y = 0;
            soma = 0;

            Console.Write("\nDigite o primeiro valor a ser somado: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo valor a ser somado: ");
            y = Convert.ToDouble(Console.ReadLine());

            soma = x + y;

            Console.WriteLine($"\nO valor da soma entre {x} e {y} é de {soma:F3}");
        }

        public void Sub()
        {
            x = 0;
            y = 0;
            sub = 0;

            Console.Write("\nDigite o primeiro valor a ser subtraido: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo valor a ser subtraido: ");
            y = Convert.ToDouble(Console.ReadLine());

            sub = x - y;

            Console.WriteLine($"\nO valor da subtração entre {x} e {y} é de {sub:F3}");
        }

        public void Div()
        {
            x = 0;
            y = 0;
            div = 0;

            Console.Write("\nDigite o valor dividendo: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor divisor: ");
            y = Convert.ToDouble(Console.ReadLine());

            if (y != 0)
            {
                div = x / y;
                Console.WriteLine($"\nO valor da divisão entre {x} e {y} é de {div:F3}");
            }
            else
            {
                Console.WriteLine("\nNão é possível dividir por zero, tente novamente!");
            }
        }

        public void Mult()
        {
            x = 0;
            y = 0;
            mult = 0;

            Console.Write("\nDigite o valor do multiplicando: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor do multiplicador: ");
            y = Convert.ToDouble(Console.ReadLine());

            mult = x * y;

            Console.WriteLine($"\nO valor da soma entre {x} e {y} é de {mult:F3}");
        }

        public void Rest()
        {
            x = 0;
            y = 0;
            rest = 0;

            Console.Write("\nDigite o valor dividendo: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor divisor: ");
            y = Convert.ToDouble(Console.ReadLine());

            if (y != 0)
            {
                rest = x % y;
                Console.WriteLine($"\nO valor da divisão entre {x} e {y} é de {rest:F3}");
            }
            else
            {
                Console.WriteLine("\nNão é possível dividir por zero, tente novamente!");
            }
        }

        public void Pow()
        {
            x = 0;
            y = 0;
            pow = 0;

            Console.Write("\nDigite o valor base: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor do expoente: ");
            y = Convert.ToDouble(Console.ReadLine());

            pow = Math.Pow(x, y);

            Console.WriteLine($"\nO valor da potenciação {x}^{y} é de {pow:F3}");
        }

        public void Exit()
        {
            Console.WriteLine("\nAté mais!");
            Environment.Exit(0);
        }

    }
}