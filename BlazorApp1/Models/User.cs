namespace BlazorApp1.Models
{
    public class User
    {
        public String id { get; set; }
        public String email { get; set; }

        public String password { get; set; }

        public String role { get; set; }


        public User(String _id, String _email, String _password, String _role)
        {

            this.id = _id;
            this.email = _email;
            this.password = _password;
            this.role = _role;

        }



    }
}
