using System;
using System.Data;
using Dapper;
using IntroSQL;

namespace DapperExercise
{
    public class DapperDepartmentRepos : IDepartmentRepository
    {
        private readonly IDbConnection _connection;   // It will get stored here ( the feed of the instance)

        public DapperDepartmentRepos(IDbConnection connection) // << this is where we feed new instance here 
        {
            _connection = connection; 
        }

        // this method returns all the department
        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("Select * From departments;"); // this will put all them all in collection/IEnumerable
        }
    }
}

