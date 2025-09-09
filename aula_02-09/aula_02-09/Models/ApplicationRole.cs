using MongoDbGenericRepository.Attributes;
using AspNetCore.Identity.MongoDbCore.Models;

namespace aula_02_09.Models
{
    [CollectionName("Roles")]
    public class ApplicationRole: MongoIdentityRole<Guid>
    {
    }
}
