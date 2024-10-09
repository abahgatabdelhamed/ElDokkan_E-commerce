using ELDOKKAN.Application.DTOs.Admin;

namespace ELDOKKAN.Application.Services;
public interface IAdminService
{
    GetAllAdminDTO GetAdminById(int adminId);
    IEnumerable<GetAllAdminDTO> GetAllAdmins();
    CreateAdminDTO AddAdmin(CreateAdminDTO createAdminDTO);
    bool UpdateAdmin(int adminId, UpdateAdminDTO updateAdminDTO);
    bool DeleteAdmin(int adminId);
} 