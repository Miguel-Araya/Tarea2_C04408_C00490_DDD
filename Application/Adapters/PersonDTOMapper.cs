using Application.DTOs;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Adapters
{
    public class PersonDTOMapper
    {
        public static PersonDTO PersonTODTO (Person person)
        {
            return new PersonDTO
            {
                IdCard = person.IdCard,
                LastNameOne = person.LastNameOne,
                LastNameTwo = person.LastNameTwo,
                Email = person.Email,
                Name = person.Name,
            };
        }
        public static Person DTOToPerson (PersonDTO personDTO)
        {
            return new Person
            {
                IdCard = personDTO.IdCard,
                LastNameOne = personDTO.LastNameOne,
                LastNameTwo = personDTO.LastNameTwo,
                Email = personDTO.Email,
                Name = personDTO.Name,
            };
        }
        public static IEnumerable<PersonDTO> ListPersonToListDTO(IEnumerable<Person> listPerson) {
            return listPerson.Select(person => new PersonDTO
            {
                IdCard = person.IdCard,
                LastNameOne = person.LastNameOne,
                LastNameTwo = person.LastNameTwo,
                Email = person.Email,
                Name = person.Name
            });

        }
    }
}
