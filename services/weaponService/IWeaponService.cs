using System.Threading.Tasks;
using dotnetcore.Dtos.Character;
using dotnetcore.Dtos.weapon;
using dotnetcore.Models;

namespace dotnetcore.services.weaponService
{
  public interface IWeaponService
  {
    Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
  }
}