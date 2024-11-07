namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Beneficiaries.Commands.Delete;

public class DeleteBeneficiaryCommandHandler(DBCollection context) 
    : IRequestHandler<DeleteBeneficiaryCommand, DeleteResult>
{
    public async Task<DeleteResult> Handle(DeleteBeneficiaryCommand request, CancellationToken cancellationToken)
    {
        var deleteResult = await context._beneficiaryCollection
                                        .DeleteOneAsync(s => s.Id == request.Id);
        return deleteResult;
    }
}
