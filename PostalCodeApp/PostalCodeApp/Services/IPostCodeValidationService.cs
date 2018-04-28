namespace PostalCodeApp.Services
{
    public interface IPostCodeValidationService
    {
        bool Validate(string postalCode);
    }
}