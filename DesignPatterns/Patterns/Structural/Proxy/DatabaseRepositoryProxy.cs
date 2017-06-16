using DesignPatterns.Patterns.Structural.Proxy.Interfaces;
using System;

namespace DesignPatterns.Patterns.Structural.Proxy
{
    /// <summary>
    /// The proxy for the database repository. Each method
    /// wraps a method on the database repository and performs
    /// an access privilege check before passing through to the
    /// operation on the database repository.
    /// </summary>
    public class DatabaseRepositoryProxy : IDatabaseRepository
    {
        private IDatabaseRepository _databaseRepository;
        private User _user;

        public DatabaseRepositoryProxy(User user)
        {
            _user = user;
            _databaseRepository = new DatabaseRepository();
        }

        public void Create()
        {
            if (_user.HasUpdateAccess)
            {
                _databaseRepository.Create();
            }
            else
            {
                Console.WriteLine("Cannot CREATE: User does not have update privileges");
            }
        }

        public void Read()
        {
            if (_user.HasReadAccess)
            {
                _databaseRepository.Read();
            }
            else
            {
                Console.WriteLine("Cannot READ: User does not have read privileges");
            }
        }

        public void Update()
        {
            if (_user.HasUpdateAccess)
            {
                _databaseRepository.Update();
            }
            else
            {
                Console.WriteLine("Cannot UPDATE: User does not have update privileges");
            }
        }

        public void Delete()
        {
            if (_user.HasUpdateAccess)
            {
                _databaseRepository.Delete();
            }
            else
            {
                Console.WriteLine("Cannot DELETE: User does not have update privileges");
            }
        }
    }
}
