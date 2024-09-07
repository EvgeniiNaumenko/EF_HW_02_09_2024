using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_004_02_09_2024
{
    internal class UserSettings
    {
        public int SettingsId {  get; set; }
        public string UserName { get; set; }
        public string UserSurname {  get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string UserAddress {  get; set; }
        public User User { get; set; }
    }
}
