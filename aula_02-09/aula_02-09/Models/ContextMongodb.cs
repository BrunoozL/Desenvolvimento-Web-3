using MongoDB.Driver;

namespace aula_02_09.Models
{
    public class ContextMongodb
    {
        public static string ConnectionString {  get; set; }
        public static string DatabaseName { get; set; }
        public static bool Isssl { get; set; }
        public IMongoDatabase _database { get; }

        // Método Construtor
        public ContextMongodb()
        {
            try
            {
                MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(ConnectionString));
                if(Isssl)
                {
                    settings.SslSettings = new SslSettings
                    {
                        EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12
                    };
                }
                var mongoClient = new MongoClient(settings);
                _database = mongoClient.GetDatabase(DatabaseName);
            }
            catch(Exception)
            {
                throw new Exception("Não foi possível conectar ao MongoDB");
            }
        }
    }
}
