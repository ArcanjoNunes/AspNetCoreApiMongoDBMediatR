﻿namespace AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Commands.BeneficiaryAdd;

public record ParticipantBeneficiaryAddCommand(ParticipantBeneficiaryRequest pbRequest) : IRequest<IResult>;