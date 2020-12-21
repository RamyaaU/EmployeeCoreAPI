using CommonLayer.RequestModel;
using RepositoryLayer.ContextModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.IServices
{
    public interface IEmployeeBL
    {
        bool Delete(int EmpId);

        bool EditEmployee(UpdateModel updatedEmployee, int EmpId);

        List<CompanyEmployee> GetAllEmployee();

        bool RegisterEmployee(RegisterModel employee);
    }
}
