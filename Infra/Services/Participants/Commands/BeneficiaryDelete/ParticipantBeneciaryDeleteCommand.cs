﻿namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Commands.BeneficiaryDelete;

public record ParticipantBeneficiaryDeleteCommand(ParticipantBeneficiaryRequest pbRequest) : IRequest<IResult>;