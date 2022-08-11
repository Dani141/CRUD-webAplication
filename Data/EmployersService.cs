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

        public Emmployee GetEmmployee(Guid id)
        {
            return emmployees.SingleOrDefault(x=>x.Id==id);
        }

        public List<Emmployee> GetEmmployees()
        {
            return emmployees;
        }

        public void UpdateEmployee(Emmployee em)
        {
            var getOld=GetEmmployee(em.Id);
            getOld.Name=em.Name;
        }
    }
}