using BeautyStoreApp.Models;
using System.Data;

public class Admin : User 
{
    public Admin() { Role = "Admin"; }
    public override void DisplayDashboard() { }
}