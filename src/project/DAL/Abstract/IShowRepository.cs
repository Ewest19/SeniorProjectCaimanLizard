using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using WatchParty.Models;

namespace WatchParty.DAL.Abstract;

public interface IShowRepository : IRepository<TopShow>
{
    IEnumerable<TopShow>? GetTopShows(int id);
}