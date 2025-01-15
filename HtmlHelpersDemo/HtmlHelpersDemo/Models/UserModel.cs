namespace HtmlHelpersDemo.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public List<string> Skills { get; set; }
        public string HiddenField { get; set; }
    }
}