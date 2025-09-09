using MongoDbGenericRepository.Attributes;

namespace aula_02_09.Models
{
    [CollectionName("Users")]
    public class ApplicationUser
    {
        public string NomeCompleto { get; set; }
    }
}
