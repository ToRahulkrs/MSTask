using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestEmployeeProject.Model;
using MSTestEmployeeProject.Services;

namespace MSTestProject
{
    [TestClass]
    public class EmployeeTest
    {
        EmployeeServices Data = new EmployeeServices();
        [TestMethod]
        public void GetAllEmployeeTest()
        {
           var data = Data.GetAllEmployee();
            Assert.IsNotNull(data);
            
        }

        [TestMethod]
        public void InsertEmployeeTest()
        {
            Employee Emp = new Employee
            {
                EmpId=1,
                EmpName="Rahul Kumar",
                Email="Rahul.Kumar@gmail.com",
                MobileNumber="8802133485",
                Role="manager"
            };
            Data.InserEmployee(Emp);


        }


    }
}
