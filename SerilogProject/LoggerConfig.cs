using System;
using Serilog;
using Serilog.Events;
using Serilog.Formatting;
using Serilog.Formatting.Display;

namespace SerilogProject;

public static class LoggerConfig
{
	public static ILogger? Logger;

	public static ILogger CreateLogger()
	{
        var logger = new LoggerConfiguration()
            .WriteTo.File(new CustomTextFormatter(), "logger.log")
			.CreateLogger();

		Logger = logger;

		return logger;
	}
}

class CustomTextFormatter : ITextFormatter
{
    private readonly MessageTemplateTextFormatter _defaultFormatter;

    public CustomTextFormatter()
    {
        _defaultFormatter = new MessageTemplateTextFormatter("{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level}] [{SourceContext}] {Message:lj}{NewLine}{Exception}");
    }

    public void Format(LogEvent logEvent, TextWriter output)
    {
        //logEvent.AddOrUpdateProperty(new LogEventProperty("SourceContext", new ScalarValue("test")));
        _defaultFormatter.Format(logEvent, output);
    }
}
