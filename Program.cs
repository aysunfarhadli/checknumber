using System; // Sistem kitabxanasını əlavə edirik

class Program
{
    static void Main()
    {
        // Ekrana mesaj yazdırırıq
        Console.WriteLine("İki rəqəmli bir ədəd daxil edin:");

        // İstifadəçidən məlumat alırıq və rəqəmə çeviririk
        int eded = Convert.ToInt32(Console.ReadLine());

        // Onluq və təkliq hissələri hesablayırıq
        int onluq = eded / 10;  // Ədədin onluq hissəsini tapırıq
        int tekliq = eded % 10; // Ədədin təkliq hissəsini tapırıq

        // Ədədləri müqayisə edirik
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