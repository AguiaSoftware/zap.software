using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZapWeb.Models
{
    public enum AccountType
    {
        SUPER = 0,
        DEFAULT = 1
    }

    public class Account
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }        
        public bool Ativa { get; set; }
        public AccountType Tipo { get; set; }        

        [PetaPoco.Ignore] public List<Session> Sessions { get; set; }
        [PetaPoco.Ignore] public string CurrentSession { get; set; }
        [PetaPoco.Ignore] public static Account Current { get; set; }
        public bool isAuthenticate { 
            get {

                if (CurrentSession == null) return false;

                return CurrentSession.Length == 0 ? false : true;
            } 
        }
    }
}