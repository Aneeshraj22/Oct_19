using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrderService.Tests
{
    [TestFixture]
    public class EmployeeServiceTest
    {
        [TestCase(16, ExpectedResult = false)]
        [TestCase(60, ExpectedResult = true)]
        [TestCase(36, ExpectedResult = false)]
        [TestCase(76, ExpectedResult = true)]
        public bool GetAge(int age)
        {
            Employee employee = new Employee();
            employee.EmpId = 4004;
            employee.EmpName = "mn";
            employee.Age = age;
            bool ans = employee.IsSenior();
            // Assert.That(ans==true);
            return ans;
        }
    }
}
