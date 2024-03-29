﻿namespace ATHHRS.API.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public virtual List<Rent> Rents { get; set; }
    }
}
