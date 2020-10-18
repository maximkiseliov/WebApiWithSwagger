using System;
using System.Linq;
using TechnicalTestWebApi.Models;

namespace TechnicalTestWebApi.DB
{
    public static class RegistrationAppQueries
    {
        public static IQueryable<Registration> ByRegistrationId(Guid? registrationId, RegistrationAppDbContext context)
        {
            return from r in context.Registrations
                join p in context.Persons on r.Person.PersonId equals p.PersonId
                join o in context.Organisations on r.Organisation.OrganisationId equals o.OrganisationId
                join pA in context.Addresses on p.Address.AddressId equals pA.AddressId
                join oA in context.Addresses on o.Address.AddressId equals oA.AddressId
                where r.RegistrationId.Equals(registrationId)
                select new Registration
                {
                    RegistrationId = r.RegistrationId,
                    RegistrationDate = r.RegistrationDate,
                    Person = new Person
                    {
                        Address = pA,
                        Email = p.Email,
                        FirstName = p.FirstName,
                        LastName = p.LastName
                    },
                    Organisation = new Organisation
                    {
                        Address = oA,
                        Name = o.Name
                    }
                };
        }
    }
}