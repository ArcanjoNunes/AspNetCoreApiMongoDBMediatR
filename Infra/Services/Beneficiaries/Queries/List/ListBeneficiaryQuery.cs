namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Beneficiaries.Queries.List;

public record ListBeneficiaryQuery : IRequest<List<Beneficiary>>;