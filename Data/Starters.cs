namespace BlazorCRUDApp.Data
{
    public class Starters
    {
        private string name ="";
        public Guid Id { get; set; }
        public String Name { get => name; set => name = value; }
        public float Price { get; set; }
    }
}