using System;
using PostalCodeApp.Services;
using PostalCodeApp.Wrappers;
using Unity;

namespace PostalCodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer unitycontainer = new UnityContainer();

            unitycontainer.RegisterInstance<IFileIo>(FileIo.Instance);
            unitycontainer.RegisterType<IDirectoryWrapper, DirectoryWrapper>();
            unitycontainer.RegisterType<IPostCodeService, PostCodeService>();
            unitycontainer.RegisterType<IPostCodeValidationService, PostCodeValidationService>();
            var postCodeService = unitycontainer.Resolve<PostCodeService>();
            var lines = postCodeService.GetPostCodeLines("~/../../../Data");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}
