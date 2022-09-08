using System;
using System.Collections.Generic;
using DapperExercise;

namespace IntroSQL
{
    public interface IDepartmentRepository  // This will sepisfy what this class will need to have 
    {
        public IEnumerable<Department> GetAllDepartments(); //Stubbed out method
    }
}
