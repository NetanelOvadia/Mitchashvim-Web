using System;
using System.Collections.Generic;
using System.Text;
using BE;
using DAL;

namespace BL
{
    class BL_Imp
    {
        IDal dal;
        public BL_Imp()
        {
            dal = null;
        }

        #region Adding classes.
        /// <summary>
        /// Adding activity 
        /// 1. Add an activity.
        /// 2. If the activity not create so need to update the previouse activity about her next activity (*this).
        /// 3. Return the added activity id.
        /// </summary>
        /// <param name="activity"></param>
        /// <returns></returns>
        public int AddActivity(Activity activity)
        {
            int newActivityID = dal.AddActivity(activity);

            if (activity.MainActivity != (int)EActivities.Create)
                dal.ModifyActivity(activity.PreviouseRelated, newActivityID);

            return newActivityID;
        }

        /// <summary>
        /// Add comment
        /// 1. Create a new activity and getting its id.
        /// 2. Updating the comment object the activity id.
        /// 3. Add a comment.
        /// 4. Return the id of the new added comment.
        /// </summary>
        /// <param name="comment"></param>
        /// <param name="classes"></param>
        /// <param name="ItemId"></param>
        /// <returns></returns>
        public int AddComment(Comment comment, EClasses classes, int ItemId)
        {
            Activity tmp = new Activity
            {
                ClassType = (int)classes,
                MainActivity = (int)EActivities.Create,
                ItemId = comment.Id,
                Time = DateTime.Now,
                //PreviouseRelated = comment.Activity//למה זה? ברגע שאני מוסיף תגובה אין אף אחד לפני
                
            };

            int activityId = dal.AddActivity(tmp);

            comment.Activity = activityId;

            int commentId = dal.AddComment(comment);

            return commentId;

        }

        /// <summary>
        /// Add Manufacturer - יצרן
        /// 1. Create a new activity and getting its id.
        /// 2. Updating to the manufacturer object the activity id.
        /// 3. Add manufacturer.
        /// 4. Return the id of the new added manufacturer.
        /// </summary>
        /// <param name="manufacturer"></param>
        /// <returns></returns>
        public int AddManufacturer(Manufacturer manufacturer)
        {
            Activity tmp = new Activity()
            {
                ClassType = (int)EClasses.Manufacturer,
                MainActivity = (int)EActivities.Create,
                ItemId = manufacturer.Id,
                Time = DateTime.Now,
            };

            int ActivityId = AddActivity(tmp);

            manufacturer.Activity = ActivityId;

            int ManufacturerId = dal.AddManufacturer(manufacturer);

            return ManufacturerId;
        }

        /// <summary>
        /// Add Product_Food - מוצר מסוג מזון
        /// 1. Create a new activity and getting its id.
        /// 2. Updating to the manufacturer object the activity id.
        /// 3. Add Product_Food.
        /// 4. Return the id of the new added product food.
        /// </summary>
        /// <param name="product_Food"></param>
        /// <returns></returns>
        public int AddProduct_Food(Product_Food product_Food)
        {

            Activity tmp = new Activity()
            {
                ClassType = (int)EClasses.Product,
                MainActivity = (int)EActivities.Create,
                ItemId = product_Food.Id,
                Time = DateTime.Now,
            };

            int ActivityId = AddActivity(tmp);

            product_Food.Activity = ActivityId;

            int pdoductFoodId = dal.AddProduct_Food(product_Food);

            return pdoductFoodId;
        }

        /// <summary>
        /// Add Setting
        /// 1. Create new activity object with the relevant values.
        /// 2. Add activity.
        /// 3. Update the setting->Activity
        /// 4. Add Setting.
        /// 5. Return setting Id.
        /// </summary>
        /// <param name="setting"></param>
        /// <returns></returns>
        public int AddSetting(Setting setting)
        {
            Activity tmp = new Activity()
            {
                ClassType = (int)EClasses.Setting,
                MainActivity = (int)EActivities.Create,
                ItemId = setting.Id,
                Time = DateTime.Now,
            };

            int ActivityId = dal.AddActivity(tmp);

            setting.Activity = ActivityId;

            int SettingId = AddSetting(setting);

            return SettingId;
        }

        /// <summary>
        /// Add user
        /// 1. Create new activity object with the relevant values.
        /// 2. Add the activity.
        /// 3. Update the User->Activity
        /// 4. Add User.
        /// 5. Return the user Id.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int AddUser(User user)
        {

            Activity tmp = new Activity()
            {
                ClassType = (int)EClasses.User,
                MainActivity = (int)EActivities.Create,
                ItemId = user.Id,
                Time = DateTime.Now,
            };

            int ActivityId = AddActivity(tmp);

            user.Activity = ActivityId;

            int UserId = dal.AddUser(user);

            return UserId;
        }
        #endregion

        /// <summary>
        /// No need to do something, because in the modifing we only change two fields, and this is the dal work.
        /// </summary>
        /// <param name="activityId"></param>
        /// <param name="nextActivityId"></param>
        public void ModifyActivity(int activityId, int nextActivityId)
        {
            dal.ModifyActivity(activityId, nextActivityId);
        }

        public void ModifyComment(Comment comment)
        {
            //Comment previouseComment = dal.ViewComment(x => x.Id == comment.Id);

            throw new NotImplementedException();
        }

        public void ModifyManufacturer(Manufacturer manufacturer)
        {
            throw new NotImplementedException();
        }

        public void ModifyProduct_Food(Product_Food product_Food)
        {
            throw new NotImplementedException();
        }

        public bool ModifySetting(Setting setting)
        {
            throw new NotImplementedException();
        }
        public void ModifyUser(User user)
        {
            throw new NotImplementedException();
        }

        public void RemoveComment(int commentId)
        {
            throw new NotImplementedException();
        }

        public void RemoveManufacturer(int manufacturerId)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct_Food(int product_FoodId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveSetting(Setting setting)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Activity> ViewActivity(Func<Activity, bool> predicate = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> ViewComment(Func<Comment, bool> predicate = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Manufacturer> ViewManufacturer(Func<Manufacturer, bool> predicate = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product_Food> ViewProduct_Food(Func<Product_Food, bool> predicate = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Setting> ViewSetting(Func<Setting, bool> predicate = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> ViewUser(Func<User, bool> predicate = null)
        {
            throw new NotImplementedException();
        }
    }
}
