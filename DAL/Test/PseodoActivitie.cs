using System;
using System.Collections.Generic;
using System.Text;
using BE;

namespace DAL.Test
{
    class PseodoActivitie : IActivities
    {
        public int AddActivity(Activity activity)
        {
            return new Random().Next(100);
        }

        public bool ModifyActivity(int activityId, int nextActivityId)
        {
            return true;
        }

        public IEnumerable<Activity> ViewActivity(Func<Activity, bool> predicate = null, int count = 0, int skip = 0)
        {
            List<Activity> activitiesList = new List<Activity>();

            Activity active1 = new Activity() { Id = 1, MainActivity = 1 };
            Activity active2 = new Activity() { Id = 2, MainActivity = 2 } ;
            Activity active3 = new Activity();
            Activity active4 = new Activity();
            Activity active5 = new Activity();

            activitiesList.Add(active1);
            activitiesList.Add(active2);
            activitiesList.Add(active3);
            activitiesList.Add(active4);
            activitiesList.Add(active5);

            return activitiesList;
        }
    }
}
