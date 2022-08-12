namespace BlazorCRUDApp.Data
{
    public interface IDessertsService
    {
       public List<Desserts> GetDesserts();

       public Desserts GetDessertsByID(Guid id);

       public void UpdateDesserts(Desserts desserts);

       public void AddDesserts(Desserts desserts);

       public void DeleteDesserts(Guid id);

    }
}