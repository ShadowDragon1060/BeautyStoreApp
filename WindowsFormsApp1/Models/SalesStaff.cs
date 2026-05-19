using BeautyStoreApp.Models;
using System.Data;

public class SalesStaff : User 
{
    public SalesStaff() { Role = "SalesStaff"; }
    public override void DisplayDashboard() {  }
}