namespace Parking_Intelligence_Api.Models;

public class UserData
{
    public UserData(string? fullName, string? cpf, string? address, string? phone)
    {
        FullName = fullName;
        Cpf = cpf;
        Address = address;
        Phone = phone;
    }

    public UserData()
    {
    }


    public int Id { get; set; }
    public string? FullName { get; internal set; }
    public string? Cpf { get; internal set; }
    public string? Address { get; internal set; }
    public string? Phone { get; internal set; }
    public int UserId { get; internal set; }
    public User User { get; internal set; } = null!;
}