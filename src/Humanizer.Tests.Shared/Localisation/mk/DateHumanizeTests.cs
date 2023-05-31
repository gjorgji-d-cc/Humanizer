using Humanizer.Localisation;

using Xunit;

namespace Humanizer.Tests.Localisation.mk
{
    [UseCulture("mk")]
    public class DateHumanizeTests
    {
        [Theory]
        [InlineData(-22, "пред 22 години")]
        [InlineData(-5, "пред 5 години")]
        [InlineData(-4, "пред 4 години")]
        [InlineData(-2, "пред 2 години")]
        [InlineData(-1, "пред година дена")]
        public void YearsAgo(int years, string expected)
        {
            DateHumanize.Verify(expected, years, TimeUnit.Year, Tense.Past);
        }

        [Theory]
        [InlineData(5, "за 5 години")]
        [InlineData(4, "за 4 години")]
        [InlineData(3, "за 3 години")]
        [InlineData(2, "за 2 години")]
        [InlineData(1, "за година дена")]
        public void YearsFromNow(int years, string expected)
        {
            DateHumanize.Verify(expected, years, TimeUnit.Year, Tense.Future);
        }

        [Theory]
        [InlineData(-8, "пред 8 месеци")]
        [InlineData(-5, "пред 5 месеци")]
        [InlineData(-4, "пред 4 месеци")]
        [InlineData(-3, "пред 3 месеци")]
        [InlineData(-2, "пред 2 месеци")]
        [InlineData(-1, "пред месец дена")]
        public void MonthsAgo(int months, string expected)
        {
            DateHumanize.Verify(expected, months, TimeUnit.Month, Tense.Past);
        }

        [Theory]
        [InlineData(5, "за 5 месеци")]
        [InlineData(4, "за 4 месеци")]
        [InlineData(2, "за 2 месеци")]
        [InlineData(1, "за месец дена")]
        public void MonthsFromNow(int months, string expected)
        {
            DateHumanize.Verify(expected, months, TimeUnit.Month, Tense.Future);
        }

        [Theory]
        [InlineData(-24, "пред 24 дена")]
        [InlineData(-22, "пред 22 дена")]
        [InlineData(-10, "пред 10 дена")]
        [InlineData(-5, "пред 5 дена")]
        [InlineData(-4, "пред 4 дена")]
        [InlineData(-3, "пред 3 дена")]
        [InlineData(-2, "пред 2 дена")]
        [InlineData(-1, "вчера")]
        public void DaysAgo(int days, string expected)
        {
            DateHumanize.Verify(expected, days, TimeUnit.Day, Tense.Past);
        }

        [Theory]
        [InlineData(10, "за 10 дена")]
        [InlineData(5, "за 5 дена")]
        [InlineData(1, "утре")]
        public void DaysFromNow(int days, string expected)
        {
            DateHumanize.Verify(expected, days, TimeUnit.Day, Tense.Future);
        }

        [Theory]
        [InlineData(-10, "пред 10 часа")]
        [InlineData(-5, "пред 5 часа")]
        [InlineData(-4, "пред 4 часа")]
        [InlineData(-3, "пред 3 часа")]
        [InlineData(-2, "пред 2 часа")]
        [InlineData(-1, "пред 1 час")]
        public void HoursAgo(int hours, string expected)
        {
            DateHumanize.Verify(expected, hours, TimeUnit.Hour, Tense.Past);
        }

        [Theory]
        [InlineData(5, "за 5 часа")]
        [InlineData(4, "за 4 часа")]
        [InlineData(3, "за 3 часа")]
        [InlineData(2, "за 2 часа")]
        [InlineData(1, "за 1 час")]
        public void HoursFromNow(int hours, string expected)
        {
            DateHumanize.Verify(expected, hours, TimeUnit.Hour, Tense.Future);
        }

        [Theory]
        [InlineData(-10, "пред 10 минути")]
        [InlineData(-5, "пред 5 минути")]
        [InlineData(-4, "пред 4 минути")]
        [InlineData(-3, "пред 3 минути")]
        [InlineData(-2, "пред 2 минути")]
        [InlineData(-1, "пред минута")]
        public void MinutesAgo(int minutes, string expected)
        {
            DateHumanize.Verify(expected, minutes, TimeUnit.Minute, Tense.Past);
        }

        [Theory]
        [InlineData(5, "за 5 минути")]
        [InlineData(4, "за 4 минути")]
        [InlineData(3, "за 3 минути")]
        [InlineData(2, "за 2 минути")]
        [InlineData(1, "за минута")]
        public void MinutesFromNow(int minutes, string expected)
        {
            DateHumanize.Verify(expected, minutes, TimeUnit.Minute, Tense.Future);
        }

        [Theory]
        [InlineData(-10, "пред 10 секунди")]
        [InlineData(-5, "пред 5 секунди")]
        [InlineData(-4, "пред 4 секунди")]
        [InlineData(-3, "пред 3 секунди")]
        [InlineData(-2, "пред 2 секунди")]
        [InlineData(-1, "пред секунда")]
        public void SecondsAgo(int seconds, string expected)
        {
            DateHumanize.Verify(expected, seconds, TimeUnit.Second, Tense.Past);
        }

        [Theory]
        [InlineData(10, "за 10 секунди")]
        [InlineData(5, "за 5 секунди")]
        [InlineData(4, "за 4 секунди")]
        [InlineData(3, "за 3 секунди")]
        [InlineData(2, "за 2 секунди")]
        [InlineData(1, "за секунда")]
        public void SecondsFromNow(int seconds, string expected)
        {
            DateHumanize.Verify(expected, seconds, TimeUnit.Second, Tense.Future);
        }
    }
}
