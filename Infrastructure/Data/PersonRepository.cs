using Core.Entities;
using Core.Interfaces;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationBDContext dbContext;
        public PersonRepository(ApplicationBDContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<bool> deletePerson(string IdCard)
        {
            var personDB = await this.dbContext.Persons.FindAsync(IdCard);
            if (personDB == null) return false;

            this.dbContext.Persons.Remove(personDB);
            return await this.dbContext.SaveChangesAsync() > 0;
        }
        

        public async Task<Person> findByIdCard(string IdCard)
        {
            var person = await dbContext.Persons.FirstOrDefaultAsync(e => e.IdCard == IdCard);
            if (person == null)
                return new Person();

            return person;

        }

        public async Task<bool> insertPerson(Person person)
        {
           this.dbContext.Persons.Add(person);
            return await this.dbContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Person>> selectAll()
        {
            return await this.dbContext.Persons.ToListAsync();
        }

        public async Task<bool> updatePerson(Person person)
        {
            var existingPerson = await this.dbContext.Persons.FindAsync(person.IdCard);

            if (existingPerson == null)
                return false;

           
            existingPerson.Name = person.Name;
            existingPerson.LastNameOne = person.LastNameOne;
            existingPerson.LastNameTwo = person.LastNameTwo;
            existingPerson.Email = person.Email;

            await this.dbContext.SaveChangesAsync();
            return true;
        }
    }
}
