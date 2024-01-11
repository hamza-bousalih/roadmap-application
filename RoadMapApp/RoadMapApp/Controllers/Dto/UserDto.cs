using RoadMapApp.Models.Enums;
using RoadMapApp.utils.Dto;

namespace RoadMapApp.Controllers.Dto;

public class UserDto: BaseDto
{
    public string Fullname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public Role Role { get; set; }
}