using RoadMapApp.Models.Enums;
using RoadMapApp.utils.Module;

namespace RoadMapApp.Models;

public class User:BaseModule<User>
{
    public string Fullname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; }
    public Role Role { get; set; }
}