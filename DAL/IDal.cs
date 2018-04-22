using System;
using System.Collections.Generic;
using System.Text;
using BE;

namespace DAL
{
    public interface IDal
    {

        //Activity
        int AddActivity(Activity activity);
        void ModifyActivity(int activityId, int nextActivityId);
        IEnumerable<Activity> ViewActivity(Func<Activity, bool> predicate = null);

        //Comments
        int AddComment(Comment comment);
        void ModifyComment(Comment comment);
        void RemoveComment(int commentId);
        IEnumerable<Comment> ViewComment(Func<Comment, bool> predicate = null);

        //Manufacturer
        int AddManufacturer(Manufacturer manufacturer);
        void ModifyManufacturer(Manufacturer manufacturer);
        void RemoveManufacturer(int manufacturerId);
        IEnumerable<Manufacturer> ViewManufacturer(Func<Manufacturer, bool> predicate = null);

        //Product - Food
        int AddProduct_Food(Product_Food product_Food);
        void ModifyProduct_Food(Product_Food product_Food);
        void RemoveProduct_Food(int product_FoodId);
        IEnumerable<Product_Food> ViewProduct_Food(Func<Product_Food, bool> predicate = null);

        //Settings
        int AddSetting(Setting setting);
        bool ModifySetting(Setting setting);
        bool RemoveSetting(Setting setting);
        IEnumerable<Setting> ViewSetting(Func<Setting, bool> predicate = null);

        //User
        int AddUser(User user);
        void ModifyUser(User user);
        void RemoveUser(int userId);
        IEnumerable<User> ViewUser(Func<User, bool> predicate = null);
    }
}
