using System.Data;
using System.Diagnostics.Metrics;
using System.Xml;
public class HW_3
{
    public static void Main()
    {
    //Task 6
    again:
        try
        {
            Console.Write("Please,enter a number which is not less than 1 = ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            if (num1 < 1) { throw new ArgumentNullException("number shuld be not less than 1"); }
            Console.Write("Please,enter a number which is more than previous one = ");
            double num2 = Convert.ToDouble(Console.ReadLine());        
            if (num1 > num2) { throw new ApplicationException("first number must be less than second"); }
            Console.WriteLine("{0} / {1} = {2}", num1, num2, Div(num1, num2));
        }

        catch (ArgumentNullException exception)
        {
            Console.WriteLine(exception.Message);
            goto again;
        }
        catch (ApplicationException exception)
        {
            Console.WriteLine(exception.Message);
            goto again;
        }
        finally
        {
            Console.WriteLine("Great!");
        }
        Console.ReadKey();

    }
    
    public static double Div(double num1, double num2)
    {
        return num1 / num2;
    }
}
