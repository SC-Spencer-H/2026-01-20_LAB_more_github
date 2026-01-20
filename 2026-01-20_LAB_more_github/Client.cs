using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManagement.Models
{
    internal class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; private set; }

        public Client(string name, string email)
        {
            Name = name;
            Email = email;

            Id = Guid.NewGuid();
            CreatedOn = DateTime.Now;
            IsActive = true;
        }

        public Client(Guid id, string name, string email, DateTime createdOn, bool isActive)
        {
            Id = id;
            Name = name;
            Email = email;
            CreatedOn = createdOn;
            IsActive = isActive;
        }

        public string GetSummary()
        {
            return $"ID: {Id}\nName: {Name}\nEmail: {Email}\nCreated on: {CreatedOn}\nIs active: {IsActive}";
        }

        public void Deactivate()
        {
            IsActive = false;
        }
    }
}
