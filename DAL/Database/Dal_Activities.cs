using System;
using System.Collections.Generic;
using System.Text;
using BE;

namespace DAL
{
    public class Dal_Activities : IActivities
    {
        public int AddActivity(Activity activity)
        {
            throw new NotImplementedException();
        }

        public bool ModifyActivity(int activityId, int nextActivityId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Activity> ViewActivity(Func<Activity, bool> predicate = null, int count = 0, int skip = 0)
        {
            throw new NotImplementedException();
        }
    }
}
