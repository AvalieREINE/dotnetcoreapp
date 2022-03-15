using AutoMapper;
using dotnetcore.Dtos.Character;
using dotnetcore.Dtos.Fight;
using dotnetcore.Dtos.Skill;
using dotnetcore.Dtos.weapon;
using dotnetcore.Models;

namespace dotnetcore
{
  public class AutoMapperProfile : Profile
  {
    public AutoMapperProfile()
    {
      CreateMap<Character, GetCharacterDto>();
      CreateMap<AddCharacterDto, Character>();
      CreateMap<Weapon, GetWeaponDto>();
      CreateMap<Skill, GetSkillDto>();
      CreateMap<Character, HighScoreDto>();
    }
  }
}