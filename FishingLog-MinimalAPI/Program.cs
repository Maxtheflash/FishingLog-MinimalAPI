using FishingLogMinimalApi.Data;
using FishingLogMinimalApi.Models;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


// Minimal API Endpoints

// GET /catches - Get all catch records
app.MapGet("/catches", () =>
{
    return Results.Ok(CatchRepository.GetAll());
})
.WithName("GetAllCatches");

// GET /catches/{id} - Get a catch by ID
app.MapGet("/catches/{id:int}", (int id) =>
{
    var record = CatchRepository.GetById(id);
    return record is not null ? Results.Ok(record) : Results.NotFound();
})
.WithName("GetCatchById");

// POST /catches - Add a new catch
app.MapPost("/catches", (CatchRecord newRecord) =>
{
    if (newRecord.DateCaught == default)
        newRecord.DateCaught = DateTime.UtcNow;

    var added = CatchRepository.Add(newRecord);
    return Results.Created($"/catches/{added.Id}", added);
})
.WithName("CreateCatch");

// PUT /catches/{id} - Update an existing catch
app.MapPut("/catches/{id:int}", (int id, CatchRecord updatedRecord) =>
{
    var success = CatchRepository.Update(id, updatedRecord);
    return success ? Results.NoContent() : Results.NotFound();
})
.WithName("UpdateCatch");

// DELETE /catches/{id} - Delete a catch
app.MapDelete("/catches/{id:int}", (int id) =>
{
    var success = CatchRepository.Delete(id);
    return success ? Results.NoContent() : Results.NotFound();
})
.WithName("DeleteCatch");

app.Run();
