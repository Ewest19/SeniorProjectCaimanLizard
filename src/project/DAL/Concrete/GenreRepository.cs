using WatchParty.DAL.Abstract;
using WatchParty.Models;

namespace WatchParty.DAL.Concrete;

public class GenreRepository : Repository<TopGenre>, IGenreRepository
{
    public GenreRepository(WatchPartyDbContext ctx) : base(ctx)
    {
    }

    public IEnumerable<TopGenre>? GetTopGenres(int id)
    {
        IEnumerable<TopGenre> topGenres = GetAll().Where(w => w.UserId == id);
        return topGenres;
    }
}
