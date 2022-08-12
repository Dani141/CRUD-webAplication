namespace BlazorCRUDApp.Data
{
    public class Drinks
    {
        private string name ="";
        public Guid Id { get; set; }
        public String Name { get => name; set => name = value; }
        public float Price { get; set; }
    }
}