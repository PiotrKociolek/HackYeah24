using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitLife.Enum;

namespace FitLife.entities
{
    public class User
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Surname {get; set;}
        public  Role Role {get; set;}
        public string Email {get; set;}
        public string PasswordHash { get; set; }
        //public int surveyId {get; set;}
        //passwordHash
        public DateTime JoinDate {get; set;}
        public DateTime LastLoginDate {get; set;}
    }
}