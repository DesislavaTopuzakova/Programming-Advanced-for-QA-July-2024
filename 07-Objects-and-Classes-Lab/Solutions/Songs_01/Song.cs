//описание на всяка една песен

public class Song
{
    //характеристики -> описват се чрез properties
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }

    //имаме deafult constructor -> създава празен обект от класа -> new Song()

    //конструктор -> създава обект от класа
    public Song(string typeList, string name, string time)
    {
        //нов празен обект
        //TypeList = null
        //Name = null
        //Time = null
        TypeList = typeList;
        Name = name;
        Time = time;
    }

}


