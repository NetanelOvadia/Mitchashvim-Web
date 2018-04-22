using Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    class ChainStore : IStore
    {
        public int AddId { get; set; } //the Id of the Activity item for the adding.
        public int ModifyId { get; set; } //the Id of the Activity item for the last modifying.

        public int Id { get; set; } //notice that this is LOCAL ! Chain Store and Store has diffrent ids!
        public int ReallyId { get; set; } //the real id of the store.
        public int ChainId { get; set; } //refers to Local Id.

        public string StoreName { get; set; } //if this Chain Store - The name of the sub store Example: "Rami Levy - Snif Har Hotzvim", so here we will write only "Snif Har Hotzvim", and if it Store so its full name.
        public string StoreNameEnglish { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Services { get; set; } //משלוחים, תווי קניה
        public string ServicesEnglish { get; set; }
        public int PhoneNumber { get; set; }
        public int FaxNumber { get; set; }
        public bool StoreType { get; set; } //0 - ChainStore, 1 - Store.

        //Opening Hours
        public int SundayOpening { get; set; }
        public int SundayClosing { get; set; }

        public int MondayOpening { get; set; }
        public int MondayClosing { get; set; }

        public int TuesdayOpening { get; set; }
        public int TuesdayClosing { get; set; }

        public int WednesdayOpening { get; set; }
        public int WednesdayClosing { get; set; }

        public int ThursdayOpening { get; set; }
        public int ThursdayClosing { get; set; }

        public int FridayOpening { get; set; }
        public int FridayClosing { get; set; } //constant time, if FridayClosingWinter have value so this refers to Summer Clock.
        public int FridayClosingWinter { get; set; } //refers to Winter Clock.
        public bool BeforeShabbath { get; set; } //Does the value "Friday Closing" refers to the time closing before Shabbat begins?

        public int SaturdayOpening { get; set; } //constant time, if SaturdayOpeningWinter have value so this refers to Summer Clock.
        public int SaturdayOpeningWinter { get; set; } //refers to Winter Clock.
        public int SaturdayClosing { get; set; }
        public bool AfterShabbath { get; set; } //Does the value "Saturday Opening" refers to the time opening after Shabbat ends?


    }
}
