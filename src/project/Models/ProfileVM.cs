namespace WatchParty.Models
{
    public class ProfileVM
    {
        public Watcher Watcher { get; set; }

        public bool isCurrentUser { get; set; }

        public IEnumerable<TopGenre>? TopGenres { get; set; }
        public IEnumerable<TopShow>? TopShows { get; set; }
    }
}
