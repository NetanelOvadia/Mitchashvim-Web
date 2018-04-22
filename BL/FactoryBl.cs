using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    class FactoryBl
    {  

        static IActivities activities = null;
        public static IActivities GetActivities()
        {
            if (activities == null)
                activities = new Activities();
            return activities;
        }

        static IComments comments = null;
        public static IComments GetComments()
        {
            if (comments == null)
                comments = new Comments();
            return comments;
        }

        static IAccessControl accessControl = null;
        public static IAccessControl GetAccessControl()
        {
            if (accessControl == null)
                accessControl = new AccessControl();
            return accessControl;
        }
    }
}
