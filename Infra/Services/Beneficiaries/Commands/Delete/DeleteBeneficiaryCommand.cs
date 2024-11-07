namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Beneficiaries.Commands.Delete;

public record DeleteBeneficiaryCommand(string Id) : IRequest<DeleteResult>;
