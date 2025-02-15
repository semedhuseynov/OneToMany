﻿using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.Options;
using OneToMany.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<AppDbContext>(options =>
      options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));


var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();

