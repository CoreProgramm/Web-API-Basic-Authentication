using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicAuthenticationWebAPI.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public string DeptName { get; set; }
    }
    public class Employees : List<Employee>
    {
        public Employees()
        {
            Add(new Employee() { EmpNo = 101, EmpName = "John", Salary = 12000, DeptName = "IT" });
            Add(new Employee() { EmpNo = 102, EmpName = "Tom", Salary = 22000, DeptName = "System" });
            Add(new Employee() { EmpNo = 103, EmpName = "Smith", Salary = 21000, DeptName = "Sales" });
            Add(new Employee() { EmpNo = 104, EmpName = "Lora", Salary = 32000, DeptName = "HRD" });
            Add(new Employee() { EmpNo = 105, EmpName = "Jodie", Salary = 42000, DeptName = "HRD" });
            Add(new Employee() { EmpNo = 106, EmpName = "Wonda", Salary = 12000, DeptName = "Admin" });
        }
    }
}