using System.Collections.Generic;

namespace PostalCodeApp.Services
{
    public interface IPostCodeService
    {
        List<string> GetPostCodeLines(string path);
    }
}