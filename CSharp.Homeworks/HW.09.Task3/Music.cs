namespace HW._09.Task3;

public class Music : Catalog
{
    private string _singerName;
    private int _lengthOfSongInSeconds;

    public Music(string singerName, int lengthOfSong, string songName, int code, string category, string size)
        : base(songName, code, category, size)
    {
        lengthOfSong *= 60;

        _singerName = singerName;
        _lengthOfSongInSeconds = lengthOfSong;
    }

    public string SingerName
    {
        get { return _singerName; }
    }

    public int LengthOfSongInSeconds
    {
        get { return _lengthOfSongInSeconds; }
    }

    public void Play()
    {
        Console.WriteLine("Song is playing... la-la-la which length in seconds is {0}", _lengthOfSongInSeconds);
    }

    public void Play(params string[] _singerName)
    {
        for (int i = 0; i < _singerName.Length; i++)
        {
            Console.WriteLine("Album is playing... Many songs by {0}.", _singerName[i]);
        }
    }

    public void RetrieveInformation()
    {
        Console.WriteLine("The song '{0}' is by {1}. Genre is {2}. Song lasts {3} in minutes, or {4} seconds.",
            _name, _singerName, _category, _lengthOfSongInSeconds / 60, _lengthOfSongInSeconds);
    }
}