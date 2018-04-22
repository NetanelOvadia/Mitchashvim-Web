using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    /// <summary>
    /// Create = The one whos create / add the current object.
    /// Modify = Made some modify on the object *details*, like changing the name.
    /// ChangeStatus = 
    /// Remove = Remove the element.
    /// FirstCreate = when creation of a new mainly class (like user, product...)
    /// </summary>
    public enum EActivities { Create , Modify, ChangeStatus , Remove , FirstCreate};

    /// <summary>
    /// Main = This comment is the root, and not related to another comment in its subject.
    /// Subsidary = This Comment is secondary, and posted as a response to another comment.
    /// </summary>
    public enum ECommentType { Main, Subsidary};

    public enum ELanguages { Hebrew, English};

    public enum EGender { NotSpecified, Male, Female }

    public enum EClasses { Authority, Activity, Chain, Comment, Manufacturer, Product, Setting, Store, User};

    public enum ESettings { Add, Modify, Remove, View};

    public enum EDay : byte { Sat , Sun, Mon, Tue, Wed, Thu, Fri };
    

    class Enums
    {
    }
}
