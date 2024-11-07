namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Commands.Update;

public record UpdateParticipantCommand(Participant participant) : IRequest<ReplaceOneResult>;