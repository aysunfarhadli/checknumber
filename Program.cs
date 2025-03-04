using System; 
class Program
{
    static void Main()
    {
        Console.WriteLine("İkirəqəmli bir ədəd daxil edin");

        int eded = Convert.ToInt32(Console.ReadLine());

        int onluq = eded / 10;  
        int tekliq = eded % 10; 

        if (onluq > tekliq)
        {
            Console.WriteLine("Onluq hissə böyükdür.");
        }
        else if (tekliq > onluq)
        {
            Console.WriteLine("Təkliq hissə böyükdür.");
        }
        else
        {
            Console.WriteLine("Onluq və təkliq hissə bərabərdir.");
        }
    }
}
