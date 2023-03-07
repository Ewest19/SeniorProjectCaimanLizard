using WatchParty.DAL.Abstract;
using WatchParty.Models;

namespace WatchParty.DAL.Concrete;

public class ShowRepository : Repository<TopShow>, IShowRepository
{
    public ShowRepository(WatchPartyDbContext ctx) : base(ctx)
    {
    }

    public IEnumerable<TopShow>? GetTopShows(int id)
    {
        IEnumerable<TopShow> topShows = GetAll().Where(w => w.UserId == id);
        return topShows;
    }
}
