namespace AspNetCoreApiMongoDBMediatR.WebApi;

public static class BeneficiaryEndpoints
{
    public static void MapBeneficiaryEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("api/beneficiary");

        group.MapPost("/add", AddBeneficiary);
        group.MapPost("/update", UpdateBeneficiary);
        group.MapPost("/delete", DeleteBeneficiary);
        group.MapPost("/select", SelectBeneficiary);
        group.MapPost("/list", GetAllBeneficiary);
    }

    public static async Task<IResult>
        AddBeneficiary(Beneficiary beneficiary, ISender mediatr)
    {
        var createdBeneficiary = await mediatr.Send(new CreateBeneficiaryCommand(beneficiary));
        return createdBeneficiary is null ? TypedResults.NotFound() : TypedResults.Ok(createdBeneficiary);
    }

    public static async Task<IResult>
        UpdateBeneficiary(Beneficiary beneficiary, ISender mediatr)
    {
        var updateResult = await mediatr.Send(new UpdateBeneficiaryCommand(beneficiary));
        return TypedResults.Ok(updateResult);
    }

    public static async Task<IResult>
        DeleteBeneficiary(BeneficiaryRequest beneficiaryRequest, ISender mediatr)
    {
        var deleteResult = await mediatr.Send(new DeleteBeneficiaryCommand(beneficiaryRequest.Id));
        return TypedResults.Ok(deleteResult);
    }

    public static async Task<IResult>
        SelectBeneficiary(BeneficiaryRequest beneficiaryRequest, ISender mediatr)
    {
        var selectedPaticipant = await mediatr.Send(new GetBeneficiaryQuery(beneficiaryRequest));
        return selectedPaticipant is null ? TypedResults.NotFound() : TypedResults.Ok(selectedPaticipant);
    }

    public static async Task<IResult>
        GetAllBeneficiary(ISender mediatr)
    {
        var beneficiarys = await mediatr.Send(new ListBeneficiaryQuery());
        return beneficiarys is null ? TypedResults.NotFound() : TypedResults.Ok(beneficiarys);
    }
}
