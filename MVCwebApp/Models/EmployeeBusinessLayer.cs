﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCwebApp.DataAccessLayer;

namespace MVCwebApp.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee>GetEmployees()
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();
        }
        public Employee SaveEmployee(Employee e)
        {
            SalesERPDAL salesDal = new SalesERPDAL();
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
            return e;
        }
        public void UploadEmployees(List<Employee> employees)
        {
            SalesERPDAL salesDAL = new SalesERPDAL();
            salesDAL.Employees.AddRange(employees);
            salesDAL.SaveChanges();
        }

    }
}