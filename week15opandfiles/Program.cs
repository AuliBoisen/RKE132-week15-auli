
using System.Runtime.CompilerServices;
List<movie>mymovies = new List<movie>();
string[] data = getdatafrommyfiles();
//readdatafromarray(data);

foreach (string line in data)
{
    string[] temparray = line.split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    movie newmovie = new movie(temparray[0], temparray[2]); 
    mymovies.Add(newmovie);
}

foreach (movie movie in mymovies)
{
    Console.WriteLine($"one of my favorite movies {movie.title}"was realeased in {movie.year}.");
}
static string[] getdatafrommyfiles()
{
    string filepath = @"C:\Downloads\movies.txt";
    //string[] datafromfile = File.ReadAllLines(filepath);

    return File.ReadAllLines(filepath);
}

static void readdatafromarray(string[] somearray)
{
    foreach(string line in somearray)
    {
        Console.WriteLine(line);
    }
}

class movie
{
    string title; //fields
    string year;

    public string year
    {
        get { return year; }
    }

    public movie(string _title, string _year)
    {
        title = _title;
        year = _year;

    }
}
