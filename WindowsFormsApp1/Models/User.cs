namespace BeautyStoreApp.Models
{

    public abstract class User 
    {
        public string Id { get; set; } = string.Empty; 
        public string Password { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Role { get; protected set; } = string.Empty;

        public abstract void DisplayDashboard(); 
    }
}