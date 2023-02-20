﻿using WatchParty.DAL.Abstract;
using WatchParty.Models;

namespace WatchParty.DAL.Concrete;

public class WatcherRepository : Repository<Watcher>, IWatcherRepository
{
    public WatcherRepository(WatchPartyDbContext ctx) : base(ctx) 
    {
    }

    public Watcher FindByUsername(string username)
    {
        // Do a try catch or another way to not return null if not found
        return GetAll().Where(w => w.Username == username).FirstOrDefault();
    }
}
