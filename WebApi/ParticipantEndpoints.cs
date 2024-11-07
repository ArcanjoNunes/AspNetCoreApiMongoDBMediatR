namespace AspNetCoreApiMongoDBMediatR.WebApi;

public static class ParticipantEndpoints
{
    public static void MapParticipantEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/participant");

        group.MapPost("/add", AddParticipant);
        group.MapPost("/update", UpdateParticipant);
        group.MapPost("/delete", DeleteParticipant);
        group.MapPost("/select", SelectParticipant);
        group.MapPost("/list", GetAllParticipant);

        var groupbp = app.MapGroup("api/participantbeneficiary");

        groupbp.MapPost("/add", AddParticipantBeneficiary);
        groupbp.MapPost("/delete", DeleteParticipantBeneficiary);
    }

    #region Participant

    public static async Task<IResult>
        AddParticipant(Participant participant, ISender mediatr)
    {
        var createdParticipant = await mediatr.Send(new CreateParticipantCommand(participant));
        return createdParticipant is null ? TypedResults.NotFound() : TypedResults.Ok(createdParticipant);
    }

    public static async Task<IResult>
        UpdateParticipant(Participant participant, ISender mediatr)
    {
        var updateResult = await mediatr.Send(new UpdateParticipantCommand(participant));
        return TypedResults.Ok(updateResult);
    }

    public static async Task<IResult>
        DeleteParticipant(ParticipantRequest participantRequest, ISender mediatr)
    {
        var deleteResult = await mediatr.Send(new DeleteParticipantCommand(participantRequest.Id));
        return TypedResults.Ok(deleteResult);
    }

    public static async Task<IResult>
        SelectParticipant(ParticipantRequest participantRequest, ISender mediatr)
    {
        var selectedPaticipant = await mediatr.Send(new GetParticipantQuery(participantRequest));
        return selectedPaticipant is null ? TypedResults.NotFound() : TypedResults.Ok(selectedPaticipant);
    }

    public static async Task<IResult>
        GetAllParticipant(ISender mediatr)
    {
        var participants = await mediatr.Send(new ListParticipantQuery());
        return participants is null ? TypedResults.NotFound() : TypedResults.Ok(participants);
    }

    #endregion

    #region Participant - Beneficiary

    public static async Task<IResult>
        AddParticipantBeneficiary(ParticipantBeneficiaryRequest pbRequest, ISender mediatr)
    {
        var createdBP = await mediatr.Send(new ParticipantBeneficiaryAddCommand(pbRequest));
        return createdBP;
    }

    public static async Task<IResult>
        DeleteParticipantBeneficiary(ParticipantBeneficiaryRequest pbRequest, ISender mediatr)
    {
        var deleteResult = await mediatr.Send(new ParticipantBeneficiaryDeleteCommand(pbRequest));
        return deleteResult;
    }

    #endregion
}
