using System;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("ChalkDotNET.Tests")]
namespace ChalkDotNET
{
    public class Style
    {
        internal static ConsoleColor DefaultForegroundColor;
        internal static ConsoleColor DefaultBackgroundColor;
        static Style()
        {
            DefaultForegroundColor = Console.ForegroundColor;
            DefaultBackgroundColor = Console.BackgroundColor;
        }


        public ConsoleColor ForegroundColor { get; set; }
        public ConsoleColor BackgroundColor { get; set; }
        public bool IsBold { get; set; }
        public bool IsUnderlined { get; set; }
        public bool IsItalic { get; set; }
        internal bool Reset { get; set; }

        public Style()
        {
            ForegroundColor = DefaultForegroundColor;
            BackgroundColor = DefaultBackgroundColor;
            Reset = true;
        }

        public Style(ConsoleColor foregroundColor)
        {
            ForegroundColor = foregroundColor;
            BackgroundColor = DefaultBackgroundColor;
        }

        public Style(ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            ForegroundColor = foregroundColor;
            BackgroundColor = backgroundColor;
        }

        public Style(ConsoleColor foregroundColor, ConsoleColor backgroundColor, bool bold, bool italic, bool underlined)
        {
            ForegroundColor = foregroundColor;
            BackgroundColor = backgroundColor;
            IsBold = bold;
            IsItalic = italic;
            IsUnderlined = underlined;
        }

        public Style WithForeground(ConsoleColor foregroundColor)
        {
            return new Style(foregroundColor, BackgroundColor, IsBold, IsItalic, IsUnderlined);
        }

        public Style WithBackground(ConsoleColor backgroundColor)
        {
            return new Style(ForegroundColor, backgroundColor, IsBold, IsItalic, IsUnderlined);
        }

        public Style WithBold() => new Style(ForegroundColor, BackgroundColor, true, IsItalic, IsUnderlined);
        public Style WithItalic() => new Style(ForegroundColor, BackgroundColor, IsBold, true, IsUnderlined);
        public Style WithUnderline() => new Style(ForegroundColor, BackgroundColor, IsBold, IsItalic, true);

        public void Apply()
        {
            if (Reset)
            {
                PrintReset();
                return;
            }
            Console.ForegroundColor = ForegroundColor;
            Console.BackgroundColor = BackgroundColor;
        }

        public void PrintReset()
        {
            Console.ResetColor();
            Console.Write((char)27 + "[21m");//not bold
            Console.Write((char)27 + "[23m");//not italic
            Console.Write((char)27 + "[24m");//not underline
        }

        public ChalkedString SetMessage(string message) => new ChalkedString(message, this);

        public Style Bold() => WithBold();
        public Style Italic() => WithItalic();
        public Style Underline() => WithUnderline();

        #region Foreground Colors
        public Style Black() => WithForeground(ConsoleColor.Black);
        public Style Blue() => WithForeground(ConsoleColor.Blue);
        public Style Cyan() => WithForeground(ConsoleColor.Cyan);
        public Style DarkBlue() => WithForeground(ConsoleColor.DarkBlue);
        public Style DarkCyan() => WithForeground(ConsoleColor.DarkCyan);
        public Style DarkGray() => WithForeground(ConsoleColor.DarkGray);
        public Style DarkGreen() => WithForeground(ConsoleColor.DarkGreen);
        public Style DarkMagenta() => WithForeground(ConsoleColor.DarkMagenta);
        public Style DarkRed() => WithForeground(ConsoleColor.DarkRed);
        public Style DarkYellow() => WithForeground(ConsoleColor.DarkYellow);
        public Style Gray() => WithForeground(ConsoleColor.Gray);
        public Style Green() => WithForeground(ConsoleColor.Green);
        public Style Magenta() => WithForeground(ConsoleColor.Magenta);
        public Style Red() => WithForeground(ConsoleColor.Red);
        public Style White() => WithForeground(ConsoleColor.White);
        public Style Yellow() => WithForeground(ConsoleColor.Yellow);

        public ChalkedString Black(string message) => new ChalkedString(message, WithForeground(ConsoleColor.Black));
        public ChalkedString Blue(string message) => new ChalkedString(message, WithForeground(ConsoleColor.Blue));
        public ChalkedString Cyan(string message) => new ChalkedString(message, WithForeground(ConsoleColor.Cyan));
        public ChalkedString DarkBlue(string message) => new ChalkedString(message, WithForeground(ConsoleColor.DarkBlue));
        public ChalkedString DarkCyan(string message) => new ChalkedString(message, WithForeground(ConsoleColor.DarkCyan));
        public ChalkedString DarkGray(string message) => new ChalkedString(message, WithForeground(ConsoleColor.DarkGray));
        public ChalkedString DarkGreen(string message) => new ChalkedString(message, WithForeground(ConsoleColor.DarkGreen));
        public ChalkedString DarkMagenta(string message) => new ChalkedString(message, WithForeground(ConsoleColor.DarkMagenta));
        public ChalkedString DarkRed(string message) => new ChalkedString(message, WithForeground(ConsoleColor.DarkRed));
        public ChalkedString DarkYellow(string message) => new ChalkedString(message, WithForeground(ConsoleColor.DarkYellow));
        public ChalkedString Gray(string message) => new ChalkedString(message, WithForeground(ConsoleColor.Gray));
        public ChalkedString Green(string message) => new ChalkedString(message, WithForeground(ConsoleColor.Green));
        public ChalkedString Magenta(string message) => new ChalkedString(message, WithForeground(ConsoleColor.Magenta));
        public ChalkedString Red(string message) => new ChalkedString(message, WithForeground(ConsoleColor.Red));
        public ChalkedString White(string message) => new ChalkedString(message, WithForeground(ConsoleColor.White));
        public ChalkedString Yellow(string message) => new ChalkedString(message, WithForeground(ConsoleColor.Yellow));
        #endregion

        #region Background Colors
        public Style BgBlack() => WithBackground(ConsoleColor.Black);
        public Style BgBlue() => WithBackground(ConsoleColor.Blue);
        public Style BgCyan() => WithBackground(ConsoleColor.Cyan);
        public Style BgDarkBlue() => WithBackground(ConsoleColor.DarkBlue);
        public Style BgDarkCyan() => WithBackground(ConsoleColor.DarkCyan);
        public Style BgDarkGray() => WithBackground(ConsoleColor.DarkGray);
        public Style BgDarkGreen() => WithBackground(ConsoleColor.DarkGreen);
        public Style BgDarkMagenta() => WithBackground(ConsoleColor.DarkMagenta);
        public Style BgDarkRed() => WithBackground(ConsoleColor.DarkRed);
        public Style BgDarkYellow() => WithBackground(ConsoleColor.DarkYellow);
        public Style BgGray() => WithBackground(ConsoleColor.Gray);
        public Style BgGreen() => WithBackground(ConsoleColor.Green);
        public Style BgMagenta() => WithBackground(ConsoleColor.Magenta);
        public Style BgRed() => WithBackground(ConsoleColor.Red);
        public Style BgWhite() => WithBackground(ConsoleColor.White);
        public Style BgYellow() => WithBackground(ConsoleColor.Yellow);

        public ChalkedString BgBlack(string message) => new ChalkedString(message, WithBackground(ConsoleColor.Black));
        public ChalkedString BgBlue(string message) => new ChalkedString(message, WithBackground(ConsoleColor.Blue));
        public ChalkedString BgCyan(string message) => new ChalkedString(message, WithBackground(ConsoleColor.Cyan));
        public ChalkedString BgDarkBlue(string message) => new ChalkedString(message, WithBackground(ConsoleColor.DarkBlue));
        public ChalkedString BgDarkCyan(string message) => new ChalkedString(message, WithBackground(ConsoleColor.DarkCyan));
        public ChalkedString BgDarkGray(string message) => new ChalkedString(message, WithBackground(ConsoleColor.DarkGray));
        public ChalkedString BgDarkGreen(string message) => new ChalkedString(message, WithBackground(ConsoleColor.DarkGreen));
        public ChalkedString BgDarkMagenta(string message) => new ChalkedString(message, WithBackground(ConsoleColor.DarkMagenta));
        public ChalkedString BgDarkRed(string message) => new ChalkedString(message, WithBackground(ConsoleColor.DarkRed));
        public ChalkedString BgDarkYellow(string message) => new ChalkedString(message, WithBackground(ConsoleColor.DarkYellow));
        public ChalkedString BgGray(string message) => new ChalkedString(message, WithBackground(ConsoleColor.Gray));
        public ChalkedString BgGreen(string message) => new ChalkedString(message, WithBackground(ConsoleColor.Green));
        public ChalkedString BgMagenta(string message) => new ChalkedString(message, WithBackground(ConsoleColor.Magenta));
        public ChalkedString BgRed(string message) => new ChalkedString(message, WithBackground(ConsoleColor.Red));
        public ChalkedString BgWhite(string message) => new ChalkedString(message, WithBackground(ConsoleColor.White));
        public ChalkedString BgYellow(string message) => new ChalkedString(message, WithBackground(ConsoleColor.Yellow));
        #endregion

        public int ForegroundColorEscapeCode
        {
            get
            {
                return ForegroundColor switch
                {
                    ConsoleColor.Black => 30,
                    ConsoleColor.Blue => 94,
                    ConsoleColor.Cyan => 96,
                    ConsoleColor.DarkBlue => 34,
                    ConsoleColor.DarkCyan => 36,
                    ConsoleColor.DarkGray => 90,
                    ConsoleColor.DarkGreen => 32,
                    ConsoleColor.DarkMagenta => 35,
                    ConsoleColor.DarkRed => 31,
                    ConsoleColor.DarkYellow => 33,
                    ConsoleColor.Gray => 37,
                    ConsoleColor.Green => 92,
                    ConsoleColor.Magenta => 95,
                    ConsoleColor.Red => 91,
                    ConsoleColor.Yellow => 93,
                    ConsoleColor.White => 97,
                    _ => 37 //gray
                };
            }
        }

        public int BackgroundColorEscapeCode
        {
            get
            {
                return BackgroundColor switch
                {
                    ConsoleColor.Black => 40,
                    ConsoleColor.Blue => 104,
                    ConsoleColor.Cyan => 106,
                    ConsoleColor.DarkBlue => 44,
                    ConsoleColor.DarkCyan => 46,
                    ConsoleColor.DarkGray => 100,
                    ConsoleColor.DarkGreen => 42,
                    ConsoleColor.DarkMagenta => 45,
                    ConsoleColor.DarkRed => 41,
                    ConsoleColor.DarkYellow => 43,
                    ConsoleColor.Gray => 47,
                    ConsoleColor.Green => 102,
                    ConsoleColor.Magenta => 105,
                    ConsoleColor.Red => 101,
                    ConsoleColor.Yellow => 103,
                    ConsoleColor.White => 107,
                    _ => 47 //gray
                };
            }
        }

        internal string Open
        {
            get
            {
                return (char)27 + "[" + BackgroundColorEscapeCode + "m"  //bg escape code
                    + (char)27 + "[" + ForegroundColorEscapeCode + "m" //fg escape code
                    + (IsBold ? (char)27 + "[1m" : string.Empty)
                    + (IsItalic ? (char)27 + "[3m" : string.Empty)
                    + (IsUnderlined ? (char)27 + "[4m" : string.Empty);
            }
        }
        
        internal string Close => (char)27 + "[0m";

    }
}
