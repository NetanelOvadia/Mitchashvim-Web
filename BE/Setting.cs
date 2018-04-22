using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    /// <summary>
    /// Setting Class.
    /// For each part in the project (like user, comment...) I can add an setting,
    /// for example, I want to decide for all the products, if to give the option to make comment.
    /// במילים אחרות, המחלקה Settings קובעת הגדרות ברירת מחדל באופן כללי ובאופן פרטני.
    /// כאשר יש לי את כל התחום של המוצרים, אני רוצה להגדיר בכללי עבור אורח ועבור משתמש רשום רגיל,
    /// האם ניתן להן אפשרות מסויימת למשל צפייה, תגובה.. 
    /// ואע"פ כן, אם ארצה עבור מוצר ספציפי לאסור תגובות, אז יהיה ניתן להוסיף פרטנית הגדרה שתאמר לאסור.
    /// ולכן אם כן יוצא שבסה"כ ישנם 3 הגדרות להרשאות:
    /// 1. הרשת ברירת מחדל, למשל אני מרשה לכל המשתמשים לצפות במוצר ולהגיב עליו.
    /// 2. הרשאה כללית פרטנית, אע"פ שהרשתי להגיב לכל המוצרים, למוצר הזה אני לא מרשה להגיב.
    /// 3. מתן סמכות, אע"פ שאמרתי שלמוצר הזה הספציפי אני לא מרשה להגיב, למשתמש פלוני תהיה את האפשרות הזאת.
    /// הבהרה: היחס לשינוי / מחיקה זה דווקא עבור אותו אחד שהוסיף, כמובן שאין הווא אמינא שכל מי שרוצה יכול לשנות ולמחוק.
    /// </summary>
    public class Setting
    {
        public int Id { get; set; }
        public int ItemId { get; set; } //for example the Id of the product. if ItemId==0 && SetId==0 then this setting for entire class, and will save in diffrent location.
        public int SetId { get; set; } //Optional, if needed some local setting for something.
        public int Class { get; set; } //enum Classes { Authority, Activity, Chain, Comment, Manufacturer, Product, Store, User};
        public string Description { get; set; } //A short description about the type of setting.
        public int Activity { get; set; } //last activity


        //שייך לציין שאנו פה נגדיר
        //Setting for main item.
        public bool MainUserAdd { get; set; } //Can registered user add?
        public bool MainGuestAdd { get; set; }//Can Guest add? (for example, comment..)
        public bool MainAuthorModify { get; set; } //Can the author of the item modify it?
        public bool MainAuthorRemove { get; set; } //Can the author of the item remove it?

        //Setting for comment
        public bool CommentUserAdd { get; set; }

        public DateTime Time { get; set; }
    }
}
