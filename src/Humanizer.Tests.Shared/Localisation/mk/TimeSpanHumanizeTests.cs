using System;

using Xunit;

namespace Humanizer.Tests.Localisation.mk
{
    [UseCulture("mk")]
    public class TimeSpanHumanizeTests
    {
        [Theory]
        [InlineData(366, "1 година")]
        [InlineData(731, "2 години")]
        [InlineData(1096, "3 години")]
        [InlineData(4018, "11 години")]
        public void Years(int days, string expected)
        {
            Assert.Equal(expected, TimeSpan.FromDays(days).Humanize(maxUnit: Humanizer.Localisation.TimeUnit.Year));
        }

        [Theory]
        [InlineData(31, "1 месец")]
        [InlineData(61, "2 месеци")]
        [InlineData(92, "3 месеци")]
        [InlineData(335, "11 месеци")]
        public void Months(int days, string expected)
        {
            Assert.Equal(expected, TimeSpan.FromDays(days).Humanize(maxUnit: Humanizer.Localisation.TimeUnit.Year));
        }

        [Theory]
        [InlineData(1, "1 ден")]
        [InlineData(2, "2 дена")]
        [InlineData(3, "3 дена")]
        [InlineData(4, "4 дена")]
        [InlineData(5, "5 дена")]
        [InlineData(7, "1 недела")]
        [InlineData(14, "2 недели")]
        public void Days(int days, string expected)
        {
            Assert.Equal(expected, TimeSpan.FromDays(days).Humanize());
        }
    }
}
