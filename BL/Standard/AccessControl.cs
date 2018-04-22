using System;
using System.Collections.Generic;
using System.Text;
using BE;

namespace BL
{
    class AccessControl : IAccessControl
    {
        DAL.IAccessControl accessControl;

        DelegateAccessCheck AccessCheckFunctions = new DelegateAccessCheck(AccessCheck);

        public AccessControl()
        {
            if (accessControl == null)
                accessControl = DAL.FactoryDal.GetAccessControl();
        }

        public bool AccessCheck(int UserId, EClasses eClasses, EActivities eActivities, int itemId)
        {
            return accessControl.AccessCheck(UserId, (EClasses)eClasses, (EActivities)eActivities, itemId);
        }
    }
}
