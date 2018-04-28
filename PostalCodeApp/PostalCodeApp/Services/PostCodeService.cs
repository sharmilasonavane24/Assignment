using System;
using System.Collections.Generic;
using System.Linq;
using PostalCodeApp.Wrappers;

namespace PostalCodeApp.Services
{
    public class PostCodeService:IPostCodeService
    {
        private readonly IFileIo _fileIo;
        private readonly IDirectoryWrapper _directory;
        private readonly IPostCodeValidationService _postCodeValidationService;

        public PostCodeService(IFileIo fileIo, IDirectoryWrapper directory, IPostCodeValidationService postCodeValidationService)
        {
            if (fileIo == null) throw new ArgumentNullException(nameof(fileIo));
            if (directory == null) throw new ArgumentNullException(nameof(directory));
            if (postCodeValidationService == null) throw new ArgumentNullException(nameof(postCodeValidationService));
            _fileIo = fileIo;
            _directory = directory;
            _postCodeValidationService = postCodeValidationService;
        }

        public List<string> GetPostCodeLines(string path)
        {

            var postalCodeLines=new List<string>();
            var files = _directory.GetFiles(path);
            foreach (var file in files)
            {
                var lines  = _fileIo.ReadAllLines(file).ToList();
                foreach (var line in lines)
                {
                    var words = line.Split(' ');

                    for (var i = 0; i < words.Length; i++)
                    {
                        var postCodeDigit = new string(words[i].Where(char.IsDigit).ToArray());
                       
                        if (postCodeDigit.Length == 4 && i != words.Length)
                        {
                            var postCodeAlphabets = new string(words[i + 1].Where(char.IsLetter).ToArray());
                            if (postCodeAlphabets.Length == 2)
                            {
                                var postalCode = $"{postCodeDigit}{postCodeAlphabets}";
                                // Validate Postal code
                                var isValidPostalCode = _postCodeValidationService.Validate(postalCode);
                                if (isValidPostalCode)
                                {
                                    postalCodeLines.Add(line);
                                    break;
                                }
                            }

                        }

                    }
                }
            }

            return postalCodeLines;
        }
    }
}