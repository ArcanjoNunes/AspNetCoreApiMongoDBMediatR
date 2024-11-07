namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Beneficiaries.Queries.Get;

public class GetBeneficiaryQueryHandler(DBCollection context) 
    : IRequestHandler<GetBeneficiaryQuery, Beneficiary?>
{
    public async Task<Beneficiary?> Handle(GetBeneficiaryQuery request, CancellationToken cancellationToken)
    {
        var filter = Builders<Beneficiary>.Filter.Eq(s => s.Id, request.request.Id);
        var beneficiary = await context._beneficiaryCollection.Find(filter)
                                                              .FirstOrDefaultAsync();
        return beneficiary;
    }
}
