namespace BlazorCRUDApp.Data
{
    public class PrincipalDishService : IPrincipalDishService
    {
       private List<PrincipalDish> principalDishList= new List<PrincipalDish>{
        new PrincipalDish{
            Id = Guid.NewGuid(),
            Name = "Pork Fajitas in Tonkatsu Sauce",
            Price= 19
        },
        new PrincipalDish{
            Id = Guid.NewGuid(),
            Name = "Squid Teriyaki",
            Price=15
        },
        new PrincipalDish{
            Id = Guid.NewGuid(),
            Name = "Suchis",
            Price=15
        },
       } ;

        public void AddPrincipalDish(PrincipalDish principalDish)
        {
            var id=Guid.NewGuid();
            principalDish.Id=id;
            principalDishList.Add(principalDish);
        }

        public void DeletePrincipalDish(Guid id)
        {
            var principalDish=GetPrincipalDishByID(id);
            principalDishList.Remove(principalDish);
        }

        public PrincipalDish GetPrincipalDishByID(Guid id)
        {
            return principalDishList.SingleOrDefault(x=>x.Id==id);
        }

        public List<PrincipalDish> GetPrincipalDish()
        {
            return principalDishList;
        }

        public void UpdatePrincipalDish(PrincipalDish principalDish)
        {
            var getOld = GetPrincipalDishByID(principalDish.Id);
            getOld.Name = principalDish.Name;
            getOld.Price=principalDish.Price;
        }
    }
}