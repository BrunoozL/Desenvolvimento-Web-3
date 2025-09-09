using MongoDbGenericRepository.Attributes;
using AspNetCore.Identity.MongoDbCore.Models;

namespace aula_02_09.Models
{
    [CollectionName("Users")]
    public class ApplicationUser: MongoIdentityUser<Guid>
    {
        public string NomeCompleto { get; set; }
    }
}
