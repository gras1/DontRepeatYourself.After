using System.Linq;

namespace DontRepeatYourself1
{
    public class User
    {
        public string[] Roles { get; set; }
        public int Id { get; set; }

        public bool IsInRole(string role)
        {
            return Roles.Contains(role);
        }
    }
}