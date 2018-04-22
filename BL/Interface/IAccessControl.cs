using System;
using System.Collections.Generic;
using System.Text;
using BE;

namespace BL
{
    public interface IAccessControl
    {
        bool AccessCheck(int UserId, EClasses eClasses, EActivities eActivities, int ItemId);
    }
}
