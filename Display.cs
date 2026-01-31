namespace Calculator
{
    internal class Display
    {
        Operation cal = new();
        public int opition;

        public void Start()
        {
            do
            {
                Console.Clear();

                DisplayMenu();
                Console.Write("\nQual operação dejesa realizar: ");
                opition = Convert.ToInt32(Console.ReadLine());

                switch (opition)
                {
                    case 1:
                        cal.Soma();
                        break;
                    case 2:
                        cal.Sub();
                        break;
                    case 3:
                        cal.Div();
                        break;
                    case 4:
                        cal.Mult();
                        break;
                    case 5:
                        cal.Rest();
                        break;
                    case 6:
                        cal.Pow();
                        break;
                    case 0:
                        cal.Exit();
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente!!");
                        break;
                }

                Console.ReadKey();

            } while (opition != 0);
        }
        public void DisplayMenu()
        {
            Console.WriteLine("======Calculadora======\n");
            Console.WriteLine("1. Somar");
            Console.WriteLine("2. Subtrair");
            Console.WriteLine("3. Dividir");
            Console.WriteLine("4. Multiplicar");
            Console.WriteLine("5. Resto da divisão");
            Console.WriteLine("6. Poteciação");
            Console.WriteLine("0. Sair");

        }

    }

}

