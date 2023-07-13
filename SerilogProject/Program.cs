// See https://aka.ms/new-console-template for more information
using Serilog;
using SerilogProject;

Console.WriteLine("Hello, World!");

LoggerConfig.CreateLogger();

ILogger logger = LoggerConfig.Logger!.ForContext<Program>();

logger.Information("Application Started");

var addition = new Addition(2, 2);

logger.Information("Application Ended");