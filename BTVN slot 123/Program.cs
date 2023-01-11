namespace BTVN_slot_123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of song: ");
            int n = int.Parse(Console.ReadLine());
            int count = 1;
            List<Song> songs = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Song number {count++}: ");
                string[] input = Console.ReadLine().Split('_');
                songs.Add(new Song(input[0], input[1], input[2]));
            }
            Console.Write("Enter type list: ");
            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}