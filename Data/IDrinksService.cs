namespace BlazorCRUDApp.Data
{
    public interface IDrinksService
    {
       public List<Drinks> GetDrinks();

       public Drinks GetDrinksByID(Guid id);

       public void UpdateDrinks(Drinks drinks);

       public void AddDrinks(Drinks drinks);

       public void DeleteDrinks(Guid id);

    }
}