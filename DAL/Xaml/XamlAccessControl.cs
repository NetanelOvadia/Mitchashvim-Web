using System;
using System.Collections.Generic;
using System.Text;
using BE;

namespace DAL
{
    class XamlAccessControl : IAccessControl
    {
        public bool AccessCheck(int UserId, EClasses eClasses, EActivities eActivities, int itemId)
        {
            return true;
            throw new NotImplementedException();
        }
    }
}
