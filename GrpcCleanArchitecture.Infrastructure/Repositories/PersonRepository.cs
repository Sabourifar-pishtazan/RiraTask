using System.Threading.Tasks;
using GrpcCleanArchitecture.Domain.Entities;
using GrpcCleanArchitecture.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

public class PersonRepository : IPersonRepository
{
    private readonly ApplicationDbContext _context;

    public PersonRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Person> CreateAsync(Person person)
    {
        _context.Persons.Add(person);
        await _context.SaveChangesAsync();
        return person;
    }

    public async Task<Person> GetByIdAsync(int id)
    {
        return await _context.Persons.FindAsync(id);
    }

    public async Task<Person> UpdateAsync(Person person)
    {
        _context.Persons.Update(person);
        await _context.SaveChangesAsync();
        return person;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var person = await _context.Persons.FindAsync(id);
        if (person == null) return false;

        _context.Persons.Remove(person);
        await _context.SaveChangesAsync();
        return true;
    }
}
