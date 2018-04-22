using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface IStore
    {
        int AddId { get; set; } //the Id of the Activity item for the adding.
        int ModifyId { get; set; } //the Id of the Activity item for the last modifying.

        int Id { get; set; } //notice that this is LOCAL ! Chain Store and Store has diffrent ids!
        int ReallyId { get; set; } //the real id of the store.
        
        string StoreName { get; set; } //if this Chain Store - The name of the sub store Example: "Rami Levy - Snif Har Hotzvim", so here we will write only "Snif Har Hotzvim", and if it Store so its full name.
        string StoreNameEnglish { get; set; }
        string Address { get; set; }
        string Email { get; set; }
        string Services { get; set; } //משלוחים, תווי קניה
        string ServicesEnglish { get; set; }
        int PhoneNumber { get; set; }
        int FaxNumber { get; set; }
        bool StoreType { get; set; } //0 - ChainStore, 1 - Store.

        //Opening Hours
        int SundayOpening { get; set; }
        int SundayClosing { get; set; }

        int MondayOpening { get; set; }
        int MondayClosing { get; set; }

        int TuesdayOpening { get; set; }
        int TuesdayClosing { get; set; }

        int WednesdayOpening { get; set; }
        int WednesdayClosing { get; set; }

        int ThursdayOpening { get; set; }
        int ThursdayClosing { get; set; }

        int FridayOpening { get; set; }
        int FridayClosing { get; set; } //constant time, if FridayClosingWinter have value so this refers to Summer Clock.
        int FridayClosingWinter { get; set; } //refers to Winter Clock.
        bool BeforeShabbath { get; set; } //Does the value "Friday Closing" refers to the time closing before Shabbat begins?

        int SaturdayOpening { get; set; } //constant time, if SaturdayOpeningWinter have value so this refers to Summer Clock.
        int SaturdayOpeningWinter { get; set; } //refers to Winter Clock.
        int SaturdayClosing { get; set; }
        bool AfterShabbath { get; set; } //Does the value "Saturday Opening" refers to the time opening after Shabbat ends?

    }
}
