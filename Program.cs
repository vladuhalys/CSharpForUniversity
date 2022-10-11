using System.Text;
using static System.Console;
namespace CSharpForUniversity
{
    internal class Program
    {
        /*
        Варіант 6
        У одновимірному масиві з n дійсних елементів обчислити:
        n мінімальний елемент масиву;
        n суму елементів масиву, розташованих між першим і останнім додатними елементами.
        Перетворити масив так, щоб спочатку розташовувалися всі елементи, рівні нулю, а потім - всі останні. 
        */
        static void Main(string[] args)
        {
            OutputEncoding = Encoding.Unicode;
            string? exit = null;
            Random rnd = new Random();
            int[] ? arr = null;
            do
            {
                Clear();
                try
                {
                    
                    Write("Введіть розмір масива: ");
                    ForegroundColor = ConsoleColor.Green;
                    uint size = Convert.ToUInt32(ReadLine());
                    ResetColor();
                    Write("Введіть початок діапазону: ");
                    ForegroundColor = ConsoleColor.Green;
                    int begin = Convert.ToInt32(ReadLine());
                    ResetColor();
                    Write("Введіть кінець діапазону: ");
                    ForegroundColor = ConsoleColor.Green;
                    int end = Convert.ToInt32(ReadLine());
                    ResetColor();
                    arr = new int[size];
                    //Array.Fill(arr, rnd.Next(begin, end));
                   
                    Array.ForEach(arr, (int item) => item = rnd.Next(begin, end));
                    Array.ForEach(arr, (int item) => Write($"{item}\t"));
                }
                catch (Exception ex)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"Помилка: {ex.Message}");
                }
                finally
                {
                    ResetColor();
                    do
                    {
                        Write("Продовжити? [ N / Y ] -> ");
                        ForegroundColor = ConsoleColor.Green;
                        exit = ReadLine()?.ToLower();
                        ResetColor();
                    } while (exit != "n" && exit != "y");
                }
            } while (exit != "n");
            
        }
    }
}