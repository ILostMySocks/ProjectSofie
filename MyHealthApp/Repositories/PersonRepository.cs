using MyHealthApp;
using MyHealthApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHealthApp.Repositories
{
    public class PersonRepository
    {
        private readonly MyHealthAppContext _dbContext;
        private readonly DbSet<Person> _dbSet;


        public PersonRepository(MyHealthAppContext context)
        {
           _dbContext = context;
            _dbSet = _dbContext.Set<Person>();
        }

        public List<Person> GetAll()
        {
            return _dbSet.ToList();

            
            //voorbeeld selectief teruggeven
            var qry = _dbSet.Where(p => p.LastName == "Strumane" && p.FirstName == "Sofie");
            qry = qry.Where(p => p.GenderIdentity == GenderIdentity.Female);

            //effectief qry uitvoeren
            var res = qry.ToList();
            var res1steOfGeen = qry.FirstOrDefault(); //geen res = null
            var res1steOfEx = qry.First(); //geen res = Exception => meerdere Sofie gevonden? => eerste Sofie
            var res1OfGeen = qry.SingleOrDefault(); //geen res = null, meer res = Exception
            var res1OfEx = qry.Single(); //geen res = Exception, meer res = Exception => Meerdere Sofie gevonden? => Exception!

            //Kan ook als volgt, maar kan niet verder filteren:
            var res1OfExZonderQry = _dbSet.Single(p => p.LastName == "Strumane" && p.FirstName == "Sofie");

            //beperken kolommen
            var resSelect = qry.Select(p => new Calendar() {Person = p}).ToList();
            //hier krijgen we lijst van Calendars waar MyHealthyPerson ingevuld is
            //niet zo 'n superlogisch voorbeeld maar u get the idea

            //Ander voorbeeld
            var resSelectMetTest = qry.Select(p => new test() { Voor = p.FirstName, Achter = p.LastName}).ToList();
            //hier krijgen we een lijst van firstname en lastname

            var resPersIncAdres = qry.Include(p => p.Calendar).ToList(); //left join
            //dit geeft een tabel weer van persoon EN zijn Calendar en de daarbij horende properties!


            res1steOfEx.BirthDate = DateTime.Now;
            _dbContext.SaveChanges();
            // deze persoon zijn geboortedatum is effectief aangepast!
            //iets wordt opgehaald, wordt in geheugen gehouden. doet daar aanpassing op en
            //saves. => gevaarlijk gedrag, maar doet EF doet wel aan change tracking.


        }
        //test klasse enkel voorbeeld, niet proper om hierbij te zetten!
        class test
        {
            public string Voor { get; set; }
            public string Achter { get; set; }
        }

        public virtual Person GetById(int id)
        {
            return _dbSet.SingleOrDefault(x => x.Id == id);

            //OF
            return _dbSet.Find(id);
        }

        public virtual int Create (Person person) //insert
        {
            _dbSet.Add(person);
            SaveChanges(); //dbcontext methodes
            return person.Id;
        }



        public virtual void Update(Person person) //update
        {
            _dbContext.Update(person);
            SaveChanges();
        }

        public void Delete(int id)
        {
            _dbSet.Where(x => x.Id == id).ExecuteDelete();

            //voorbeeld van oude manier, bovenste manier is interessanter
            var toDelete = GetById(id);
            _dbSet.Remove(toDelete);
            SaveChanges();
        }


        internal void SaveChanges() //mag internal staan want 
        {
            try
            {
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            } //trycatch hier zetten zodat je het niet elke keer erbij moet zetten wanneer
              //je de save changes methode wilt aanroepen
        }
    }
}
