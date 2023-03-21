namespace View.Model
{
    public class Contact
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public Contact()
        {

        }

        public Contact(string name, string email, int phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
