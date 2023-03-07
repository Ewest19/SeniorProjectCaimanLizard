using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using WatchParty.Models;

namespace WatchParty.DAL.Abstract;

public interface IGenreRepository : IRepository<TopGenre>
{
    IEnumerable<TopGenre>? GetTopGenres(int id);
}