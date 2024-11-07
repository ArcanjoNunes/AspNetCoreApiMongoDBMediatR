namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Commands.BeneficiaryDelete;

public class ParticipantBeneficiaryDeleteCommandHandler(DBCollection context)
    : IRequestHandler<ParticipantBeneficiaryDeleteCommand, IResult>
{
    public async Task<IResult> Handle(ParticipantBeneficiaryDeleteCommand command, CancellationToken cancellationToken)
    {
        var participant = await context._participantCollection.Find(s => s.Id == command.pbRequest.ParticipantId).FirstOrDefaultAsync();
        if (participant is null) { return TypedResults.NotFound(); }

        foreach (var beneficiaryId in command.pbRequest.BeneficiaryIds)
        {
            if (participant.BeneficiariesId.Contains(beneficiaryId))
            {
                participant.BeneficiariesId.Remove(beneficiaryId);
            }
        }

        var updateParticipant = await context._participantCollection.ReplaceOneAsync(u => u.Id == participant.Id, participant);
        return TypedResults.Ok(updateParticipant);
    }
}
