using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatar;

namespace ConsoleApp6
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сообщение: ");
            string message = Console.ReadLine();
            Console.Write("Введите слово для поиска: ");
            string searchWord = Console.ReadLine();

            try
            {
                if (message.Contains(searchWord))
                {
                    throw new WordDetectedException($"Обнаружено слово: {searchWord}");
                }
                else
                {
                    Console.WriteLine("Слово не обнаружено.");
                }
            }
            catch (WordDetectedException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"Сообщение: {message}");
            }

            Console.ReadLine();
        }
    }

}

