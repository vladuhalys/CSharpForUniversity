using static System.Console;

namespace CSharpForUniversity
{
    internal class Program
    {
        static void Main()
        {
            bool flag, trigger;
            char sign;
            do
            {
                Clear();
                flag = false;
                try
                {
                    Write("A->");
                    double A = Convert.ToDouble(ReadLine());
                    WriteLine($"z1 = cosA + cos2A + cos6A + cos7A\nz1 = {LinearEquations.Equation_1(A)}\n\n");
                    WriteLine($"z2 = 4 cos A/2 * cos 5/2 * cos4A\nz2 = {LinearEquations.Equation_2(A)}\n\n");
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                }
                finally
                {
                    do
                    {
                        trigger = false;
                        Write("Continue? [Y/N] => ");
                        sign = ReadKey().KeyChar;
                        if (char.ToUpper(sign) == 'N' || char.ToUpper(sign) == 'Y')
                        {
                            trigger = true;
                            if(char.ToUpper(sign) == 'N')
                            {
                                flag = true;
                            }
                        }          
                    } while (trigger != true);
                    
                }
            } while (flag != true);
            
            
        }
    }                             
}