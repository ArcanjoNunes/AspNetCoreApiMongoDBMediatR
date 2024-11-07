namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Beneficiaries.Queries.Get;

public record GetBeneficiaryQuery(BeneficiaryRequest request) : IRequest<Beneficiary>;