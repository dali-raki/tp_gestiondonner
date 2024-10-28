using System.IO;
using System.Xml.Linq;
using BlazorApp1.Models;

namespace BlazorApp1.Services
{
    public class UsersService
    {


        public bool Checkuser(string namefile, string email, string password)
        {

            try
            {
                XDocument xmlDoc = XDocument.Load(namefile);
                var userXML = xmlDoc.Element("Users")?.Elements("User");


                foreach (var user in userXML)
                {
                    String idtest = user.Element("id")?.Value;
                    String emailtest = user.Element("Email")?.Value;
                    String passwordtest = user.Element("Password")?.Value;
                    String roletest = user.Element("Role")?.Value;

                    if (emailtest == email && passwordtest == password)
                    {
                        return true;
                    }


                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }



            return false;
        }


        public string getrole(string namefile, string email, string password)
        {
            string role = "No role";

            XDocument xmlDoc = XDocument.Load(namefile);
            var userXML = xmlDoc.Element("Users")?.Elements("User");

            foreach (var user in userXML)
            {
                String emailtest = user.Element("Email")?.Value;
                String passtest = user.Element("Password")?.Value;
                String roletest = user.Element("Role")?.Value;



                if (emailtest == email && passtest == password)
                {
                    role = roletest;
                    return role;
                }


            }
            Console.WriteLine(role);
            return role;

        }






    }
}
