using System;
using System.Collections.Generic;
using System.Text;
using BE;

namespace DAL
{
    public interface IActivities
    {
        int AddActivity(Activity activity);
        bool ModifyActivity(int activityId, int nextActivityId); //only to change who's after.
        IEnumerable<Activity> ViewActivity(Func<Activity, bool> predicate = null, int count = 0, int skip = 0);
    }
}
