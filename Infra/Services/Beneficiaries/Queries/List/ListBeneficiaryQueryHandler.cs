namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Beneficiaries.Queries.List;

public class ListBeneficiaryQueryHandler(DBCollection context) 
    : IRequestHandler<ListBeneficiaryQuery, List<Beneficiary>>
{
    public async Task<List<Beneficiary>> Handle(ListBeneficiaryQuery request, CancellationToken cancellationToken)
    {
        var beneficiarys = await context._beneficiaryCollection.Find(s => true)
                                                               .ToListAsync();
        return beneficiarys;
    }
}
