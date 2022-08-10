namespace BlazorCRUDApp.Data
{
    public class Emmployee
    {
        private string name ="";

        public Guid Id { get; set; }
        public String Name { get => name; set => name = value; }
    }
}