using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using SimplyBooksAPI.Data;
using SimplyBooksAPI.Endpoints;
using SimplyBooksAPI.Services;
using SimplyBooksAPI.Interfaces;
using SimplyBooksAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);


// allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// allows our api endpoints to access the database through Entity Framework Core
builder.Services.AddNpgsql<SimplyBooksAPIDbContext>(builder.Configuration["SimplyBooksAPIConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IBookRepository, BookRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapBookEndpoints();

app.Run();
