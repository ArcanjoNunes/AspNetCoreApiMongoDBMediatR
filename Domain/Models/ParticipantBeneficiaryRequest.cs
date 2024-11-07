namespace AspNetCoreApiMongoDBMediatR.Domain.Models;

public class ParticipantBeneficiaryRequest
{
    public string ParticipantId { get; set; } = default!;
    public string[] BeneficiaryIds { get; set; } = default!;
}
