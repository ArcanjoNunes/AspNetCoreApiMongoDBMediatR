namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Queries.Get;

public class GetParticipantQueryHandler(DBCollection context)
    : IRequestHandler<GetParticipantQuery, Participant?>
{
    public async Task<Participant?> Handle(GetParticipantQuery request, CancellationToken cancellationToken)
    {
        var filter = Builders<Participant>.Filter.Eq(s => s.Id, request.request.Id);
        var participant = await context._participantCollection.Find(filter)
                                                              .FirstOrDefaultAsync();
        return participant;
    }
}
