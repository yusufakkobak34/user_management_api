using System;
using AspNetCore.Identity.MongoDbCore.Models;

namespace user_management.Models
{
    public class ApplicationUser : MongoIdentityUser<Guid>
    {

    }
}

