using System;

namespace AzureWebsite.Api.Models
{
    namespace AzureWebsite.Api.Models
    {
        public class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; } = string.Empty;
            public string LastName { get; set; } = string.Empty;
            public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
            public string PhoneNumber { get; set; } = string.Empty;
        }
    }

}
