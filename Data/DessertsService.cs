namespace BlazorCRUDApp.Data
{
    public class DessertsService : IDessertsService
    {
       private List<Desserts> dessertsList= new List<Desserts>{
        new Desserts{
            Id = Guid.NewGuid(),
            Name = "Mochi",
            Price= 6
        },
        new Desserts{
            Id = Guid.NewGuid(),
            Name = "Anmitsu",
            Price=5
        },
       } ;

        public void AddDesserts(Desserts desserts)
        {
            var id=Guid.NewGuid();
            desserts.Id=id;
            dessertsList.Add(desserts);
        }

        public void DeleteDesserts(Guid id)
        {
            var desserts=GetDessertsByID(id);
            dessertsList.Remove(desserts);
        }

        public Desserts GetDessertsByID(Guid id)
        {
            return dessertsList.SingleOrDefault(x=>x.Id==id);
        }

        public List<Desserts> GetDesserts()
        {
            return dessertsList;
        }

        public void UpdateDesserts(Desserts desserts)
        {
            var getOld = GetDessertsByID(desserts.Id);
            getOld.Name = desserts.Name;
            getOld.Price=desserts.Price;
        }
    }
}