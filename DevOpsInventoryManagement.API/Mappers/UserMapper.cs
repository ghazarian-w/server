﻿using DevOpsInventoryManagement.API.Models;
using DevOpsInventoryManagement.Domain.Entities;

namespace DevOpsInventoryManagement.API.Mappers
{
    public static class UserMapper
    {
        public static User ToEntity(this UserRegisterFormDTO u)
        {
            return new User()
            {
                Username = u.Username,
                Email = u.Email,
                Password = u.Password,
            };
        }
    }
        
}
