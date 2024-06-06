using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8Delegates
{
    interface ITakePhoto
    {
        void TakePhoto();
    }
    class Electronic
    {
        public string Vendor { get; set; }
        public string Model { get; set; }
    }

    internal class Phone : Electronic, ITakePhoto
    {
        public void TakePhoto()
        {
            throw new NotImplementedException();
        }
    }

    class Computer : Electronic, ITakePhoto
    {
        public void TakePhoto()
        {
            throw new NotImplementedException();
        }
    }

    class Printer : Electronic
    {

    }

    class Person
    {
        public void TakePhoto(ITakePhoto photo) { photo.TakePhoto(); }
    }
}
