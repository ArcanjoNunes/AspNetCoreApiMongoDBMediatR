﻿global using MongoDB.Bson.Serialization.IdGenerators;

namespace AspNetCoreApiMongoDBMediatR.Domain.Entities;

public class Participant
{
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string Name { get; set; } = default!;
    public decimal Salary { get; set; } = 0.00m;

    public string AddressStreet { get; set; } = default!;
    public int AddressNumber { get; set; }
    public string AddressSupplement { get; set; } = default!;
    public string AddressZipCode { get; set; } = default!;
    public string AddressCity { get; set; } = default!;
    public string AddressState { get; set; } = default!;

    [BsonRepresentation(BsonType.ObjectId)]
    public List<string> BeneficiariesId { get; set; } = [];
    [BsonIgnore]
    public List<Beneficiary> Beneficiaries { get; set; } = [];

    public int Status { get; set; } = default!;
}
