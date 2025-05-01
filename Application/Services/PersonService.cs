using Application.Adapters;
using Application.DTOs;
using Application.Interfaces;
using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PersonService: IPersonService
    {

        private readonly IPersonRepository personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public async Task<bool> deletePerson(string IdCard)
        {
            
            return await this.personRepository.deletePerson(IdCard);
        }

        public async Task<PersonDTO> findByIdCard(string IdCard)
        {
            return PersonDTOMapper.PersonTODTO(await this.personRepository.findByIdCard(IdCard));
        }

        public async Task<bool> insertPerson(PersonDTO person)
        {
            return await this.personRepository.insertPerson(PersonDTOMapper.DTOToPerson(person));
        }

        public async Task<IEnumerable<PersonDTO>> selectAll()
        {
            return PersonDTOMapper.ListPersonToListDTO(await this.personRepository.selectAll());
        }

        public async Task<bool> updatePerson(PersonDTO person)
        {
            return await this.personRepository.updatePerson(PersonDTOMapper.DTOToPerson(person));
        }
    }
}
