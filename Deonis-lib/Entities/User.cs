using Deonis_lib.Entities.Base;

namespace Deonis_lib.Entities
{
    /// <summary> Пользователь </summary>
    public class User : BaseEntitie
    {
        /// <summary> Логин пользователя </summary>
        public string Login { get; set; }
        /// <summary> Пароль пользователя </summary>
        public string Password { get; set; }
        /// <summary> Роль пользователя </summary>
        public string Role { get; set; }
    }
}
