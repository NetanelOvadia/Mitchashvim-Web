using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;
using DAL;

//סיימנו, אולי שייך לעשות כל מני וולידציות?
namespace BL
{
    public class Activities : IActivities
    {
        DAL.IActivities dal;
        public Activities()
        {
            //יש צורך לעשות new?
            dal = FactoryDal.GetActivities();
                /*new DAL.XamlActivities();*/
        }

        /// <summary>
        /// Adding activity 
        /// 1. Add an activity.
        /// 2. If the activity not create so need to update the previouse activity about her next activity (*this).
        /// 3. Return the added activity id. - Changed! no need.
        /// </summary>
        /// <param name="activity">The object of the new activity</param>
        /// <param name="previousActivity">The Id of the previouse activity</param>
        /// <returns></returns>
        public int AddActivity(Activity activity)
        {
            // מקבל את הפעילות האחרונה עבור הפריט ממחלקה מסויימת
            int previousActivity;
            if (activity.MainActivity == (int)EActivities.FirstCreate) //מידה ומוסיפים פריט ראשי כמו משתמש, מוצר וכו' שאין לו עדיין פעילות כלשהי
                previousActivity = 0;
            else //זאת פעילות שנעשית על פריט קיים, שכבר יש לו פעילות כלשהי
                previousActivity = (ViewActivity(i => i.ItemId == activity.ItemId && i.ClassType == activity.ClassType).Max()).ItemId;

            //הוספה של פעילות חדשה וקבלת מספר הסידורי שלה
            int newActivityID = dal.AddActivity(activity);


            //עדכון הפעילות הקודמת, מי בא אחריה
            if (activity.MainActivity != (int)EActivities.Create)
                ModifyActivity(previousActivity, newActivityID);

            return newActivityID;
        }

        /// <summary>
        /// No need to do something, because in the modifing we only change two fields, and this is the dal work.
        /// </summary>
        /// <param name="activityId"></param>
        /// <param name="nextActivityId"></param>
        public bool ModifyActivity(int activityId, int nextActivityId)
        {

            return dal.ModifyActivity(activityId, nextActivityId);
        }

        public IEnumerable<Activity> ViewActivity(Func<Activity, bool> predicate = null, int count = 0, int skip = 0)
        {
            return dal.ViewActivity(predicate, count, skip);
        }
    }
}
