namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Commands.BeneficiaryAdd;

public class ParticipantBeneficiaryAddCommandHandler(DBCollection context)
    : IRequestHandler<ParticipantBeneficiaryAddCommand, IResult>
{
    public async Task<IResult> Handle(ParticipantBeneficiaryAddCommand command, CancellationToken cancellationToken)
    {
        var participant = await context._participantCollection.Find(s => s.Id == command.pbRequest.ParticipantId).FirstOrDefaultAsync();
        if (participant is null) { return TypedResults.NotFound(); }

        foreach (var beneficiaryId in command.pbRequest.BeneficiaryIds)
        {
            if (participant.BeneficiariesId.Contains(beneficiaryId)) { continue; }
            participant.BeneficiariesId.Add(beneficiaryId);
        }

        var updateParticipant = await context._participantCollection.ReplaceOneAsync(u => u.Id == participant.Id, participant);
        return TypedResults.Ok(updateParticipant);
    }
}
