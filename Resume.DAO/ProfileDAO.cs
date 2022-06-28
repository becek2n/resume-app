using Resume.DAO.Interface;
using Resume.Repositories;
using Resume.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Resume.DTO.Request;
using AutoMapper;

namespace Resume.DAO
{
    public class ProfileDAO : IProfile
    {
        private readonly ResumeContext _context;
        private readonly ILogger<ProfileDAO> _logger;
        private readonly IMapper _mapper;
        public ProfileDAO(ResumeContext context, ILogger<ProfileDAO> logger, IMapper mapper) {
            _context = context;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<ResultModel<bool>> Delete(Guid id)
        {
            ResultModel<bool> result = new ResultModel<bool>();
            try
            {
                var profile = _context.Profiles.Find(id);
                if (profile != null)
                {
                    _context.Remove(profile);
                    await _context.SaveChangesAsync();
                    result.SetSuccess("success", true);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error {ex.Message}:");
                result.SetFailed($"Error: {ex.Message}");
            }

            return result;
        }

        public async Task<ResultModel<Profiles>> Get(Guid userId)
        {
            ResultModel<Profiles> result = new ResultModel<Profiles>();
            try
            {
                var profile = await _context.Profiles
                    .Where(x => x.UserId == userId)
                    .Include(x => x.Employments).ThenInclude(x => x.GroupType)
                    .Include(x => x.Educations)
                    .Include(x => x.Courses)
                    .Include(x => x.Socials)
                    .Include(x => x.SkillSets)
                    .Include(x => x.Licences)
                    .Include(x => x.Languages)
                    .SingleOrDefaultAsync();
                result.SetSuccess("success", profile);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error {ex.Message}:");
                result.SetFailed($"Error: {ex.Message}");
            }

            return result;
        }

        public async Task<ResultModel<List<Profiles>>> GetAll(Guid userId)
        {
            ResultModel<List<Profiles>> result = new ResultModel<List<Profiles>>();
            try
            {
                var profiles = await _context.Profiles.Where(x => x.UserId == userId).ToListAsync();
                result.SetSuccess("success", profiles);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error {ex.Message}:", ex);
                result.SetFailed($"Error: {ex.Message}");
                
            }

            return result;
        }

        public async Task<ResultModel<object>> Save(ProfileRequest profile)
        {
            ResultModel<object> result = new ResultModel<object>();
            try
            {
                var entity = _mapper.Map<Profiles>(profile);
                await _context.Profiles.AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error {ex.Message}:");
                result.SetFailed($"Error: {ex.Message}");
            }

            return result;
        }

        public async Task<ResultModel<object>> Update(Guid userId, ProfileRequest profile)
        {
            ResultModel<object> result = new ResultModel<object>();
            try
            {
                var data = await _context.Profiles.Where(x => x.UserId == userId).SingleOrDefaultAsync();
                if (data != null)
                {
                    var entity = _mapper.Map<Profiles>(profile);
                    _context.Profiles.Update(entity);
                    await _context.SaveChangesAsync();
                    result.SetSuccess("success");
                }
                else {
                    result.SetFailed("Data not found!");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error {ex.Message}:");
                result.SetFailed($"Error: {ex.Message}");
            }

            return result;
        }

        
    }
}
