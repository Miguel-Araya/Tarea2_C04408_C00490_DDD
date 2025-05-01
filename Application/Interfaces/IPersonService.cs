using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPersonService
    {
        Task<bool> insertPerson(PersonDTO person);
        Task<bool> updatePerson(PersonDTO person);
        Task<bool> deletePerson(string IdCard);
        Task<IEnumerable<PersonDTO>> selectAll();
        Task<PersonDTO> findByIdCard(string IdCard);
    }
}
