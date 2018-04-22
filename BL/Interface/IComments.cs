using System;
using System.Collections.Generic;
using System.Text;
using BE;

namespace BL
{
    public interface IComments
    {
        int AddComment(Comment comment, int userId);
        void ModifyComment(Comment comment, int userId);
        void RemoveComment(int commentId, int userId, int itemId );
        IEnumerable<Comment> ViewComment(Func<Comment, bool> predicate = null, int count = 0, int skip = 0);
    }
}
