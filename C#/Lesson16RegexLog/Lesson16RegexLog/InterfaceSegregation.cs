using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16RegexLog
{
    interface IUser
    {
        void Like();
        void WriteComment();
        void WritePost();
    }
    interface IModerator
    {
        void DeleteComment();
        void DeletePost();
    }

    class Moderator : IUser, IModerator
    {
        public void DeleteComment()
        {
            int
            throw new NotImplementedException();
        }

        public void DeletePost()
        {
            throw new NotImplementedException();
        }

        public void Like()
        {
            throw new NotImplementedException();
        }

        public void WriteComment()
        {
            throw new NotImplementedException();
        }

        public void WritePost()
        {
            throw new NotImplementedException();
        }
    }

    internal class InterfaceSegregation
    {
    }
}
