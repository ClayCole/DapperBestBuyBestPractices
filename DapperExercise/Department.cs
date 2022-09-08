using System;
namespace DapperExercise
{
    public class Department
    {
        public Department()  // This is our construcor 
        {
        }
        public int DepartmentID { get; set; }  // these are Properites which reps the columns in the SQL Departments 
        public string name { get; set; }     // you get this from the same columns in the deparments 
    }
}

