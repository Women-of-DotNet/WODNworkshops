var builder = WebApplication.CreateBuilder(args);

builder.Services.AddThirdPartyDependencies();
builder.Services.AddDependencies();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.AddMinimalApis();

app.Run();

