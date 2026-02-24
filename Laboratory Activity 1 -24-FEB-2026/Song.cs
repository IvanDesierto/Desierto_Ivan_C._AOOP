using System.Runtime.CompilerServices;

class Song
{
    public string title;
    public string artist;
    public double duration;

    public Song()
    {
        this.title = "Unknown";
        this.artist = "Unknown";
        this.duration = 0.00; 
    }

    public Song(string title, string artist,  double duration)
    {
        this.title = title;
        this.artist = artist;
        this.duration = duration;
    }

    public Song(string title, string artist)
    {
        this.title = title;
        this.artist = artist;
    }

    public void DisplaySong()
    {
        Console.WriteLine($"{title,-20} {artist,-20} {duration:F2}");
    }

    public static void Main(string[] args)
    {
        Console.Write("Songs to add: ");
        int SongCount = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Song[] playlist = new Song[SongCount];

        for (int i = 0; i < SongCount; i++)
        {
            Console.WriteLine($"Song #{i + 1}");
            Console.Write("Title: ");
            String title = Console.ReadLine();

            Console.Write("Artist: ");
            string artist = Console.ReadLine();

            Console.Write("Duration (minutes): ");
            double duration = double.Parse(Console.ReadLine());

            Console.WriteLine();

            playlist[i] = new Song(title, artist, duration);
        }
        Console.WriteLine();
        Console.WriteLine("=== || MY PLAYLIST || ===");
        Console.WriteLine($"{"Title",-20} {"Artist",-20} {"Time"}");
        Console.WriteLine(new string('-', 50));

        double totalDuration = 0;


        for (int i = 0; i < SongCount; i++)
        {
            playlist[i].DisplaySong();
            totalDuration += playlist[i].duration;
        }

        double averageDuration = totalDuration / SongCount;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Total Duration: {totalDuration:F2} mins");
        Console.WriteLine($"Average Duration: {averageDuration:F2} mins");
    }
}


    
