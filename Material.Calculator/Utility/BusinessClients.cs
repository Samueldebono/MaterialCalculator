using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Material.Calculator.Utility
{
    public class BusinessClients
    {
        public static Globals GlobalsBusiness
        {
            get
            {
                if (_globalsBusiness == null)
                {
                    _globalsBusiness = new Globals();
                }
                return _globalsBusiness;
            }
        }

        private static Globals _globalsBusiness;
    }
}