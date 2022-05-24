using System;
using ChalkDotNET;
using Xunit;
using FluentAssertions;

namespace ChalkDotNET.Tests
{
    public class ColorChangeTests
    {
        [Fact]
        public void StyleColorChange_OnlyChangesNewStyle()
        {
            Style style1 = new Style(ConsoleColor.Red);
            Style style2 = style1.Green();
            style1.ForegroundColor.Should().NotBe(style2.ForegroundColor);
        }

        [Fact]
        public void ChalkStringColorChange_OnlyChangesNewStyle()
        {
            ChalkedString msg1 = new ChalkedString("test", new Style(ConsoleColor.Red));
            ChalkedString msg2 = msg1.Green;
            msg1.Style.ForegroundColor.Should().NotBe(msg2.Style.ForegroundColor);
        }

        [Fact]
        public void Builder_ResetsColors()
        {
            ChalkedStringBuilder builder = Chalk.Red("msg1") + " " + Chalk.Green("msg2") + " " + Chalk.Blue("msg3");
            builder.Messages.Count.Should().Be(5);
            builder.Messages.ToArray()[2].Message.Should().Be("msg2");
            Console.WriteLine(builder);
            Console.ForegroundColor.Should().Be(Style.DefaultForegroundColor);
        }

        [Fact]
        public void Style_BgColorWontAffectForeground()
        {
            var msg1 = Chalk.Red().BgGreen("msg");
            var msg2 = msg1.BgDarkCyan;
            msg2.Style.ForegroundColor.Should().Be(msg1.Style.ForegroundColor);
            msg2.Style.BackgroundColor.Should().NotBe(msg1.Style.BackgroundColor);

        }
    }
}