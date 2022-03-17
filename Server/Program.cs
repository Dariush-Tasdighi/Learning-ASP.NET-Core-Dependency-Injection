// **************************************************
// **************************************************
// **************************************************
// Default
// **************************************************
using Microsoft.AspNetCore.Builder;

var builder =
	Microsoft.AspNetCore.Builder
	.WebApplication.CreateBuilder(args);

var app =
	builder.Build();

// MapGet() -> using Microsoft.AspNetCore.Builder;
app.MapGet("/", () => "Hello World!");

app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 01
// **************************************************
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//var app =
//	builder.Build();

//// **************************************************
//// Compile Error!
////var class2 =
////	new Infrastructure.Learn01.Class2();
//// **************************************************

//// **************************************************
//var class1 =
//	new Infrastructure.Learn01.Class1();

//var class2 =
//	new Infrastructure.Learn01.Class2(class1: class1);
//// **************************************************

//// Run() -> using Microsoft.AspNetCore.Builder;
//app.Run(async context =>
//{
//	// WriteAsync() -> using Microsoft.AspNetCore.Http;
//	await context.Response.WriteAsync("Hello World!");
//});

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 02
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
//builder.Services.AddRazorPages();

//var app =
//	builder.Build();

//// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
//app.MapRazorPages();

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 03
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
//builder.Services.AddRazorPages();

//var app =
//	builder.Build();

//// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
//app.MapRazorPages();

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 04
// **************************************************
// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection
//
// https://docs.microsoft.com/en-us/aspnet/core/mvc/views/dependency-injection
// https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/dependency-injection
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
//builder.Services.AddRazorPages();

//// **************************************************
//// می‌شود Reset در صورتی که پروژه را متوقف کنیم و دوباره اجرا کنیم، همه چیز
//builder.Services.AddSingleton
//	<Infrastructure.Learn04.Class1>();

////builder.Services.AddScoped
////	<Infrastructure.Learn04.Class1>();

////builder.Services.AddTransient
////	<Infrastructure.Learn04.Class1>();
//// **************************************************

//// **************************************************
////builder.Services.AddSingleton
////	(typeof(Infrastructure.Learn04.Class1));

////builder.Services.AddScoped
////	(typeof(Infrastructure.Learn04.Class1));

////builder.Services.AddTransient
////	(typeof(Infrastructure.Learn04.Class1));
//// **************************************************

//// **************************************************
////builder.Services.AddSingleton
////	<Infrastructure.Learn04.Class1>(options =>
////	{
////		var result =
////			new Infrastructure.Learn04.Class1
////			{
////				MyValue = 20,
////			};

////		return result;
////	});
//// **************************************************

//// **************************************************
////builder.Services.AddSingleton
////	(typeof(Infrastructure.Learn04.Class1), options =>
////	{
////		var result =
////			new Infrastructure.Learn04.Class1
////			{
////				MyValue = 20,
////			};

////		return result;
////	});
//// **************************************************

//var app =
//	builder.Build();

//// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
//app.MapRazorPages();

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 05
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
//builder.Services.AddRazorPages();

//// **************************************************
//builder.Services.AddSingleton
//	<Infrastructure.Learn05.Interface1, Infrastructure.Learn05.Class1_1>();

////builder.Services.AddSingleton
////	(typeof(Infrastructure.Learn05.Interface1), typeof(Infrastructure.Learn05.Class1_1));
//// **************************************************

//// **************************************************
//builder.Services.AddSingleton
//	<Infrastructure.Learn05.Interface1, Infrastructure.Learn05.Class1_2>();

////builder.Services.AddSingleton
////	(typeof(Infrastructure.Learn05.Interface1), typeof(Infrastructure.Learn05.Class1_2));
//// **************************************************

//// **************************************************
////builder.Services.AddScoped
////	<Infrastructure.Learn05.Interface1, Infrastructure.Learn05.Class1_1>();

////builder.Services.AddScoped
////	(typeof(Infrastructure.Learn05.Interface1), typeof(Infrastructure.Learn05.Class1_1));
//// **************************************************

//// **************************************************
////builder.Services.AddTransient
////	<Infrastructure.Learn05.Interface1, Infrastructure.Learn05.Class1_1>();

////builder.Services.AddTransient
////	(typeof(Infrastructure.Learn05.Interface1), typeof(Infrastructure.Learn05.Class1_1));
//// **************************************************

//var app =
//	builder.Build();

//// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
//app.MapRazorPages();

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 06
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
//builder.Services.AddRazorPages();

//// **************************************************
//builder.Services.AddSingleton
//	<Infrastructure.Learn06.Interface1, Infrastructure.Learn06.Class1>();

//builder.Services.AddSingleton
//	<Infrastructure.Learn06.Interface2, Infrastructure.Learn06.Class2>();
//// **************************************************

//var app =
//	builder.Build();

//// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
//app.MapRazorPages();

//app.Run();
// **************************************************
// **************************************************
// **************************************************

// **************************************************
// **************************************************
// **************************************************
// Learn 07
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args);

//// AddRazorPages() -> using Microsoft.Extensions.DependencyInjection;
//builder.Services.AddRazorPages();

//// **************************************************
//builder.Services.AddSingleton
//	<Infrastructure.Learn07.ILog, Infrastructure.Learn07.LogToFile>();

////builder.Services.AddSingleton
////	<Infrastructure.Learn07.ILog, Infrastructure.Learn07.LogByEmail>();

////builder.Services.AddSingleton
////	<Infrastructure.Learn07.ILog, Infrastructure.Learn07.LogToDatabase>();
//// **************************************************

//var app =
//	builder.Build();

//// MapRazorPages() -> using Microsoft.AspNetCore.Builder;
//app.MapRazorPages();

//app.Run();
// **************************************************
// **************************************************
// **************************************************
