using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetcore.Dtos.Character;
using dotnetcore.Models;

namespace dotnetcore.services.characterService
{
  public interface ICharacterService
  {
    Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
    Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
    Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
  }
}