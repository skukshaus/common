namespace Ksh.Common.Tests.DataStoring;

public class RepositoryTests
{
    [Fact] public void foo()
    {
        // Arrange
        var uow = new UnitOfWork();

        // Act
        var repo = uow.GetRepository<Person>();

        // Assert
        using var _ = new AssertionScope();
        repo.Should().BeOfType<PersonRepository>();
    }
}

record Person(string Name) : IEntity<int>
{
    public int Id { get; init; }
}

record Address(string Country) : IEntity<int>
{
    public int Id { get; init; }
}

interface IPersonRepository : IRepository<Person, int>;

interface IAddressRepository : IRepository<Address, int>;

class PersonRepository : IPersonRepository
{
    public IQueryable<Person> GetAll() => throw new NotImplementedException();

    public Person GetById(int id) => throw new NotImplementedException();

    public void Create(Person obj) => throw new NotImplementedException();

    public void Update(Person obj) => throw new NotImplementedException();
    
    public void Delete(int idx) => throw new NotImplementedException();
}

class AddressRepository : IAddressRepository
{
    public IQueryable<Address> GetAll() => throw new NotImplementedException();
    
    public Address GetById(int id) => throw new NotImplementedException();

    public void Create(Address obj) => throw new NotImplementedException();

    public void Update(Address obj) => throw new NotImplementedException();

    public void Delete(int idx) => throw new NotImplementedException();
}

class UnitOfWork : IUnitOfWork<int>
{
    public void Dispose() => throw new NotImplementedException();

    public IRepository<TEntity, int> GetRepository<TEntity>() where TEntity : class, IEntity<int>
        => new PersonRepository() as IRepository<TEntity, int>;

    public void Commit() => throw new NotImplementedException();

    public void Rollback() => throw new NotImplementedException();
}