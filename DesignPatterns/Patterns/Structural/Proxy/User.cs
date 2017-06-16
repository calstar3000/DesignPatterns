
namespace DesignPatterns.Patterns.Structural.Proxy
{
    /// <summary>
    /// Simulates a user with different access privileges
    /// </summary>
    public class User
    {
        private bool _hasReadAccess;
        private bool _hasUpdateAccess;

        public User(bool hasReadAccess, bool hasUpdateAccess)
        {
            _hasReadAccess = hasReadAccess;
            _hasUpdateAccess = hasUpdateAccess;
        }

        public bool HasReadAccess
        {
            get { return _hasReadAccess; }
        }

        public bool HasUpdateAccess
        {
            get { return _hasUpdateAccess; }
        }
    }
}
