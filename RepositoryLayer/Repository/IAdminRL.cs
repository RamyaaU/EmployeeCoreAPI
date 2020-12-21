using CommonLayer.RequestModel;
using CommonLayer.ResponseModel;
using System.Collections.Generic;

namespace RepositoryLayer.Repository
{
    public interface IAdminRL
    {
        EmployeeModel AdminLogin(AdminModel login);

        List<EmployeeModel> GetAllEmployee();

        bool RegisterAdmin(RegisterModel admin);
    }
}