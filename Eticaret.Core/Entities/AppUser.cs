﻿
namespace Eticaret.Core.Entities
{
    public class AppUser : IEntity
    {
        public int ıd { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string Password { get; set; }
        public string? Username { get; set; } 
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;    
        public Guid? UserGuid { get; set; } = Guid.NewGuid();
    }
}
