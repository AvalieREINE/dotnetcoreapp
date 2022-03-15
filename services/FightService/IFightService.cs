using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetcore.Dtos.Fight;
using dotnetcore.Models;

namespace dotnetcore.services.FightService
{
  public interface IFightService
  {
    Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
    Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);
    Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
    Task<ServiceResponse<List<HighScoreDto>>> GetHighScore();
  }
}