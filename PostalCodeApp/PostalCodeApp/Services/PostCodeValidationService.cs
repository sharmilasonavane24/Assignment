using System;
using System.Net;

namespace PostalCodeApp.Services
{
    public class PostCodeValidationService : IPostCodeValidationService
    {
        public bool Validate(string postalCode)
        {
            try
            {
                using (var client1 = new WebClient())
                {
                    client1.Headers["accept"] = Constants.Accept;
                    client1.Headers["x-api-key"] = Constants.ApiKey;

                    var validationData = client1.DownloadString($"{Constants.url}{postalCode}");

                    if (validationData.Contains(Constants.EmptyAddress))
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}