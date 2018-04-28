using Crm.Entities.Interfaces;

namespace Crm.Entities
{
    public class Customer: ICustomer
    {
        public int id { get; set; }
        public string Name { get; set; }

     
    }
}
