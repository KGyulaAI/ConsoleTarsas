namespace ConsoleTarsas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> osvenyek = new List<string>();
            List<int> dobasok = new List<int>();

            StreamReader osvenyReader = new StreamReader("osvenyek.txt");
            while (!osvenyReader.EndOfStream)
            {
                osvenyek.Add(osvenyReader.ReadLine());
            }
            osvenyReader.Close();

            StreamReader dobasokReader = new StreamReader("dobasok.txt");
            while (!dobasokReader.EndOfStream)
            {
                if (Convert.ToString(dobasokReader.Read()) != " ")
                {
                    dobasok.Add(dobasokReader.Read());
                }
            }
            dobasokReader.Close();
            dobasok.RemoveAt(dobasok.Count - 1);

            Console.WriteLine("2. feladat");
            Console.WriteLine($"A dobások száma: {dobasok.Count}");
            Console.WriteLine($"Az ösvények száma: {osvenyek.Count}");

            int leghosszabbSorszam = 0;
            int leghosszabbOsveny = 0;
            for (int i = 0; i < osvenyek.Count; i++)
            {
                if(leghosszabbOsveny < osvenyek[i].Length)
                {
                    leghosszabbSorszam = i + 1;
                    leghosszabbOsveny = osvenyek[i].Length;
                }
            }

            Console.WriteLine("3. feladat");
            Console.WriteLine($"Az egyik leghosszabb a(z) {leghosszabbSorszam}. ösvény, hossza: {leghosszabbOsveny}");

            Console.WriteLine("4. feladat");
            Console.Write("Adja meg az ösvény sorszámát! ");
            int osvenySorszam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg a játékosok számát! ");
            int jatekosokSzama = Convert.ToInt32(Console.ReadLine());
        }
    }
}