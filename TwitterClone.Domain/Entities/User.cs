using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class User
    {
        public Guid Id { get; }

        public string Username { get; set; }

        public string Email { get; set; }

        public User(string username, string email)
        {
            Id = new Guid();
            Username = username;
            Email = email;
        }

    }
}
