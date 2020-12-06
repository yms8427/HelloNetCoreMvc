namespace Hello.Web.Models
{
    public class Package
    {
        public Package(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }
        public int Storage { get; set; }
        public int Price { get; set; }
        public int UserCount { get; set; }
        public string SupportType { get; set; }
    }
}