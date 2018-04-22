using System;
using System.Collections.Generic;
using System.Text;
using BE;

namespace DAL
{
    public interface IComments
    {
        int AddComment(Comment comment);
        void ModifyComment(Comment comment);
        void RemoveComment(int commentId);
        IEnumerable<Comment> ViewComment(Func<Comment, bool> predicate = null, int count = 0, int skip = 0);
    }
}
