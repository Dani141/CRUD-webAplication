namespace BlazorCRUDApp.Data
{
    public class Starters
    {
        private string name ="";

        private float price=0;

        public Guid Id { get; set; }
        public String Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
    }
}