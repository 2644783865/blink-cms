using CnrFairs.DataAccessLayer.EntityFramework;
using CnrFairs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CnrFairs.BussinessLayer.Abstract;

namespace CnrFairs.BussinessLayer
{
    public class EmployeeManager : ManagerBase<Employee>
    {
        private Repository<Employee> repo = new Repository<Employee>();

        public List<Employee> GetEmployees()
        {
            return repo.List();
        }


    }
}
