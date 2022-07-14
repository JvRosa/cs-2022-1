namespace ExLogin
{
    public class Login
    {
        public string user { get; set; }
        public string passw { get; set; }
        public bool FazerLogin()
        {
            if (!(user == "suporte" && passw == "150398"))
            {
                throw new LoginInvalidoException();
            };
            return true;
        }
    }
}
