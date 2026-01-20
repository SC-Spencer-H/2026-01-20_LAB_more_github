using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyManagement.Models
{
    internal class Client
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        DateTime CreatedOn { get; set; }
        private bool IsActive { get; set; }

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
