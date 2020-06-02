using Deonis_lib.Entities.Base;

namespace Deonis_lib.Entities
{
    /// <summary> Сотрудник </summary>
    public class Employee : Entitie
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string Login { get; set; }

        public string PhoneNubmer { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}
