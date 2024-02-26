namespace CustomerLogin
{
    public class Customerlogin
    {
        public string Login(string CustomerName, string CustomerPwd)
        {
            string result = "";
            if (CustomerName == "Raha1256" && CustomerPwd == "Raha@1256")
            {
                result = "Login Success";

            }
            else
            {
                result = "Login Failed";
            }
            return result;
        }

    }
}
