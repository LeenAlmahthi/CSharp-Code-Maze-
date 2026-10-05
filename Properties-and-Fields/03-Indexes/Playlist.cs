public class Playlist
{
    private string[] songs = new string[5];
    public Playlist()
    {
        // songs[0]= "test";
    }
    public string  this[int i]
    {
        get 
        {
            if (i >= 0 && i <= 5)
                return songs[i];
            else 
                throw new ArgumentException($"i={i} This index outofbounds");
        }
        set
        {
            
             if (i >= 0 && i <= 5)
                songs[i] = value;
            else 
                throw new ArgumentException($"i={i} This index outofbounds");
        }
    }

}