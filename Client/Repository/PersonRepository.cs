using System;
using System.Threading.Tasks;
using blazormovieswasm.Client.Helpers;
using blazormovieswasm.Shared.Entities;

namespace blazormovieswasm.Client.Repository
{
  public class PersonRepository : IPersonRepository
  {
    private readonly IHttpService httpService;
    private string url = "api/people";

    public PersonRepository(IHttpService httpService)
    {
      this.httpService = httpService;
    }

    public async Task CreatePerson(Person person)
    {
      var response = await httpService.Post(url, person);
      if (!response.Success)
      {
        throw new ApplicationException(await response.GetBody());
      }
    }
  }
}