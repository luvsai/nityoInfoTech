using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Office.Models;
using System.Collections;
namespace Office.Controllers
{
    public class apiController : Controller
    {
        public api[] Employees;

        //Contructor for initializing the employee details
        public apiController()
        {
            //Initializing the user details
            Employees = new api[5];
            Employees[0] = new api() { EmployeeId = 1, EmployeeName = "Mukesh Kumar", Address = "New Delhi", Department = "IT" };
            Employees[1] = new api() { EmployeeId = 2, EmployeeName = "Banky Chamber", Address = "London", Department = "HR" };
            Employees[2] = new api() { EmployeeId = 3, EmployeeName = "Rahul Rathor", Address = "Laxmi Nagar", Department = "IT" };
            Employees[3] = new api() { EmployeeId = 4, EmployeeName = "YaduVeer Singh", Address = "Goa", Department = "Sales" };
            Employees[4] = new api() { EmployeeId = 5, EmployeeName = "Manish Sharma", Address = "New Delhi", Department = "HR" };


        }

        //function GetALLEmployee
        public  ArrayList GetAllEmployees()
        {

            int listlen = Employees.Length;

            ArrayList employeeList = new ArrayList();
            int index;

            for ( index = 0; index < listlen; index++) {
                employeeList.Add(
                    new
                    {
                        EmployeeId = Employees[index].EmployeeId,
                        EmployeeName = Employees[index].EmployeeName,
                        Address = Employees[index].Address,
                        Department = Employees[index].Department
                    });
            }

            return employeeList;
        }

        public ArrayList GetEmployeeDetails(int Employeeid)
        {
            int listlen = Employees.Length;
            ArrayList employeeDetails = new ArrayList();
            if (Employeeid < listlen && Employeeid >= 0)
            {


                
                employeeDetails.Add(new
                {
                    EmployeeId = Employees[Employeeid].EmployeeId,
                    EmployeeName = Employees[Employeeid].EmployeeName,
                    Address = Employees[Employeeid].Address,
                    Department = Employees[Employeeid].Department
                });


                

            }
            return employeeDetails;
        }


        // GET: api/employee http://localhost:port/api/employee.

        public ActionResult employee(int id=-1)
        {
            // GET: api/employee http://localhost:port/api/employee.
            if (id == -1)
            {
                ArrayList employeeList  = GetAllEmployees();
                return Json( employeeList, JsonRequestBehavior.AllowGet);
            }

            // GET: api/employee/4 http://localhost:port/api/employee/4.
            try
            {

                ArrayList employeeDetails = GetEmployeeDetails(id - 1);
                return Json(employeeDetails, JsonRequestBehavior.AllowGet);


            }
            catch (Exception e) {
                return   Content("Request can't be Served");


            }
        }

         

    }
}