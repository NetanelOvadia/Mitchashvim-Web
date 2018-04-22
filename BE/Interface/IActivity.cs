using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    interface IActivity
    {
        int Id { get; set; } //Activity ID.
        int UserID { get; set; } //Whos the one that made changes.
        
        int ItemId { get; set; } //The Id of the Product/Store/User.. it refered to
        int ClassType { get; set; } //enum Class { Authority, Activity, Chain, Comment, Manufacturer, Product, Store, User};

        int PreviouseRelated { get; set; }
        int NextRelated { get; set; }

        int MainActivity { get; set; } // enum = Activities { Create, Modify, ChangeStatus };
        string Description { get; set; } //For example, if MainActivity = Modify, so which part modify? if MainActivity = ChangeStatus, which status changed?

        string PreviouseValue { get; set; } //The value before the change.
        string CurrentValue { get; set; } //The value after the change.

        DateTime Time { get; set; }
    }
}
