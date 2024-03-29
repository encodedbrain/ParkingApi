using Parking_Intelligence_Api.Schemas.User;

namespace Parking_Intelligence_Api.interfaces;

public interface IUser
{
    public bool VaLidateEmail(string? email);
    public string EncryptingPassword(string? password);
    public bool ValidateName(string? name);
    public bool ValidateCpf(string? cpf);
    public string ReturnCpfFormated(string? cpf);
    public bool ValidatePhone(string? phone);
    public bool ValidatePassword(string password);
    public object Login(LoginSchema prop);
    public Task<object> Create(UserSchema prop);
    public Task<bool> Delete(LoginSchema prop);
    public bool UpdatePassword(UpdatePasswordSchema prop);
    public byte[] DownloadPhoto(DownloadPhotoIdSchema prop);

    public Task<bool> UpdatePhotoProfile(UpdatePhotoProfileSchema prop);

}