global using System.Xml.Linq;
global using System.Reflection;

global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Mvc;

global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Options;

global using MongoDB.Bson;
global using MongoDB.Bson.Serialization.Attributes;
global using MongoDB.Driver;

global using MediatR;

global using AspNetCoreApiMongoDBMediatR.Domain.Entities;
global using AspNetCoreApiMongoDBMediatR.Domain.Models;

global using AspNetCoreApiMongoDBMediatR.Application;
global using AspNetCoreApiMongoDBMediatR.Application.DBContext;

global using AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Commands.Create;
global using AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Commands.Delete;
global using AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Commands.Update;
global using AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Queries.Get;
global using AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Queries.List;
global using AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Commands.BeneficiaryAdd;
global using AspNetCoreApiMongoDBMediatR.Infra.Services.Participants.Commands.BeneficiaryDelete;

global using AspNetCoreApiMongoDBMediatR.Infra.Services.Beneficiaries.Commands.Create;
global using AspNetCoreApiMongoDBMediatR.Infra.Services.Beneficiaries.Commands.Delete;
global using AspNetCoreApiMongoDBMediatR.Infra.Services.Beneficiaries.Commands.Update;
global using AspNetCoreApiMongoDBMediatR.Infra.Services.Beneficiaries.Queries.Get;
global using AspNetCoreApiMongoDBMediatR.Infra.Services.Beneficiaries.Queries.List;

global using AspNetCoreApiMongoDBMediatR.WebApi;
