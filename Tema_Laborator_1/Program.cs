namespace Salariu
{
    class Program
    {
        static void Main()
        {
            int nr_ore = 0;
            double tarif = 0;

            Console.Write("Introduceti tariful: ");
            string tarifCaString = Console.ReadLine();
            double.TryParse(tarifCaString, out tarif);

            Console.Write("Introduceti orele lucrate: ");
            string oreCaString = Console.ReadLine();
            int.TryParse(oreCaString, out nr_ore);

            double salariu = 0;
            salariu = nr_ore * tarif;
            Console.WriteLine($"Salariu: {salariu}");
            if (salariu > 3000)
            {
                Console.WriteLine("Salariu mare");
            }
            else
            {
                Console.WriteLine("„Ati lucrat prea putine ore pentru a avea un salariu mare!");
            }

            Console.ReadKey();
        }
    }
}
