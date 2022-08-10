namespace BlazorCRUDApp.Data
{
    public class EmployersService : IEmployersService
    {
       private List<Emmployee> emmployees= new List<Emmployee>{
        new Emmployee{
            Id = Guid.NewGuid(),
            Name = "one"
        },
        new Emmployee{
            Id = Guid.NewGuid(),
            Name = "two"
        },
       } ;

        public List<Emmployee> GetEmmployees()
        {
            return emmployees;
        }
    }
}