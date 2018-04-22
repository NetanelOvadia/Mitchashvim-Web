using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class User
    {
        //regular details.
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RecoveryPassword { get; set; }
        public bool RecoveryPasswordEnable { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime BirthDate { get; set; }
        public int PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public int DefaultLanguage { get; set; } // enum Languages { Hebrew, English };
        public int Gender { get; set; } //enum Gender {NotSpesified, Male, Female};
        public DateTime RegisterationDate { get; set; }

        public int SettingsId { get; set; } //If the user want a specific settings (don't want to use the default settings). if its null so use default.

        //for security needs 
        public DateTime LastUpdated { get; set; } //the last time that has changed the authority for this user.
        public string AuthorityGroups { get; set; } //if the user is belongs to some groups like an admin...
        public string AdminNote { get; set; } //If the admin want to write something about this user (without he can see..)
        public int Activity { get; set; }
        public int AccountType { get; set; } //when there will be an option to chose between acounts, like payment or something...
        public int LoginList { get; set; } //an id for the login list of the user..

        //Need to add more things that the user can see its statistics, its uses...
        public int ShoppingList { get; set; }//An id for the details of the shoping. הקבלות..
        public int ShoppintListCount { get; set; } //instead of count them each time the user enter its profile...
        public int AlertsList { get; set; }  //If the user want to get know for some events.. like when some price is fall down...
        public int AlertsListCount { get; set; }
        
        public int CommentCount { get; set; }
        public int ForumMessagesCount { get; set; }

        //default locations:
        //the user has an option to choose his default location to get the prices the relevate for him.
        //also choose an amount of stores that need to him that he want to see each time (when enter to product).
        //1. the user can enter for example his location, and rang, so 
        public int NumberOfDefaultStores { get; set; } //how much stores he want to see each time.
        public string DefaultLocation { get; set; }//for example, his location...
        public string DefaultStores { get; set; } //choose default storse, seperate by ' , '.
        public bool DefaultStoresOptionOn { get; set; } //if to use this option at all...


    }
}
