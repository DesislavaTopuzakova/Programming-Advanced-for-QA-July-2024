//логиката на изпълнение на задачата

//входни данни
int countSongs = int.Parse(Console.ReadLine()); //брой на песните

//лист, в който ще съхранявам песните
List<Song> songsList = new List<Song>();

for (int count = 1; count <= countSongs; count++)
{
    //въвеждам данни за песента
    string data = Console.ReadLine();
    string[] songData = data.Split("_");
    //data = "favourite_DownTown_3:14".Split("_")
    //-> songData = ["favourite", "DownTown", "3:14"]

    string typeList = songData[0]; // "favourite"
    string songName = songData[1]; // "DownTown"
    string time = songData[2];     // "3:14"

    //нова песен с въведените данни
    Song song = new Song(typeList, songName, time);

    //добавяме създадената песен в списъка
    songsList.Add(song);
}

//списък с въведените песни

string typeSongToPrint = Console.ReadLine(); //плейлист или "all"

foreach (Song song in songsList)
{
    if (typeSongToPrint == "all" || typeSongToPrint == song.TypeList)
    {
        Console.WriteLine(song.Name);
    }
}
