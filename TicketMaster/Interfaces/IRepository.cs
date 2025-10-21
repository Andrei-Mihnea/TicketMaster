namespace Interfaces
{
    public interface IRepository<T>//interface that will contain some CRUD operations for the stocking of data
    {
        public void AddMember(T member);//Create
        public IList<T> GetAllMembers();//Read
        public void Update(T member);//Update
        public void Delete(T member);//Delete
    }
}