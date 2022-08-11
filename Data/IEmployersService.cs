namespace BlazorCRUDApp.Data
{
    public interface IEmployersService
    {
       public List<Emmployee> GetEmmployees();

       public Emmployee GetEmmployee(Guid id);

       public void UpdateEmployee(Emmployee em);

       public void AddEmployee(Emmployee em);

       public void DeleteEmployee(Guid id);

    }
}