namespace HW._09.Task3;

public class Films : Catalog
{
    private string _directorName;
    private string _mainActorName;
    private string _mainActressName;

    public Films(string directorName, string mainActorName, string mainActressName, string filmName, int code,
        string category, string size)
        : base(filmName, code, category, size)
    {
        _directorName = directorName;
        _mainActorName = mainActorName;
        _mainActressName = mainActressName;
    }

    public void Play()
    {
    }

    public void Play(params string[] filmsName)
    {
    }

    public void RetrieveInformation()
    {
        Console.WriteLine("This {0} '{1}' directed by {2}. Main actress is {3} and actor - {4}. " +
                          "TvShow has {5} seasons with 15 episodes in each in average.",
            _category, _name, _directorName, _mainActressName, _mainActorName, _size);
    }
}