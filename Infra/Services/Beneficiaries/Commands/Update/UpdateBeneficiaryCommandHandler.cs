namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Beneficiaries.Commands.Update;

public class UpdateBeneficiaryCommandHandler(DBCollection context) 
    : IRequestHandler<UpdateBeneficiaryCommand, ReplaceOneResult>
{
    public async Task<ReplaceOneResult> Handle(UpdateBeneficiaryCommand command, CancellationToken cancellationToken)
    {
        var updateResult = await context._beneficiaryCollection
                                        .ReplaceOneAsync(s => s.Id == command.beneficiary.Id, command.beneficiary);
        return updateResult;
    }
}
