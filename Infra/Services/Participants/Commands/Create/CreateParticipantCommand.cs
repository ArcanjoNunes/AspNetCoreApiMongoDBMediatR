namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Commands.Create;

public record CreateParticipantCommand(Participant participant) : IRequest<Participant>;