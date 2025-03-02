using System.Threading.Tasks;
using Grpc.Core;
using GrpcCleanArchitecture.Proto;
using GrpcCleanArchitecture.Domain.Entities;
using GrpcCleanArchitecture.Application.Extensions;

public class PersonGrpcService : PersonService.PersonServiceBase
{
    private readonly IPersonRepository _personRepository;

    public PersonGrpcService(IPersonRepository personRepository)
    {
        _personRepository = personRepository;
    }

    public override async Task<PersonResponse> CreatePerson(CreatePersonRequest request, ServerCallContext context)
    {
        var person = request.ToPersonEntity();
        var createdPerson = await _personRepository.CreateAsync(person);
        return createdPerson.ToPersonResponse();
    }

    public override async Task<PersonResponse> GetPersonById(PersonByIdRequest request, ServerCallContext context)
    {
        var person = await _personRepository.GetByIdAsync(request.Id);
        if (person == null)
            throw new RpcException(new Status(StatusCode.NotFound, "Person not found"));

        return person.ToPersonResponse();
    }

    public override async Task<PersonResponse> UpdatePerson(UpdatePersonRequest request, ServerCallContext context)
    {
        var person = await _personRepository.GetByIdAsync(request.Id);
        if (person == null)
            throw new RpcException(new Status(StatusCode.NotFound, "Person not found"));

        person.UpdatePersonFromRequest(request);
        var updatedPerson = await _personRepository.UpdateAsync(person);
        return updatedPerson.ToPersonResponse();
    }

    public override async Task<DeletePersonResponse> DeletePerson(PersonByIdRequest request, ServerCallContext context)
    {
        var deleted = await _personRepository.DeleteAsync(request.Id);
        if (!deleted)
            throw new RpcException(new Status(StatusCode.NotFound, "Person not found"));

        return new DeletePersonResponse { Success = true };
    }
}
