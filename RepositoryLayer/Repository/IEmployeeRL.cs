using CommonLayer.RequestModel;
using RepositoryLayer.ContextModel;
using System.Collections.Generic;

namespace RepositoryLayer.Repository
{
    public interface IEmployeeRL
    {
        bool RegisterEmployee(RegisterModel employee);

        bool Delete(int EmpId);

        bool EditEmployee(UpdateModel updatedEmployee, int EmpId);

        List<CompanyEmployee> GetAllEmployee();
    }
}