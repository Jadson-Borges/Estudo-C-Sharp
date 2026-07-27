

namespace Conjunto___StreamReader___Hash.Entities
{
    internal class RegisterLog
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is RegisterLog) )
            {
                return false;
            }
            RegisterLog other = obj as RegisterLog;
            return UserName.Equals(other.UserName);
        }
    }
}
