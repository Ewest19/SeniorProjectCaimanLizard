namespace WatchParty.Models
{
    public class ProfileVM
    {
        public Watcher Watcher { get; set; }

        public bool isCurrentUser { get; set; }

        public TopGenre? TopGenre { get; set; }
        public TopShow?  TopShow { get; set; }
    }
}
