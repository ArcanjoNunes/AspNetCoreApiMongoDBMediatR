namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Commands.Create;

public class CreateParticipantCommandHandler(DBCollection context) 
    : IRequestHandler<CreateParticipantCommand, Participant>
{
    public async Task<Participant> Handle(CreateParticipantCommand command, CancellationToken cancellationToken)
    {
        command.participant.Id = MongoDB.Bson.ObjectId.GenerateNewId().ToString();
        await context._participantCollection.InsertOneAsync(command.participant);
        return command.participant;
    }
}
