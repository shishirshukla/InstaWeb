using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaWeb.Data
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public string TimeZone { get; set; }
        public DateTime JoinedDate { get; set; }
        public DateTime PlanStartDate { get; set; }
        public string PlanName { get; set; }
        public List<Setting> Settings { get; set; }
        public List<InstaAccount> InstaAccounts { get; set; }
    }
    public class InstaAccount
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string InstaId { get; set; }
        public string InstaPassword { get; set; }
        public string Proxy { get; set; }
    }
    public class Setting
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }

    }
    public class InstaLog
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int InstaAccountId { get; set; }
        public DateTime Time { get; set; }
        public string Task { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}
