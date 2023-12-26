using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace user_management.Models
{
    [CollectionName("Users")]
    public class ApplicationUser : MongoIdentityUser<Guid>
    {
        public string FullName { get; set; } = string.Empty;
    }
}

