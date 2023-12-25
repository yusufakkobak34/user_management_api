using System;
using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace user_management.Models
{
        [CollectionName("roles")]
        public class ApplicationRole : MongoIdentityRole<Guid>
        {

        }
}

