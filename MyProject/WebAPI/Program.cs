using Autofac.Core;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Business.DependencyResolvers.Autofac;
using Autofac.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// .NET Core'un kendi DI konteynerini kullanmak yerine Autofac'i kullan
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
// Autofac modüllerini buradan yükle
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    // Business layer modülünü ekleyin
    containerBuilder.RegisterModule(new AutofacBusinessModule());
});

// Add services to the container.
//AOP
//Autofac --> IoC Container
builder.Services.AddControllers();
//builder.Services.AddSingleton<IProductService,ProductManager>();
//builder.Services.AddSingleton<IProductDal,EfProductDal>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();
