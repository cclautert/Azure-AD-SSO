using AzureAD.Core.Entities;
using AzureAD.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureAD.Service
{
    public interface IUserService
    {
        Task<UserProfileModel> GetUserByIdAsync(int userId);
        Task<IEnumerable<UserProfileModel>> GetUsersByFamilyIdAsync(int familyId);
        Task AddUserAsync(UserProfileModel user);
        Task UpdateUserAsync(UserProfileModel user);
        Task DeleteUserAsync(int userId);

        Task<FamilyMemberModel> GetFamilyByIdAsync(int familyId);
        Task<IEnumerable<FamilyModel>> GetAllFamiliesAsync();
        Task AddFamilyAsync(FamilyModel family);
        Task UpdateFamilyAsync(FamilyModel family);
        Task DeleteFamilyAsync(int familyId);
    }

}
