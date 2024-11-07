namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Queries.Get;

public record GetParticipantQuery(ParticipantRequest request) : IRequest<Participant>;