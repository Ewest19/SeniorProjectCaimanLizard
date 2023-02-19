﻿using WatchParty.Models.Concrete;

namespace WatchParty.Services.Abstract
{
	public interface ITMDBService
	{
		void SetCredentials(string apiKey);
		TMDBImageConfig SetImageConfig(string relativePath = "/configuration");
		IEnumerable<TMDBGenre> GetMovieGenres(string relativePath = "/genre/movie/list");
		IEnumerable<TMDBGenre> GetShowGenres(string relativePath = "/genre/tv/list");
		IEnumerable<TMDBTitle> SearchMovies(string movieTitle, string relativePath = "/search/movie?query=");
		IEnumerable<TMDBTitle> SearchShows(string showTitle, string relativePath = "/search/tv?query=");
		IEnumerable<TMDBTitle> SearchTitles(string title, string relativePath = "/search/multi?query=");
		IEnumerable<TMDBPerson> SearchPerson(string personName, string relativePath = "/search/person?query=");
	}
}
