namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Commands.Delete;

public record DeleteParticipantCommand(string Id) : IRequest<DeleteResult>;
