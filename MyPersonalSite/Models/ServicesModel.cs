namespace MyPersonalSite.Models
{
    public class ServicesModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ServicesModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
