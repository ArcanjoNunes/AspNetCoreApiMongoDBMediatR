namespace AspNetCoreApiMongoDBMediatR.Application.DBContext;

public class DBCollection
{
    public readonly IMongoCollection<Participant> _participantCollection;
    public readonly IMongoCollection<Beneficiary> _beneficiaryCollection;

    public DBCollection(IOptions<MongoDBDatabaseSettings> mongoDBDatabaseSettings, IMongoClient mongoClient)
    {
        var database = mongoClient.GetDatabase(mongoDBDatabaseSettings.Value.DatabaseName);
        _participantCollection = database.GetCollection<Participant>(mongoDBDatabaseSettings.Value.ParticipantsCollectionName);
        _beneficiaryCollection = database.GetCollection<Beneficiary>(mongoDBDatabaseSettings.Value.BeneficiariesCollectionName);
    }
}
