
using System.Text;

namespace CSharpForUniversity
{
    internal class Program
    {
        /*
        Варіант 6
        Скласти опис класу для вектора, заданого координатами його кінців в тривимірному просторі. 
        Забезпечити операції складання і віднімання векторів з отриманням нового вектора (суми або різниці), 
        обчислення скалярного твору двох векторів, довжини вектора, косинуса кута між векторами.
        Написати програму, що демонструє всі розроблені елементи класу
        */

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Random random = new Random();
            var vector1 = new Vector3D(random.Next(-10,10), random.Next(-10, 10), random.Next(-10, 10));
            var vector2 = new Vector3D(random.Next(-10, 10), random.Next(-10, 10), random.Next(-10, 10));
            Console.WriteLine($"Перший вектор = {vector1}\t Другий вектор = {vector2}\n");
            Console.WriteLine($"Сума векторів: {vector1} + {vector2} = {vector1+vector2}");
            Console.WriteLine($"Різність векторів: {vector1} - {vector2} = {vector1 - vector2}");
            Console.WriteLine($"Скалярний добуток векторів: {vector1} * {vector2} = {vector1 * vector2}");
            Console.WriteLine($"Довжини векторів: {vector1} = {vector1.Length()} : {vector2} = {vector2.Length()}");
            Console.WriteLine($"Косинуса кута між векторами: {vector1} ^ {vector2} = {vector1 ^ vector2}");
        }
    }
}