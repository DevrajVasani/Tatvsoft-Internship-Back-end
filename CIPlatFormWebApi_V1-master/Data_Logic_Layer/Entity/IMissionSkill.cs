﻿
namespace Data_Logic_Layer.Entity
{
    public interface IMissionSkill
    {
        Task<List<Skill>> GetMissionSkill();
        Task<string> CreateMissionSkill(Skill model);
        Task<string> UpdateMissionSkill(int SkillId, Skill model);
        Task<Skill> GetMissionSkillById(int SkillId);
        Task<string> DeleteMissionSkill(int id);
    }
}
