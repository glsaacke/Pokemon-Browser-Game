namespace api.Core.User
{
    public class User
    {
        public int? UserId { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool deleted { get; set; }
    }
}