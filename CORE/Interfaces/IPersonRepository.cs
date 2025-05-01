using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public  interface IPersonRepository
    {
        Task<bool> insertPerson(Person person);
        Task<bool> updatePerson(Person person);
        Task<bool> deletePerson(string IdCard);
        Task<IEnumerable<Person>> selectAll();
        Task<Person> findByIdCard(string IdCard);
    }
}
