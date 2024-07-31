using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp;

//описваме всяка една песен
public class Song
{
    //характеристики -> плейлист, име, времетраене
    public string ListType { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Time { get; set; } = null!;

    //действие -> описано в метод AddAndListSongs
    //получаваме масив с информация за всяка една песен
    public string AddAndListSongs(string[] songs, string wantedList)
    {
            //songs[] = [
             // "DesiSongs_Rainbow_3:12",
            // "IvanSongs_LoveMe_4.30",
            // "Pop_TryMe_3:40"
            //];
        List<Song> addedSongs = new();

        foreach (string currentSong in songs)
        {
            string[] data = currentSong.Split('_');

            string type = data[0]; //плейлист
            string name = data[1]; //име
            string time = data[2]; //времетраене

            //създаваме песен
            Song song = new()
            {
                ListType = type,
                Name = name,
                Time = time
            };
            //добавяме към списъка с песни
            addedSongs.Add(song);
        }

        //готов списък с всички въведени песни
        //филтрираме и оставяме в списъка само песните от даден плейлист, който е равен на wantedList = "DesiSongs"
        List<Song> filtered = wantedList == "all"
            ? addedSongs
            : addedSongs.Where(s => s.ListType == wantedList).ToList();


        StringBuilder sb = new();
        foreach (Song song in filtered)
        {
            sb.AppendLine(song.Name);
        }

        //текст с имената на песните от даден плейлист, разделени с нов ред
        return sb.ToString().Trim();
    }
}
