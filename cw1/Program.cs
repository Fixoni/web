using cw1.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
string FirstName ="AleKongo";
string LastName="Meduza";

app.MapGet("/", () => "Hello World!");
app.MapGet("/date", () => DateTime.Now.ToShortDateString());
app.MapGet("/imie",()=> "Witaj!! "+FirstName+" "+LastName);

app.MapGet("/osoby",()=>PersonRepo.GetPerson());
app.MapGet("/books",()=>BookRepo.GetBooks());
app.Run();