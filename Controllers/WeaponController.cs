using System.Threading.Tasks;
using dotnetcore.Dtos.Character;
using dotnetcore.Dtos.weapon;
using dotnetcore.Models;
using dotnetcore.services.weaponService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore.Controllers
{
  [Authorize]
  [ApiController]
  [Route("[controller]")]
  public class WeaponController : ControllerBase
  {
    private readonly IWeaponService _weaponService;
    public WeaponController(IWeaponService weaponService)
    {
      _weaponService = weaponService;

    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
    {
      return Ok(await _weaponService.AddWeapon(newWeapon));
    }
  }
}