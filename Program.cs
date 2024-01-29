using System;

namespace JustFun
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("===========================\n\tJust_Fun\n===========================");

            Console.Write("Type your nick:  ");
            String nick = Console.ReadLine();
            Console.WriteLine($"W3lc8m3_{nick}!");
            bool sair = true;
            while( sair )
            {
                Console.Beep();
                try
                {
                    Console.WriteLine("Type the next action: (1-show message/2-calculate/3-Store/4-exit)");
                    int resp = Convert.ToInt32( Console.ReadLine() );
                    
                    switch (resp)
                    {
                        case 1:
                            Show();
                            break;
                        case 2:
                            try
                            {
                                Console.Write("How many numbers do you wish to calculate? ");
                                int quant = Convert.ToInt32(Console.ReadLine());
                                double[] valores = new double[quant];
                                Console.WriteLine("How you wish to calculate? (1-sum/2-sub/3-mult/4-div)");
                                int calc = Convert.ToInt32(Console.ReadLine());
                                switch (calc)
                                {
                                    case 1:
                                        Console.WriteLine("\n-----------------------\n\tSUM\n-----------------------\n");
                                        for(int i = 0; i < quant; i++)
                                        {
                                            Console.Write("Type a number for the calc: ");
                                            valores[i] = Convert.ToDouble(Console.ReadLine());
                                        }
                                        Console.WriteLine($"=> Result: {sum(valores)} \n");
                                        break;
                                    case 2:
                                        Console.WriteLine("\n-----------------------\n\tSUB\n-----------------------\n");
                                        for (int i = 0; i < quant; i++)
                                        {
                                            Console.Write("Type a number for the calc: ");
                                            valores[i] = Convert.ToDouble(Console.ReadLine());
                                        }
                                        Console.WriteLine($"=> Result: {minus(valores)} \n");
                                        break;
                                    case 3:
                                        Console.WriteLine("\n-----------------------\n\tMULT\n-----------------------\n");
                                        for (int i = 0; i < quant; i++)
                                        {
                                            Console.Write("Type a number for the calc: ");
                                            valores[i] = Convert.ToDouble(Console.ReadLine());
                                        }
                                        Console.WriteLine($"=> Result: {Mult(valores)}");

                                        break;
                                    case 4:
                                        Console.WriteLine("\n-----------------------\n\tDIV\n-----------------------\n");
                                        Console.WriteLine("WARNING: _division is only two numbers! ");
                                        for(int i = 0; i < 2; i++)
                                        {
                                            Console.Write((i==1)? "Type the other number for the division:" : "Type a number to the division: ");
                                            valores[i] = Convert.ToDouble(Console.ReadLine());
                                        }
                                        Console.WriteLine($"=> Result: {div(valores)}");
                                        break;
                                    default:
                                        Console.WriteLine("Command not found!");
                                        break;
                                }
                            }
                            catch (ArithmeticException e) {
                                Console.WriteLine("type only numbers please!");
                            }
                            catch (FormatException f)
                            {
                                Console.WriteLine("Type only numers please!");
                            }
                            break;
                        case 3:
                            try {
                                Console.Write("\nHow many itens do you wish to store? ");
                                int cont = Convert.ToInt32(Console.ReadLine());
                                String[] names = new string[cont];

                                for(int i = 0; i < cont; i++)
                                {
                                    Console.Write("Digit what you want to store: ");
                                    names[i] = Console.ReadLine();
                                }
                                Store(names);
                            }
                            catch (ArithmeticException e)
                            {
                                Console.WriteLine("Type only numbers please!");
                            }
                            catch (FormatException f)
                            {
                                Console.WriteLine("Type only numbers please!");
                            }
                            break;
                        case 4:
                            sair = false;
                            break;
                        default:
                            Console.WriteLine("Command not found!");
                            break;
                    }
                }
                catch (FormatException f)
                {
                    Console.WriteLine("Type only numers please!");
                }
                catch (ArithmeticException ex) {
                    Console.WriteLine("Type only numers please!");
                }
               

                Console.Write((sair == false) ? "Are you sure? (y/n) ":"Wish to continue? (y/n) ");
                String continuar = Console.ReadLine();
                if (continuar == "n" && sair == true) {
                    Console.WriteLine("___EXITING___");
                    sair = false;
                } else if (continuar == "y" && sair == false) {
                    Console.WriteLine("___EXITING___");
                }
            }

            Console.ReadKey();
        }

        static void Show() {
            Console.WriteLine("\n===========================\n\tH3R3_W3_G8!\n===========================\n");
        }
        
        static double sum(double[] x)
        {
            double result = 0;
            foreach (double d in x)
            {
                result += d;
            }
            return result;
        }
        static double minus(double[] x)
        {
            double conta = 0;
            double[] result = x;
            for(int i = 0; i < x.Length; i++)
            {
                conta -= result[i];
            }
            return conta;
        }
        static double Mult(double[] x)
        {
            double result = 1;
            foreach(double d in x)
            {
                result *= d;
            }
            return result;
        }
        
        static double div(double[] x)
        {
            double result = 0;
            result = x[0] / x[1];
            return result;
        }

        static void Store(String[] names)
        {
            Console.WriteLine("\n-----------------------\n\tST8R3_\n-----------------------\n");
            foreach(String name in names) Console.WriteLine($"=> data_stored: {name}");

            Console.WriteLine();
        }
    }
}