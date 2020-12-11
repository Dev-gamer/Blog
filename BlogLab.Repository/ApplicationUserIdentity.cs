using System.Data;

namespace BlogLab.Repository
{
    public class ApplicationUserIdentity
    {
        public DataRow Username { get; internal set; }
        public object NormalizedUsername { get; internal set; }
        public object Email { get; internal set; }
        public object NormalizedEmail { get; internal set; }
        public object Fullname { get; internal set; }
        public object PasswordHash { get; internal set; }
    }
}