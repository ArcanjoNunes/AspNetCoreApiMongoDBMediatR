namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Beneficiaries.Commands.Update;

public record UpdateBeneficiaryCommand(Beneficiary beneficiary) : IRequest<ReplaceOneResult>;