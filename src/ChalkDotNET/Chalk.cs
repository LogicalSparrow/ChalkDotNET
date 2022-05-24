using System;

namespace ChalkDotNET
{
    public class Chalk
    {
        public static Style Bold() => new Style() { IsBold = true };
        public static Style Italic() => new Style() { IsItalic = true };
        public static Style Underline() => new Style() { IsUnderlined = true };

        public static ChalkedString Bold(string message) => new ChalkedString(message, new Style() { IsBold = true });
        public static ChalkedString Italic(string message) => new ChalkedString(message, new Style() { IsItalic = true });
        public static ChalkedString Underline(string message) => new ChalkedString(message, new Style() { IsUnderlined = true });

        #region Foreground Colors
        public static Style Black() => new Style(ConsoleColor.Black);
        public static Style Blue() => new Style(ConsoleColor.Blue);
        public static Style Cyan() => new Style(ConsoleColor.Cyan);
        public static Style DarkBlue() => new Style(ConsoleColor.DarkBlue);
        public static Style DarkCyan() => new Style(ConsoleColor.DarkCyan);
        public static Style DarkGray() => new Style(ConsoleColor.DarkGray);
        public static Style DarkGreen() => new Style(ConsoleColor.DarkGreen);
        public static Style DarkMagenta() => new Style(ConsoleColor.DarkMagenta);
        public static Style DarkRed() => new Style(ConsoleColor.DarkRed);
        public static Style DarkYellow() => new Style(ConsoleColor.DarkYellow);
        public static Style Gray() => new Style(ConsoleColor.Gray);
        public static Style Green() => new Style(ConsoleColor.Green);
        public static Style Magenta() => new Style(ConsoleColor.Magenta);
        public static Style Red() => new Style(ConsoleColor.Red);
        public static Style White() => new Style(ConsoleColor.White);
        public static Style Yellow() => new Style(ConsoleColor.Yellow);

        public static ChalkedString Black(string message) => new ChalkedString(message, new Style(ConsoleColor.Black));
        public static ChalkedString Blue(string message) => new ChalkedString(message, new Style(ConsoleColor.Blue));
        public static ChalkedString Cyan(string message) => new ChalkedString(message, new Style(ConsoleColor.Cyan));
        public static ChalkedString DarkBlue(string message) => new ChalkedString(message, new Style(ConsoleColor.DarkBlue));
        public static ChalkedString DarkCyan(string message) => new ChalkedString(message, new Style(ConsoleColor.DarkCyan));
        public static ChalkedString DarkGray(string message) => new ChalkedString(message, new Style(ConsoleColor.DarkGray));
        public static ChalkedString DarkGreen(string message) => new ChalkedString(message, new Style(ConsoleColor.DarkGreen));
        public static ChalkedString DarkMagenta(string message) => new ChalkedString(message, new Style(ConsoleColor.DarkMagenta));
        public static ChalkedString DarkRed(string message) => new ChalkedString(message, new Style(ConsoleColor.DarkRed));
        public static ChalkedString DarkYellow(string message) => new ChalkedString(message, new Style(ConsoleColor.DarkYellow));
        public static ChalkedString Gray(string message) => new ChalkedString(message, new Style(ConsoleColor.Gray));
        public static ChalkedString Green(string message) => new ChalkedString(message, new Style(ConsoleColor.Green));
        public static ChalkedString Magenta(string message) => new ChalkedString(message, new Style(ConsoleColor.Magenta));
        public static ChalkedString Red(string message) => new ChalkedString(message, new Style(ConsoleColor.Red));
        public static ChalkedString White(string message) => new ChalkedString(message, new Style(ConsoleColor.White));
        public static ChalkedString Yellow(string message) => new ChalkedString(message, new Style(ConsoleColor.Yellow));
        #endregion

        #region Background Colors
        public static Style BgBlack() => new Style(Style.DefaultForegroundColor, ConsoleColor.Black);
        public static Style BgBlue() => new Style(Style.DefaultForegroundColor, ConsoleColor.Blue);
        public static Style BgCyan() => new Style(Style.DefaultForegroundColor, ConsoleColor.Cyan);
        public static Style BgDarkBlue() => new Style(Style.DefaultForegroundColor, ConsoleColor.DarkBlue);
        public static Style BgDarkCyan() => new Style(Style.DefaultForegroundColor, ConsoleColor.DarkCyan);
        public static Style BgDarkGray() => new Style(Style.DefaultForegroundColor, ConsoleColor.DarkGray);
        public static Style BgDarkGreen() => new Style(Style.DefaultForegroundColor, ConsoleColor.DarkGreen);
        public static Style BgDarkMagenta() => new Style(Style.DefaultForegroundColor, ConsoleColor.DarkMagenta);
        public static Style BgDarkRed() => new Style(Style.DefaultForegroundColor, ConsoleColor.DarkRed);
        public static Style BgDarkYellow() => new Style(Style.DefaultForegroundColor, ConsoleColor.DarkYellow);
        public static Style BgGray() => new Style(Style.DefaultForegroundColor, ConsoleColor.Gray);
        public static Style BgGreen() => new Style(Style.DefaultForegroundColor, ConsoleColor.Green);
        public static Style BgMagenta() => new Style(Style.DefaultForegroundColor, ConsoleColor.Magenta);
        public static Style BgRed() => new Style(Style.DefaultForegroundColor, ConsoleColor.Red);
        public static Style BgWhite() => new Style(Style.DefaultForegroundColor, ConsoleColor.White);
        public static Style BgYellow() => new Style(Style.DefaultForegroundColor, ConsoleColor.Yellow);
        public static ChalkedString BgBlack(string message) => new ChalkedString(message, new Style { BackgroundColor = ConsoleColor.Black });
        public static ChalkedString BgBlue(string message) => new ChalkedString(message, new Style { BackgroundColor = ConsoleColor.Blue });
        public static ChalkedString BgCyan(string message) => new ChalkedString(message, new Style { BackgroundColor = ConsoleColor.Cyan });
        public static ChalkedString BgDarkBlue(string message) => new ChalkedString(message, new Style { BackgroundColor = ConsoleColor.DarkBlue });
        public static ChalkedString BgDarkCyan(string message) => new ChalkedString(message, new Style { BackgroundColor = ConsoleColor.DarkCyan });
        public static ChalkedString BgDarkGray(string message) => new ChalkedString(message, new Style { BackgroundColor = ConsoleColor.DarkGray });
        public static ChalkedString BgDarkGreen(string message) => new ChalkedString(message, new Style { BackgroundColor = ConsoleColor.DarkGreen });
        public static ChalkedString BgDarkMagenta(string message) => new ChalkedString(message, new Style { BackgroundColor = ConsoleColor.DarkMagenta });
        public static ChalkedString BgDarkRed(string message) => new ChalkedString(message, new Style { BackgroundColor = ConsoleColor.DarkRed });
        public static ChalkedString BgDarkYellow(string message) => new ChalkedString(message, new Style { BackgroundColor = ConsoleColor.DarkYellow });
        public static ChalkedString BgGray(string message) => new ChalkedString(message, new Style { BackgroundColor = ConsoleColor.Gray });
        public static ChalkedString BgGreen(string message) => new ChalkedString(message, new Style { BackgroundColor = ConsoleColor.Green });
        public static ChalkedString BgMagenta(string message) => new ChalkedString(message, new Style { BackgroundColor = ConsoleColor.Magenta });
        public static ChalkedString BgRed(string message) => new ChalkedString(message, new Style { BackgroundColor = ConsoleColor.Red });
        public static ChalkedString BgWhite(string message) => new ChalkedString(message, new Style { BackgroundColor = ConsoleColor.White });
        public static ChalkedString BgYellow(string message) => new ChalkedString(message, new Style { BackgroundColor = ConsoleColor.Yellow });
        #endregion
        
        public static ChalkedString Default(string message) => new ChalkedString(message);
    }
}
