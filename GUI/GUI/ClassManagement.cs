using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GUI
{
    class ClassManagement
    {
        ClassesEntities db = new ClassesEntities();

        public List<Class> GetClasses()
        {
            return db.Classes.ToList<Class>();
        }

        public void AddClass(string name, string description)
        {
            db.Classes.Add(new Class() { Name = name, Description = description });
            db.SaveChanges();
        }

        public void EditClass(int id, string name, string description)
        {
            Class obj = db.Classes.Find(id);
            obj.Name = name;
            obj.Description = description;
            db.SaveChanges();
        }

        public void Remove(int id)
        {
            db.Classes.Remove(db.Classes.Find(id));
            db.SaveChanges();
        }

        public Class GetPropertiesOf(int id)
        {
            return db.Classes.Find(id);
        }

        ~ClassManagement()
        {
            db.Dispose();
        }
    }
}
