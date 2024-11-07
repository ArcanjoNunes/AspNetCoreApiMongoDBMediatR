namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Beneficiaries.Commands.Create;

public class CreateBeneficiaryCommandHandler(DBCollection context)
    : IRequestHandler<CreateBeneficiaryCommand, Beneficiary>
{
    public async Task<Beneficiary> Handle(CreateBeneficiaryCommand command, CancellationToken cancellationToken)
    {
        command.beneficiary.Id = ObjectId.GenerateNewId().ToString();
        await context._beneficiaryCollection.InsertOneAsync(command.beneficiary);
        return command.beneficiary;
    }
}
