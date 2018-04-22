using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    /// <summary>
    /// המחלקה Activity
    /// המטרה: לתעד פעולות שמבוצעות ברכיבי האתר.
    /// לדוגמא, כאשר אחד מבעלי ההרשאות רוצה לשנות פרטים של מוצר.
    /// Id - מספר סידורי של הפעולה עצמה
    /// UserId - איזה משתמש ביצע את הפעולה
    /// ItemId - מה מספר המוצר / משתמש / תגובה וכו' שעליו התבצעה הפעילות
    /// ClassType - איזה רכיב זה? מוצר, חנות וכו'... קיים לו enum
    /// PreviouseRelated - על מנת שיהיה רצף של פעולות שניתן לעקוב אחריהן,
    /// עבור כל מוצר / משתמש... יש מספר פעילות אחרונה.
    /// כאשר מתבצעת פעולה חדשה אז הערך באותו רכיב משתנה לפעילות הנוכחית, 
    /// והמספר של הפעילות הקודמת שהתבצעה נרשמת כאן תחת משתנה זה
    /// NextRelated - אם התבצעה פעילות נוספת על אותו מוצר אנחנו נרשום בתא זה את הפעילות
    /// MainActivity - איזה סוג פעילות, הוספה, שינוי, שינוי מצב, מחיקה, קיים לו enum
    /// Description - מדוע היה צורך בשינוי?
    /// PreviouseValue - מה היה הערך / היו ערכים לפני השינוי?
    /// נגדיר מבנה בצורה כזו:
    /// ItemNme1 = ItemValue1, ItemName2 = ItemValue2..
    /// CurrentValue - הערך הנוכחי..
    /// </summary>
    public class Activity : IActivity
    {
        public int Id { get; set; } //Activity ID.
        public int UserID { get; set; } //Whos the one that made changes.

        public int ItemId { get; set; } //The Id of the Product/Store/User.. it refered to
        public int ClassType { get; set; } //enum Class { Authority, Activity, Chain, Comment, Manufacturer, Product, Store, User};

        public int PreviouseRelated { get; set; }
        public int NextRelated { get; set; }

        public int MainActivity { get; set; } // enum = Activities { Create, Modify, ChangeStatus, Remove, FirstCreate };
        public string Description { get; set; } //What cause the reason to made change?

        public string PreviouseValue { get; set; } //The value before the change.
        public string CurrentValue { get; set; } //The value after the change.

        public DateTime Time { get; set; }
    }
}
