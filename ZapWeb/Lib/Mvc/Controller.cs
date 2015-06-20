using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Pillar.Util;
using ZapWeb.Models;
using Newtonsoft.Json;

namespace ZapWeb.Lib.Mvc
{
    public class Controller : System.Web.Mvc.Controller
    {
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);

            var accountRepositorio = new AccountRepositorio();
            var presence = User.Identity.Name;
            
            Account.Current = new Account();

            if (presence.Length > 0) {
                Account.Current = accountRepositorio.GetBySession(presence);
                Account.Current.CurrentSession = presence;
            }

        }

        public string Success(object data)
        {
            return JsonConvert.SerializeObject(Wrapper.Ok(data));
        }

        public string Error(string message) {
            return JsonConvert.SerializeObject(Wrapper.Error(message));
        }
    }
}