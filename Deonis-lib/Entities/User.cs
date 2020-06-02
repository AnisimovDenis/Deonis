using Deonis_lib.Entities.Base;

namespace Deonis_lib.Entities
{
    /// <summary> Пользователь </summary>
    public class User : Entitie
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}
