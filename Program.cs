using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo 
    {
        Version = "v1",
        Title = "Healthcare Appointment System",
        Description = "The Healthcare Appointment System is designed to streamline the scheduling and management of appointments" +
                      "between patients and healthcare providers. <br /> This system offers a convenient way for users to book appointments, receive reminders, and manage their medical records. <br />" +
                      "Healthcare providers can efficiently schedule appointments, access patient records, and send appointment reminders.",
        Contact = new OpenApiContact
        {
            Name = "Šimon Pavlík",
            Email = "sampleemail@gmail.com"
        }
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
} else {
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
