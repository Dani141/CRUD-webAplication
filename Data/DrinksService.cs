namespace BlazorCRUDApp.Data
{
    public class DrinksService : IDrinksService
    {
       private List<Drinks> drinksList= new List<Drinks>{
        new Drinks{
            Id = Guid.NewGuid(),
            Name = " OSHIRUKO",
            Price= 6
        },
        new Drinks{
            Id = Guid.NewGuid(),
            Name = "CALPIS",
            Price=5
        },
        new Drinks{
            Id = Guid.NewGuid(),
            Name = "KINAKO MOCHI",
            Price=5
        },
       } ;

        public void AddDrinks(Drinks drinks)
        {
            var id=Guid.NewGuid();
            drinks.Id=id;
            drinksList.Add(drinks);
        }

        public void DeleteDrinks(Guid id)
        {
            var drinks=GetDrinksByID(id);
            drinksList.Remove(drinks);
        }

        public Drinks GetDrinksByID(Guid id)
        {
            return drinksList.SingleOrDefault(x=>x.Id==id);
        }

        public List<Drinks> GetDrinks()
        {
            return drinksList;
        }

        public void UpdateDrinks(Drinks drinks)
        {
            var getOld = GetDrinksByID(drinks.Id);
            getOld.Name = drinks.Name;
            getOld.Price=drinks.Price;
        }
    }
}