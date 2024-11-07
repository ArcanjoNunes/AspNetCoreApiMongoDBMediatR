namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Commands.Delete;

public class DeleteParticipantCommandHandler(DBCollection context) 
    : IRequestHandler<DeleteParticipantCommand, DeleteResult>
{
    public async Task<DeleteResult> Handle(DeleteParticipantCommand request, CancellationToken cancellationToken)
    {
        var deleteResult = await context._participantCollection
                                        .DeleteOneAsync(s => s.Id == request.Id);
        return deleteResult;
    }
}
