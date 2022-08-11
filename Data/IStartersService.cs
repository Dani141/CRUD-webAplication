namespace BlazorCRUDApp.Data
{
    public interface IStartersService
    {
       public List<Starters> GetStarters();

       public Starters GetStartersByID(Guid id);

       public void UpdateStarters(Starters starters);

       public void AddStarters(Starters starters);

       public void DeleteStarters(Guid id);

    }
}