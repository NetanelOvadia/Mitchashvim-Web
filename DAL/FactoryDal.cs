using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class FactoryDal
    {

        static IActivities activities = null;
        public static IActivities GetActivities()
        {
            if (activities == null)
                activities = new XamlActivities();
            return activities;
        }

        static IComments comments = null;
        public static IComments GetComments()
        {
            if (comments == null)
                comments = new XamlComments();
            return comments;
        }

        static IAccessControl accessControl = null;
        public static IAccessControl GetAccessControl()
        {
            if (accessControl == null)
                accessControl = new XamlAccessControl();
            return accessControl;
        }
    }
}
