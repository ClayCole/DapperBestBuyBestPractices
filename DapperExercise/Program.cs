using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Dapper;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using DapperExercise;
//^^^^MUST HAVE USING DIRECTIVES^^^^

var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
string connString = config.GetConnectionString("DefaultConnection");

IDbConnection conn = new MySqlConnection(connString);

var repo = new DapperDepartmentRepos(conn);

var Departments = repo.GetAllDepartments();

foreach (var dept in Departments)
{
    Console.WriteLine($"{dept.DepartmentID} {dept.name}");
}

var repo2 = new DapperProductRepos(conn);
Console.WriteLine("what is the name of your product?");
var prodName = Console.ReadLine();

Console.WriteLine($"what is the price of {prodName} ? ");
var prodPrice = double.Parse(Console.ReadLine());

Console.WriteLine("What is the Catergoty ID ?");
var prodCat = int.Parse(Console.ReadLine());


repo2.CreateProduct(prodName, prodPrice, prodCat);

var prodList = repo2.GetAllProducts();

foreach (var prod in prodList)
{
    Console.WriteLine($"{prod.ProductID} - {prod.Name}");
}