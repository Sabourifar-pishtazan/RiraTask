using GrpcCleanArchitecture.Domain.Entities;

public interface IPersonRepository
{
    Task<Person> CreateAsync(Person person);
    Task<Person> GetByIdAsync(int id);
    Task<Person> UpdateAsync(Person person);
    Task<bool> DeleteAsync(int id);
}
