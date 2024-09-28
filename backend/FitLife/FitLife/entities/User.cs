using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitLife.entities
{
    public class User
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string SUrname {get; set;}
        public  string Role {get; set;}
        public string Email {get; set;}
        public int surveyId {get; set;}
        //passwordHash
        public DateTime JoinDate {get; set;}
        public DateTime LastLoginDate {get; set;}
    }
}