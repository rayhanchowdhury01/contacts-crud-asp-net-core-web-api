namespace ContactsAPI.Models
{
    public class AddCotactRequest
    {
        public string fullName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
    }
}
