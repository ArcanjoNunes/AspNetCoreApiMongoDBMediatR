namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Beneficiaries.Commands.Create;

public record CreateBeneficiaryCommand(Beneficiary beneficiary) : IRequest<Beneficiary>;