using Resume.DTO.Request;
using Resume.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.DAO.Interface
{
    public interface IProfile
    {
        Task<ResultModel<Profiles>> Get(Guid userId);
        Task<ResultModel<List<Profiles>>> GetAll(Guid userId);
        Task<ResultModel<object>> Save(ProfileRequest profile);
        Task<ResultModel<object>> Update(Guid userId, ProfileRequest profile);
        Task<ResultModel<bool>> Delete(Guid id);

    }
}
