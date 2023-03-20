﻿using Microsoft.EntityFrameworkCore;
using WatchParty.DAL.Abstract;
using WatchParty.Models;

namespace WatchParty.DAL.Concrete;
public class FollowingListRepository: Repository<FollowingList>, IFollowingListRepository
{
    public FollowingListRepository(WatchPartyDbContext ctx) : base(ctx)
    {
    }

    public List<FollowingList> GetFollowingList(int id)
    {
        return GetAll().Where(f => f.UserId == id).ToList();
    }

    public List<FollowingList> GetFollowerList(int id)
    {
        return GetAll().Where(f => f.FollowingId == id).ToList();
    }

    public bool IsFollowing(int userId, int followerId)
    {
        return GetAll().FirstOrDefault(f => f.UserId == userId && f.FollowingId == followerId) != null;
    }

    public void AddFollower(FollowingList newFollow)
    {
        try
        {
            AddOrUpdate(newFollow);
        }
        catch
        {
            throw new Exception("Invalid information was given while trying to update database");
        }
    }
}