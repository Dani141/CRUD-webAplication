namespace BlazorCRUDApp.Data
{
    public class StartersService : IStartersService
    {
       private List<Starters> startersList= new List<Starters>{
        new Starters{
            Id = Guid.NewGuid(),
            Name = "Shrimp Yaki Tori",
            Price= 9
        },
        new Starters{
            Id = Guid.NewGuid(),
            Name = "Shrimp Gyouza",
            Price=5
        },
       } ;

        public void AddStarters(Starters starters)
        {
            var id=Guid.NewGuid();
            starters.Id=id;
            startersList.Add(starters);
        }

        public void DeleteStarters(Guid id)
        {
            var starters=GetStartersByID(id);
            startersList.Remove(starters);
        }

        public Starters GetStartersByID(Guid id)
        {
            return startersList.SingleOrDefault(x=>x.Id==id);
        }

        public List<Starters> GetStarters()
        {
            return startersList;
        }

        public void UpdateStarters(Starters starters)
        {
            var getOld = GetStartersByID(starters.Id);
            getOld.Name = starters.Name;
            getOld.Price=starters.Price;
        }
    }
}