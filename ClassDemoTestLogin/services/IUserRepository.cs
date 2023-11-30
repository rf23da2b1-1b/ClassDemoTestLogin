using ClassDemoTestLogin.model;

namespace ClassDemoTestLogin.services
{
    public interface IUserRepository
    {
        User? UserLoggedIn { get; }

        void AddUser(User user);
        bool CheckUser(string username, string password);
        void LogoutUser();
        void RemoveUser(User user);
    }
}