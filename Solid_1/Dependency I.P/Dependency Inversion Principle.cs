using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_1.Dependency_I.P;

#region before
//class PersonRepository
//{
//    private readonly string _connectionString;
//    private readonly int _connectionTimeout;
//
//    public PersonRepository(string connectionString, int connectionTimeout)
//    {
//        _connectionString = connectionString;
//        _connectionTimeout = connectionTimeout;
//    }
//
//    public void ConnectToDatabase()
//    {
//        //Go away and make a connection to the database. 
//    }
//
//    public void GetAllPeople()
//    {
//        //Use the database connection and then return people. 
//    }
//}
//class MyService
//{
//    private readonly PersonRepository _personRepository;
//
//    public MyService()
//    {
//        _personRepository = new PersonRepository("myConnectionString", 123);
//    }
//}

#endregion

#region After
interface IPersonRepository
{
    void GetAllPeople();
}

class PersonRepository : IPersonRepository
{
    private readonly string _connectionString;
    private readonly int _connectionTimeout;

    public PersonRepository(string connectionString, int connectionTimeout)
    {
        _connectionString = connectionString;
        _connectionTimeout = connectionTimeout;
    }

    private void connectToDatabase()
    {
        //Go away and make a connection to the database. 
    }

    public void GetAllPeople()
    {
        connectToDatabase();
        //Use the database connection and then return people. 
    }
}
class MyService
{
    private readonly IPersonRepository _personRepository;

    public MyService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }
}

#endregion
