﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GAE.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<GAEContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GAEContext") ?? throw new InvalidOperationException("Connection string 'GAEContext' not found.")));

builder.Services.AddHttpClient(); // Register HttpClient

builder.Services.AddSession(); // Add session services
builder.Services.AddMemoryCache(); // Add memory cache services

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Configure the HTTP request pipeline.
app.UseSession(); // Use session middleware

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
