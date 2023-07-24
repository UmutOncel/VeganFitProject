﻿using VeganFit.Core.Enums;

namespace VeganFit.Models.DTOs.AdminDtos
{
    public class AdminCreateDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public State State => State.Created;

        public Role Role => Role.Admin;

        public DateTime CreatedDate => DateTime.Now;



        
    }
}
