namespace BlazorCRUDApp.Data
{
    public interface IPrincipalDishService
    {
       public List<PrincipalDish> GetPrincipalDish();

       public PrincipalDish GetPrincipalDishByID(Guid id);

       public void UpdatePrincipalDish(PrincipalDish principalDish);

       public void AddPrincipalDish(PrincipalDish principalDish);

       public void DeletePrincipalDish(Guid id);

    }
}