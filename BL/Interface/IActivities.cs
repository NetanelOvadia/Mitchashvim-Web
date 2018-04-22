using System;
using System.Collections.Generic;
using System.Text;
using BE;

namespace BL
{
    public interface IActivities
    {
        //כיון שהביצוע של הוספת פעילות זה כעין רשימה מקושרת חד כיוונית (שאני יכול להגיע מהראש לכל השאר)
        //אז אין סיבה שאני אחזיר בשלב זה ערך לשכבה אחורה כיון שהעדכון מתבצע בשכבה זו
        int AddActivity(Activity activity); 
        bool ModifyActivity(int activityId, int nextActivityId); //only to change who's after.
        IEnumerable<Activity> ViewActivity(Func<Activity, bool> predicate = null, int count = 0, int skip = 0);
    }
}
