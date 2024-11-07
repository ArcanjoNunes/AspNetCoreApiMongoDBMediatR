namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Queries.List;

public class ListParticipantQueryHandler(DBCollection context) 
    : IRequestHandler<ListParticipantQuery, List<Participant>>
{
    public async Task<List<Participant>> Handle(ListParticipantQuery request, CancellationToken cancellationToken)
    {
        var participants = await context._participantCollection.Find(s => true)
                                                               .ToListAsync();
        return participants;
    }
}
