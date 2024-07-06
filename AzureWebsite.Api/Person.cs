using System;

namespace AzureWebsite.Api.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public string PhoneNumber { get; set; }
    }
}
