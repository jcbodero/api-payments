namespace ms_users.Services
{
    public interface IUserService
    {
        string GetUserProfile(int id);
    }

    public class UserService : IUserService
    {
        public string GetUserProfile(int id)
        {
            // Lógica de obtención del perfil de usuario
            return $"Perfil del usuario con ID {id}";
        }
    }
}
