using AllForOne_Endpoint.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<AddOrEvenServices>();
builder.Services.AddScoped<AddTwoNumbersService>();
builder.Services.AddScoped<GreaterThanLessThanService>();
builder.Services.AddScoped<GuessItServices>();
builder.Services.AddScoped<MadlibServices>();
builder.Services.AddScoped<MagicEightBallServices>();
builder.Services.AddScoped<RestaurantPickerServices>();
builder.Services.AddScoped<ReverseItServices>();
builder.Services.AddScoped<ReverseNumServices>();
builder.Services.AddScoped<WakeUpNameService>();
builder.Services.AddScoped<SayHelloService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
