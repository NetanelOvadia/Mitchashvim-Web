using System;
using System.Collections.Generic;
using System.Text;
using BE;

namespace BL
{
    class Comments : IComments
    {

        DAL.IComments dal;
        public Comments()
        {
            dal = DAL.FactoryDal.GetComments();
                //new DAL.XamlComments();
        }

        //בהוספת תגובה צריך לעדכן את הפעילות האחרונה ביחס למחלקה 
        //למשל, כאשר יש לי מוצר מסויים, ואני מגיב עליו אז הפעילות נשמרת ביחס לפעילות של כל מה שקשור למוצר
        //ואם כן אז כאשר אני רוצה להוסיף תגובה, ובתגובה אני צריך לעדכן פעילות, אז אני 
        public int AddComment(Comment comment, int currentUser)
        {
            bool AccessStatus = BL.FactoryBl.GetAccessControl().AccessCheck(currentUser, (EClasses)comment.ClassType, EActivities.Create, comment.ItemId);
            int commentId = -1;//default of access denied.
            if (AccessStatus)
            {
                Activity tmp = new Activity
                {
                    ClassType = (int)comment.ClassType,
                    MainActivity = (int)EActivities.Create,
                    ItemId = comment.Id,
                    Time = DateTime.Now,
                    UserID = currentUser
                };

                int activityId = FactoryBl.GetActivities().AddActivity(tmp);


                comment.Activity = activityId;

                commentId = dal.AddComment(comment);
            }

            return commentId;

        }
        
        //צריך לחשוב איך לנהל את הפעילות נכון, שהרי עבור כל תגובה אם אני ארצה לראות שינוי אצטרך להכנס לתוך
        //התגובה ואז לראות אם קרה שם משהו.
        //אבל אולי שייך באופן כללי לקשר את כל הפעילות לראש של התגובה
        //או לקשר את כל הפעילות שקשורה למשל למוצר מסויים במוצר עצמו בלי קשר אם התבצעה פעילות
        //בתגובה או ברכיב אלר כלשהו
        //אולי למשל כאשר נוצר למשל מוצר חדש אז יחד איתו ישנה את הפעילות הראשונה שזה יצירת המוצר
        //ומהפעילות הזאת לקשר את הכל
        //ואז זה אומר שאני צריך לשלוח פרמטר את מספר הפעילות האחרון של הרכיב.
        //וכל זה יתן מענה מה קורה כאשר אני רוצה למחוק, לאן הפעילות על אותה תגובה תמשיך?
        public void ModifyComment(Comment comment,int currentUser)
        {

            bool AccessStatus = BL.FactoryBl.GetAccessControl().AccessCheck(currentUser, (EClasses)comment.ClassType, EActivities.Modify, comment.ItemId);

            if (AccessStatus)
            {
                Activity tmp = new Activity
                {
                    ClassType = (int)comment.ClassType,
                    MainActivity = (int)EActivities.Modify,
                    ItemId = comment.Id,
                    Time = DateTime.Now,
                    PreviouseRelated = comment.Activity,
                    UserID = currentUser
                };

                int activityId = FactoryBl.GetActivities().AddActivity(tmp);

                comment.Activity = activityId;

                dal.AddComment(comment);

            }
        }

        public void RemoveComment(int commentId, currentUser, )
        {
            bool AccessStatus = BL.FactoryBl.GetAccessControl().AccessCheck(currentUser, (EClasses)comment.ClassType, EActivities.Create, comment.ItemId);

            throw new NotImplementedException();
        }

        public IEnumerable<Comment> ViewComment(Func<Comment, bool> predicate = null, int count = 0, int skip = 0)
        {
            return dal.ViewComment(predicate, count, skip);
        }
    }
}
