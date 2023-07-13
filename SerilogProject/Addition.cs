using System;
using Serilog;

namespace SerilogProject
{
	public class Addition
	{
		private ILogger _logger = LoggerConfig.Logger!.ForContext<Addition>();

		public Addition(int x, int y)
		{
			_logger.Information("Added {X} + {Y} = {Z}", x, y, x + y);
		}
	}
}

