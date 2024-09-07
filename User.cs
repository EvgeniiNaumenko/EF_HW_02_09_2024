using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_004_02_09_2024
{
    internal class User
    {
        public int UserId {  get; set; }
        public string UserLogin {  get; set; }
        public string UserPassword { get; set; }
        public UserSettings Settings { get; set; }
    }
}
