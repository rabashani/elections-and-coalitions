using System;

namespace Elections.Domain.DateTimeProviders
{
	public interface IDateTimeProvider
	{
		DateTime Now { get; }
	}

	public class DateTimeProvider : IDateTimeProvider
	{
		public DateTime Now
		{
			get { return DateTime.UtcNow; }
		}
	}
}