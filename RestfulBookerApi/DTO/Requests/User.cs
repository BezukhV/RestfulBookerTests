namespace RestfulBookerApi.DTO.Requests
{
    public class User
    {
        public User(string name, string password)
        {
            username = name;
            this.password = password;
        }

        public string username { get; set; }
        public string password { get; set; }
    }
}
