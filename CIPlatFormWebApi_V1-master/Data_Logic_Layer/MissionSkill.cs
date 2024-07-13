
using Microsoft.EntityFrameworkCore;
using Data_Logic_Layer.Entity;

namespace Authentication.Repository{
    public class MissionSkill : IMissionSkill{

        private readonly AppDbContext _authContext;
        public MissionSkill(AppDbContext authContext){

            _authContext = authContext;
        }

        public async Task<string> CreateMissionSkill(Skill model){

            await _authContext.MissionSkills.AddAsync(model);
            await _authContext.SaveChangesAsync();
            return "Mission skill created successfully.";
            throw new NotImplementedException();
        }

        public async Task<string> DeleteMissionSkill(int id){

            var skill = await _authContext.MissionSkills.FindAsync(id);

            if (skill == null){
                return "Mission skill not found.";
            }
            _authContext.MissionSkills.Remove(skill);
            await _authContext.SaveChangesAsync();
            return "Mission skill deleted successfully.";
        }

        public async Task<List<Skill>> GetMissionSkill(){

            return await _authContext.MissionSkills.ToListAsync();
        }

        public async Task<Skill?> GetMissionSkillById(int SkillId){

            return await _authContext.MissionSkills.FindAsync(SkillId);
        }

        public async Task<string> UpdateMissionSkill(int SkillId, Skill model){

            var existingSkill = await _authContext.MissionSkills.FindAsync(SkillId);

            if (existingSkill == null){
                return "Mission skill not found.";
            }

            existingSkill.SkillName = model.SkillName;
            existingSkill.Status = model.Status;

            _authContext.MissionSkills.Update(existingSkill);
            await _authContext.SaveChangesAsync();
            return "Mission skill updated successfully.";
        }
    }
}
