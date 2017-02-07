using System.Threading;

namespace NativeCrossPlatform
{
	public class ClickCounterService
	{
		private int _count = 0;

		public string Message => $"{_count} clicks!";

		public void OnClick()
		{
			Interlocked.Increment(ref _count);
		}
	}
}
