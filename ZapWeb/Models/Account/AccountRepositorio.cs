using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ZapWeb.Lib.Mvc;

namespace ZapWeb.Models
{
    public class AccountRepositorio : Repositorio
    {

        public Account Get(string username)
        {
            var sql = PetaPoco.Sql.Builder.Append("SELECT *")
                                          .Append("FROM Account")
                                          .Append("WHERE UserName = @0", username);

            return this.Db.SingleOrDefault<Account>(sql);
        }

        public Account GetBySession(string session) {
            if (session == null) return null;
            if (session.Length == 0) return null;

            var sql = PetaPoco.Sql.Builder.Append("SELECT *")
                                          .Append("FROM Account")
                                          .Append("JOIN Session ON Session.AccountId = Account.Id")
                                          .Append("WHERE Session.Presence = @0", session);

            return this.Db.SingleOrDefault<Account>(sql);
        }

    }
}