using BlazorApp1.Data.Model;

namespace BlazorApp1.Data.Service
{
    public class UserService
    {
        private Dictionary<long, User> _users = new Dictionary<long, User>();
        private long _id = 0;

        public void SaveUser(User user)
        {
            _users.Add(_id++, user);
        }
    }
}
