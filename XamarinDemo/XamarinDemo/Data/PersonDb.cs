using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using XamarinDemo.Model;
using XamarinForms.Interfaces;

namespace XamarinDemo.Data
{
    public class PersonDb
    {
        private readonly SQLiteConnection _sqLiteConnection;

        public PersonDb()
        {
            _sqLiteConnection = DependencyService.Get<ISQLite>().GetConnection(); 
            _sqLiteConnection.CreateTable<Person>();
        }

        public List<Person> GetPeople()
        {
            return _sqLiteConnection.Table<Person>().ToList();
        }

        public Person GetPerson(int personID)
        {
            return _sqLiteConnection.Table<Person>().Where(e => e.ID == personID).FirstOrDefault();
        }

        public int SavePerson(Person p)
        {
            if(p.ID == 0)
            {
                return _sqLiteConnection.Insert(p);
            }
            else
            {
                return _sqLiteConnection.Update(p);
            }
        }

        public int DeletePerson(Person p)
        {
            return _sqLiteConnection.Delete(p);
        }
    }
}
