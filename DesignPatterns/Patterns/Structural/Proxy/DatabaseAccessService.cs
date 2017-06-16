using DesignPatterns.Patterns.Structural.Proxy.Interfaces;
using System;

namespace DesignPatterns.Patterns.Structural.Proxy
{
    /// <summary>
    /// The service used to test the database repository proxy.
    /// Users with different access privileges are created and then
    /// used to test the different database operations.
    /// </summary>
    public class DatabaseAccessService
    {
        private IDatabaseRepository _databaseRepositoryProxy;

        public void TestAccess()
        {
            Console.WriteLine("Testing user with no access privileges");
            var userWithNoAccess = new User(false, false);
            _databaseRepositoryProxy = new DatabaseRepositoryProxy(userWithNoAccess);
            TestAllOperations();

            Console.WriteLine("\nTesting user with read access privileges only");
            var userWithReadAccessOnly = new User(true, false);
            _databaseRepositoryProxy = new DatabaseRepositoryProxy(userWithReadAccessOnly);
            TestAllOperations();

            Console.WriteLine("\nTesting user with update access privileges only");
            var userWithUpdateAccessOnly = new User(false, true);
            _databaseRepositoryProxy = new DatabaseRepositoryProxy(userWithUpdateAccessOnly);
            TestAllOperations();

            Console.WriteLine("\nTesting user with read and update access privileges");
            var userWithReadAndUpdateAccess = new User(true, true);
            _databaseRepositoryProxy = new DatabaseRepositoryProxy(userWithReadAndUpdateAccess);
            TestAllOperations();
        }

        private void TestAllOperations()
        {
            _databaseRepositoryProxy.Create();
            _databaseRepositoryProxy.Read();
            _databaseRepositoryProxy.Update();
            _databaseRepositoryProxy.Delete();
        }
    }
}
