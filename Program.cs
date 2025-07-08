using Bogus;
using BuilderBot.Infrastructure;
using BuilderBot.Models;
using BuilderBot.Services;

//RandomDescriptionGenerator description = new RandomDescriptionGenerator();
//description.GenerateDescription();

var builder = new TownBuilder();

var director = new TownDirector(builder);

director.BuildTown();

Console.WriteLine(builder.GetTown());

