namespace ConsoleWebAPI
{
    public class Users
    {
        public int UserID { get; set; }        
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }   

        public override string ToString() => string.Format($"{Name} - {Email}");
    }   
}