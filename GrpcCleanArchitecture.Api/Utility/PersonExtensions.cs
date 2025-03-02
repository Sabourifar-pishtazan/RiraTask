using System;
using Google.Protobuf.WellKnownTypes;
using GrpcCleanArchitecture.Domain.Entities;
using GrpcCleanArchitecture.Proto;

namespace GrpcCleanArchitecture.Application.Extensions
{
    public static class PersonExtensions
    {
        public static PersonResponse ToPersonResponse(this GrpcCleanArchitecture.Domain.Entities.Person person)
        {
            return new PersonResponse
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName,
                NationalCode = person.NationalCode,
                BirthDate = Timestamp.FromDateTime(person.BirthDate.Kind == DateTimeKind.Utc
                    ? person.BirthDate
                    : person.BirthDate.ToUniversalTime())
            };
        }

        public static GrpcCleanArchitecture.Domain.Entities.Person ToPersonEntity(this CreatePersonRequest request)
        {
            return new GrpcCleanArchitecture.Domain.Entities.Person
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                NationalCode = request.NationalCode,
                BirthDate = request.BirthDate.ToDateTime().ToUniversalTime() // تبدیل Timestamp به DateTime
            };
        }

        public static void UpdatePersonFromRequest(this GrpcCleanArchitecture.Domain.Entities.Person person, UpdatePersonRequest request)
        {
            person.FirstName = request.FirstName;
            person.LastName = request.LastName;
            person.NationalCode = request.NationalCode;
            person.BirthDate = request.BirthDate.ToDateTime(); 
        }
    }
}
