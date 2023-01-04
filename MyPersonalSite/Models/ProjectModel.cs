namespace MyPersonalSite.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
        public string Image { get; set; }

        public ProjectModel(int id, string name, string description, string client, string image)
        {
            Id = id;
            Name = name;
            Description = description;
            Client = client;
            Image = image;
        }
    }
}
