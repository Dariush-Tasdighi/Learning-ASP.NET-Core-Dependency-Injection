// **************************************************
// Default
// **************************************************
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//app.MapGet(pattern: "/", handler: () => "Hello World!");

//app.Run();
// **************************************************


// **************************************************
// Learn 01
// **************************************************
//using Infrastructure.Learn01;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder = WebApplication.CreateBuilder(args: args);

//var app = builder.Build();

//// **********
//// Compile Error!
//// **********
////var myClass2 = new Class2();
//// **********

//// **********
//var myClass1 = new Class1();
//var myClass2 = new Class2(class1: myClass1);
//// **********

//app.Run(async context =>
//{
//	await context.Response.WriteAsync(text: "Hello World!");
//});

//app.Run();
// **************************************************


// **************************************************
// Learn 02
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder = WebApplication.CreateBuilder(args: args);

//builder.Services.AddRazorPages();

//var app = builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************


// **************************************************
// Learn 03
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder = WebApplication.CreateBuilder(args: args);

//builder.Services.AddRazorPages();

//var app = builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************


// **************************************************
// https://docs.microsoft.com/en-us/aspnet/core/mvc/views/dependency-injection
// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection
// https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/dependency-injection
// **************************************************


// **************************************************
// Learn 04 / 01
// **************************************************
//using Infrastructure.Learn04;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder = WebApplication.CreateBuilder(args: args);

//builder.Services.AddRazorPages();

//builder.Services.AddSingleton<Class1>();

//var app = builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************


// **************************************************
// Learn 04 / 02
// **************************************************
//using Infrastructure.Learn04;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder = WebApplication.CreateBuilder(args: args);

//builder.Services.AddRazorPages();

//// **********
//// می‌شود Reset در صورتی که پروژه را متوقف کنیم و دوباره اجرا کنیم، همه چیز
//// باشد Stateless ثبت می‌کنیم که Singleton معمولا کلاسی را
//// **********
//// دستورات ذیل، نسبت به دستورات مدل یا شکل بعدی، صرفا شیک‌تر می‌باشند
//// **********
//builder.Services.AddSingleton<Class1>();
////builder.Services.AddScoped<Class1>();
////builder.Services.AddTransient<Class1>();
//// **********

//// **********
////builder.Services.AddSingleton(serviceType: typeof(Class1));
////builder.Services.AddScoped(serviceType: typeof(Class1));
////builder.Services.AddTransient(serviceType: typeof(Class1));
//// **********

//var app = builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************


// **************************************************
// Learn 04 / 03
// **************************************************
//using Infrastructure.Learn04;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder = WebApplication.CreateBuilder(args: args);

//builder.Services.AddRazorPages();

//builder.Services.AddSingleton<Class1>();
//builder.Services.AddSingleton<Class2>();

//var app = builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************


// **************************************************
// Learn 04 / 03
// **************************************************
//using Infrastructure.Learn04;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder = WebApplication.CreateBuilder(args: args);

//builder.Services.AddRazorPages();

//builder.Services.AddSingleton<Class2>();

////builder.Services.AddSingleton<Class1>();
//builder.Services.AddSingleton<Class1>(options =>
//{
//	var result = new Class1
//	{
//		MyValue = 20,
//	};

//	return result;
//});

//var app = builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************


// **************************************************
// Learn 05
// **************************************************
//using Infrastructure.Learn05;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder = WebApplication.CreateBuilder(args: args);

//builder.Services.AddRazorPages();

//// **********
//// دستورات ذیل، نسبت به دستورات مدل یا شکل بعدی، صرفا شیک‌تر می‌باشند
//// **********
//builder.Services.AddSingleton<Interface1, Class1_1>();
////builder.Services.AddSingleton<Interface1, Class1_2>();
//// **********

//// **********
////builder.Services.AddSingleton
////	(serviceType: typeof(Interface1), implementationType: typeof(Class1_1));
////builder.Services.AddSingleton
////	(serviceType: typeof(Interface1), implementationType: typeof(Class1_2));
//// **********

//var app = builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************


// **************************************************
// Learn 06
// **************************************************
//using Infrastructure.Learn06;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddRazorPages();

//builder.Services.AddSingleton<Interface1, Class1>();
//builder.Services.AddSingleton<Interface2, Class2>();

//var app = builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************


// **************************************************
// Learn 07
// **************************************************
//using Infrastructure.Learn07;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddRazorPages();

//builder.Services.AddSingleton<ILogger, LogToFile>();
////builder.Services.AddSingleton<ILogger, LogByEmail>();
////builder.Services.AddSingleton<ILogger, LogToDatabase>();

//var app = builder.Build();

//app.MapRazorPages();

//app.Run();
// **************************************************
