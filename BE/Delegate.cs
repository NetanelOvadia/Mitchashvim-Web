using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{

    public delegate bool DelegateAccessCheck(int UserId, EClasses eClasses, EActivities eActivities, int ItemId);

    public class Delegate
    {
        DelegateAccessCheck AccessCheck;
    }

    
}
