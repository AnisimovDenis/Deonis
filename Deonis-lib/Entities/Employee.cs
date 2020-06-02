﻿using Deonis_lib.Entities.Base;

namespace Deonis_lib.Entities
{
    /// <summary> Сотрудник </summary>
    public class Employee : BaseEntitie
    {
        /// <summary> Фамилия сотрудника </summary>
        public string LastName { get; set; }
        /// <summary> Имя сотрудника </summary>
        public string FirstName { get; set; }
        /// <summary> Отчество сотрудника </summary>
        public string MiddleName { get; set; }
        /// <summary> Логин сотрудника </summary>
        public string Login { get; set; }
        /// <summary> Мобильный телефон сотрудника </summary>
        public string PhoneNubmer { get; set; }
        /// <summary> Почта сотрудника </summary>
        public string Email { get; set; }
        /// <summary> Адрес сотрудника </summary>
        public string Address { get; set; }
    }
}
