using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.ComponentModel;
using System.Xml.Linq;
using System.Reflection;
using BE;

//כעקרון גמור
namespace DAL
{
    public class XamlActivities : IActivities
    {
        XElement ActivitiesRoot;
        string ActivitiesPath = @"ActivitiesRootXml.xml";

        public XamlActivities()
        {
            if (!File.Exists(ActivitiesPath))
            {
                ActivitiesRoot = new XElement("XamlActivities");
                ActivitiesRoot.Save(ActivitiesPath);
            }
            else
            {
                try
                {
                    ActivitiesRoot = XElement.Load(ActivitiesPath);
                }
                catch
                {
                    throw new Exception("Activities file not exist");
                }
            }
        }

        //Convert from Activity to XElement.
        XElement ConvertActivity(BE.Activity activity)
        {
            XElement ActivityElement = new XElement("Activity");
            foreach (PropertyInfo item in typeof(BE.Activity).GetProperties())
                ActivityElement.Add(new XElement(item.Name, item.GetValue(activity, null)));

            return ActivityElement;
        }

        //Convert from XElement to Activity.
        Activity ConvertActivity(XElement element)
        {
            Activity activity = new Activity();

            foreach (PropertyInfo item in typeof(Activity).GetProperties())
            {
                TypeConverter typeConverter = TypeDescriptor.GetConverter(item.PropertyType);
                object convertValue = typeConverter.ConvertFromString(element.Element(item.Name).Value);
                item.SetValue(activity, convertValue);
            }

            return activity;
        }

        //צריך לחשוב איך לאחר ההוספה אני מקבל את המספור האוטומתי שניתן לאותה תגובה שהוספתי
        public int AddActivity(Activity activity)
        {
            //קבלת המספר הסידורי של הרשומה האחרונה הכללית של פעילות
            int newIdForTheCurrentActivity = ViewActivity().Max(i=>i.Id);
            //עדכון שלה במופע שנשלח
            activity.Id = newIdForTheCurrentActivity;

            {
                ActivitiesRoot.Add(ConvertActivity(activity));
                ActivitiesRoot.Save(ActivitiesPath);
            }

            return newIdForTheCurrentActivity;
        }

        //ישמש דווקא כדי לבצע עדכון עבור פעילות, מי הפעילות שאחריה
        public bool ModifyActivity(int activityId, int nextActivityId)
        {
            XElement ActivateUpdate = (from item in ActivitiesRoot.Elements()
                                       where int.Parse(item.Element("Id").Value) == activityId
                                       select item).FirstOrDefault();
            if (ActivateUpdate == null)
                return false;

            ActivateUpdate.Element("NextRelated").SetValue(nextActivityId);

            ActivateUpdate.Save(ActivitiesPath);

            return true; //succssed
        }
        

        //predicate == null -> select all.
        //skip == 0 -> no skip.
        //count == 0 -> no count, all.
        //if using skip, so must use count. (no option that skip!=0 and count == 0)
        public IEnumerable<Activity> ViewActivity(Func<Activity, bool> predicate = null, int count = 0, int skip =0)
        {
            //skip ... activities, and take the first ... 
            if (predicate == null && skip == 0)
                return (from item in ActivitiesRoot.Elements()
                        select ConvertActivity(item)).Skip(skip).Take(count);

            //all activities
            if (predicate == null)
                return from item in ActivitiesRoot.Elements()
                       select ConvertActivity(item);

            //skip ... and take...
            if (skip != 0)
                return (from item in ActivitiesRoot.Elements()
                        let activity = ConvertActivity(item)
                        where predicate(activity)
                        select activity).Skip(skip).Take(count);

            //take first ...
            if (count != 0)
                return (from item in ActivitiesRoot.Elements()
                        let activity = ConvertActivity(item)
                        where predicate(activity)
                        select activity).Take(count);

            //all by predicate
            return (from item in ActivitiesRoot.Elements()
                    let activity = ConvertActivity(item)
                    where predicate(activity)
                    select activity);
        }

    }
}
