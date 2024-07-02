using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson16RegexLog
{
    class Water
    {

    }
    class Sirab : Water { }
    class Badamli : Water { }

    class Person
    {
        public void Drink(Water sirab)
        {

        }
    }

    public interface IDatabase
    {
        void Create();
        void Update();
        void Delete();
        void Get();
    }

    class MsSql : IDatabase
    {
        public void Create()
        {
            // mssql code
        }

        public void Delete()
        {
            // mssql code
        }

        public void Get()
        {
            // mssql code
        }

        public void Update()
        {
            // mssql code
        }
    }

    class MySql : IDatabase
    {
        public void Create()
        {
            // mysql code
        }

        public void Delete()
        {
            // mysql code
        }

        public void Get()
        {
            // mysql code
        }

        public void Update()
        {
            // mysql code
        }
    }

    internal class DependencyInversion
    {

        static void Main()
        {
            Person person = new();
            var water = new Sirab();

            person.Drink(water);
        }
    }
}
