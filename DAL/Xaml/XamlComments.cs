using System;
using System.Collections.Generic;
using System.Text;
using BE;
using System.Xml.Linq;
using System.IO;
using System.Reflection;
using System.ComponentModel;

namespace DAL
{
    public class XamlComments : IComments
    {
        XElement CommentsRoot;
        string CommentsPath = @"CommentsRootXml.xml";
        
        public XamlComments()
        {
            if (!File.Exists(CommentsPath))
            {
                CommentsRoot = new XElement("XamlComments");
                CommentsRoot.Save(CommentsPath);
            }
            else
            {
                try
                {
                    CommentsRoot = XElement.Load(CommentsPath);
                }
                catch
                {
                    throw new Exception("Comments file not exist");
                }
            }
        }

        //Convert from Comment to XElement.
        XElement ConvertComment(BE.Comment comment)
        {
            XElement CommentElement = new XElement("Comment");
            foreach (PropertyInfo item in typeof(BE.Comment).GetProperties())
                CommentElement.Add(new XElement(item.Name, item.GetValue(comment, null)));

            return CommentElement;
        }

        //Convert from XElement to Comment.
        Comment ConvertComment(XElement element)
        {
            Comment comment = new Comment();

            foreach (PropertyInfo item in typeof(BE.Comment).GetProperties())
            {
                TypeConverter typeConverter = TypeDescriptor.GetConverter(item.PropertyType);
                object convertValue = typeConverter.ConvertFromString(element.Element(item.Name).Value);
                item.SetValue(comment, convertValue);
            }

            return comment;
        }

        //צריך לחשוב על דרך איך מחזירים את המספור האוטומתי
        //נראה לי שהעניין זה שצריך למצוא את המספר הכי גבוה שקיים 
        //צריך ליצור איזו מחלקה או אפילו פרוייקט מקביל ששמה יהיה ניהול של הגישה לקובץ,
        //דהיינו שלא תתאפשר גישה במקביל, כעין הרעיון של הסינגלטון
        //ואז שמה נשמור באיזשהו קובץ נתונים של הרשומה האחרונה שנוספה עבור כל רכיב,
        //ובעצם כאשר אני רוצה לכתוב אני צריך שלא יהיה מי שיכתוב איתי בו זמנית כדי לא לקבל מספור מקביל
        public int AddComment(Comment comment)
        {

            {
                CommentsRoot.Add(ConvertComment(comment));
                CommentsRoot.Save(CommentsPath);
            }
            throw new NotImplementedException();
        }

        public void ModifyComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public void RemoveComment(int commentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comment> ViewComment(Func<Comment, bool> predicate = null, int count = 0, int skip = 0)
        {
            throw new NotImplementedException();
        }
    }
}
