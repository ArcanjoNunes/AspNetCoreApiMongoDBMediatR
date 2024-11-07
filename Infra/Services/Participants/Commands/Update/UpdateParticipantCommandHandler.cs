namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Commands.Update;

public class UpdateBeneficiaryCommandHandler(DBCollection context) 
    : IRequestHandler<UpdateParticipantCommand, ReplaceOneResult>
{
    public async Task<ReplaceOneResult> Handle(UpdateParticipantCommand command, CancellationToken cancellationToken)
    {
        var updateResult = await context._participantCollection
                                        .ReplaceOneAsync(s => s.Id == command.participant.Id, command.participant);
        return updateResult;
    }
}
