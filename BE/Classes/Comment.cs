using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Comment
    {
        public int Id { get; set; } //Local Id for the commet.
        public int UserId { get; set; } //The is of the author.

        public int Activity { get; set; } //Id of the recent activity.

        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime Time { get; set; }

        public int ItemId { get; set; } //The id of the item that the comment related to.
        public int CommentType { get; set; } //enum CommentType { Main, Subsidary};
        public int ClassType { get; set; } //enum Classes { Authority, Activity, Chain, Comment, Manufacturer, Product, Setting, Store, User};
        
        public int NextLevelComment { get; set; } //The next comment in the same level.
        public int SubComment { get; set; } 
        public int MainId { get; set; } //if the comment is subsidary, so the Id of the comment it realted to.

        public bool Publish { get; set; }//if this comment waiting for acception to be published.. 

        //where anonnymous comments are allowed.
        public string Email { get; set; }
        public string FullName { get; set; }
        public int GuestId { get; set; } //If the user is not registered, so a details for them like IP..

        public override string ToString()
        {
            string tmp;
            tmp = "Time: " + Time + "Subject: " + Subject + ", Conetent: " + Content;
            return tmp;
        }
    }
}
