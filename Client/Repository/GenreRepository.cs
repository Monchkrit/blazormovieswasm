using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using blazormovieswasm.Client.Helpers;
using blazormovieswasm.Shared.Entities;

namespace blazormovieswasm.Client.Repository
{
  public class GenreRepository : IGenreRepository
  {
    private readonly IHttpService httpService;
    private string url = "api/genres";

    public GenreRepository(IHttpService httpService)
    {
      this.httpService = httpService;
    }

    public async Task<List<Genre>> GetGenres()
    {
      var response = await httpService.Get<List<Genre>>(url);
      if (!response.Success)
      {
        throw new ApplicationException(await response.GetBody());
      }
      return response.Response;
    }

    public async Task CreateGenre(Genre genre)
    {
      var response = await httpService.Post(url, genre);
      if (!response.Success)
      {
        throw new ApplicationException(await response.GetBody());
      }
    }
  }
}