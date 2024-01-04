namespace DomainModels
{
    public class User : Common
    {
        public string username { get; set; }
        public string password { get; set; }
        public List<Post> posts { get; set; }
        public List<User> friends { get; set; }
    }
}
