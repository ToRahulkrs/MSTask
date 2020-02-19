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
                EmpName="manish Kumar",
                Email="manish.Kumar@gmail.com",
                MobileNumber="9903567843",
                Role="sr manager"
            };
            Data.InserEmployee(Emp);
            var data = Data.GetEmployeeById(Emp.EmpId);
            Assert.AreEqual(Emp, data);
        }
        [TestMethod]
        public void GetEmployeeByIdTest()
        {
            var data = Data.GetEmployeeById(1);
            Assert.IsNotNull(data);
        }

        [TestMethod]
        public void UpdateEmployeeTest()
        {
            Employee Emp = new Employee
            {
                EmpName = "Manish Singh",
                Email="manish.singh@gmail.com"
            };
            Data.UpdateEmployee(3, Emp);
            var data = Data.GetEmployeeById(3);
            Assert.AreEqual(Emp.EmpName, data.EmpName);
        }

        [TestMethod]
        public void DeleteEployeeTest()
        {
            Data.DeleteEmployee(2);
            var data = Data.GetEmployeeById(2);
            Assert.IsNull(data);
        }

    }
}
