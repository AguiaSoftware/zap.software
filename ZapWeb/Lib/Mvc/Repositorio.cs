using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZapWeb.Lib.Mvc
{
    public class Repositorio
    {
        public PetaPoco.Database Db { get; set; }

        public Repositorio()
        {
            var ini = new Pillar.Util.IniFile(HttpContext.Current.Server.MapPath("~/App_Data/config.ini"));
            this.Db = new PetaPoco.Database(ini.Read("DataBase", "ConnectionString"), ini.Read("DataBase", "Provider"));
        }
    }


}