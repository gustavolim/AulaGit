using System;

namespace ProgramaVerificaHora
{
    class Program
    {
        static void Main(string[] args)
        {

            // Estrutura Repetitiva enquanto

            int[] horas = null;

            while(horas == null)
            {
                Console.Write("Horas? ");

                string retonoUsuario = Console.ReadLine();

                for (int i = 0; i < retonoUsuario.Length; i++)
                {
                    char verificaValor = (char)retonoUsuario[i];

                    if (char.IsDigit(verificaValor))
                    {
                        int validarHora = int.Parse(char.ConvertFromUtf32(verificaValor));

                        if (horas == null)
                        {
                            if (validarHora == 0 || validarHora == 1 || validarHora == 2)
                            {
                                horas = new int[2];

                                horas[0] = validarHora;
                            }
                            else
                            {
                                Console.WriteLine("valor inválido ");
                                horas = null;
                                break;
                            }
                        }
                        else
                        {
                            horas[1] = validarHora;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Formato inválido");
                        horas = null;
                        break;
                    }
                }

            }

            if (horas != null)
            {
                int horario = Convert.ToInt32(string.Format("{0}{1}", horas[0], horas[1]));

                if (horario <= 12)
                {
                    Console.WriteLine("Dia!");
                }
                else if (horario <= 18)
                {
                    Console.WriteLine("Tarde!");
                }
                else
                {

                    Console.WriteLine("Noite");
                }
            }

            if (horas != null)
            {
                int horario = Convert.ToInt32(string.Format("{0}{1}", horas[0], horas[1]));

                if (horario <= 12)
                {
                    Console.WriteLine("Dia!");
                }
                else if (horario <= 18)
                {
                    Console.WriteLine("Tarde!");
                }
                else
                {

                    Console.WriteLine("Noite");
                }
            }

            Console.ReadLine();
        }
    }
}
