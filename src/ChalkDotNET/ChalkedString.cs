using System;
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("ChalkDotNET.Tests")]
namespace ChalkDotNET
{
    public class ChalkedString
    {
        internal string Message { get; set; }
        internal Style Style { get; set; }

        public ChalkedString(string message)
        {
            Message = message;
            Style = new Style();
        }

        public ChalkedString(string message, Style style)
        {
            Message = message ?? string.Empty;
            Style = style ?? new Style();
        }

        public ChalkedString Bold { get => new ChalkedString(Message, Style.WithBold()); }
        public ChalkedString Italic { get => new ChalkedString(Message, Style.WithItalic()); }
        public ChalkedString Underline { get => new ChalkedString(Message, Style.WithUnderline()); }

        #region Foreground Colors
        public ChalkedString Black { get => new ChalkedString(Message, Style.WithForeground(ConsoleColor.Black)); }
        public ChalkedString Blue { get => new ChalkedString(Message, Style.WithForeground(ConsoleColor.Blue)); }
        public ChalkedString Cyan { get => new ChalkedString(Message, Style.WithForeground(ConsoleColor.Cyan)); }
        public ChalkedString DarkBlue { get => new ChalkedString(Message, Style.WithForeground(ConsoleColor.DarkBlue)); }
        public ChalkedString DarkCyan { get => new ChalkedString(Message, Style.WithForeground(ConsoleColor.DarkCyan)); }
        public ChalkedString DarkGray { get => new ChalkedString(Message, Style.WithForeground(ConsoleColor.DarkGray)); }
        public ChalkedString DarkGreen { get => new ChalkedString(Message, Style.WithForeground(ConsoleColor.DarkGreen)); }
        public ChalkedString DarkMagenta { get => new ChalkedString(Message, Style.WithForeground(ConsoleColor.DarkMagenta)); }
        public ChalkedString DarkRed { get => new ChalkedString(Message, Style.WithForeground(ConsoleColor.DarkRed)); }
        public ChalkedString DarkYellow { get => new ChalkedString(Message, Style.WithForeground(ConsoleColor.DarkYellow)); }
        public ChalkedString Gray { get => new ChalkedString(Message, Style.WithForeground(ConsoleColor.Gray)); }
        public ChalkedString Green { get => new ChalkedString(Message, Style.WithForeground(ConsoleColor.Green)); }
        public ChalkedString Magenta { get => new ChalkedString(Message, Style.WithForeground(ConsoleColor.Magenta)); }
        public ChalkedString Red { get => new ChalkedString(Message, Style.WithForeground(ConsoleColor.Red)); }
        public ChalkedString White { get => new ChalkedString(Message, Style.WithForeground(ConsoleColor.White)); }
        public ChalkedString Yellow { get => new ChalkedString(Message, Style.WithForeground(ConsoleColor.Yellow)); }
        #endregion

        #region Background Colors
        public ChalkedString BgBlack { get => new ChalkedString(Message, Style.WithBackground(ConsoleColor.Black)); }
        public ChalkedString BgBlue { get => new ChalkedString(Message, Style.WithBackground(ConsoleColor.Blue)); }
        public ChalkedString BgCyan { get => new ChalkedString(Message, Style.WithBackground(ConsoleColor.Cyan)); }
        public ChalkedString BgDarkBlue { get => new ChalkedString(Message, Style.WithBackground(ConsoleColor.DarkBlue)); }
        public ChalkedString BgDarkCyan { get => new ChalkedString(Message, Style.WithBackground(ConsoleColor.DarkCyan)); }
        public ChalkedString BgDarkGray { get => new ChalkedString(Message, Style.WithBackground(ConsoleColor.DarkGray)); }
        public ChalkedString BgDarkGreen { get => new ChalkedString(Message, Style.WithBackground(ConsoleColor.DarkGreen)); }
        public ChalkedString BgDarkMagenta { get => new ChalkedString(Message, Style.WithBackground(ConsoleColor.DarkMagenta)); }
        public ChalkedString BgDarkRed { get => new ChalkedString(Message, Style.WithBackground(ConsoleColor.DarkRed)); }
        public ChalkedString BgDarkYellow { get => new ChalkedString(Message, Style.WithBackground(ConsoleColor.DarkYellow)); }
        public ChalkedString BgGray { get => new ChalkedString(Message, Style.WithBackground(ConsoleColor.Gray)); }
        public ChalkedString BgGreen { get => new ChalkedString(Message, Style.WithBackground(ConsoleColor.Green)); }
        public ChalkedString BgMagenta { get => new ChalkedString(Message, Style.WithBackground(ConsoleColor.Magenta)); }
        public ChalkedString BgRed { get => new ChalkedString(Message, Style.WithBackground(ConsoleColor.Red)); }
        public ChalkedString BgWhite { get => new ChalkedString(Message, Style.WithBackground(ConsoleColor.White)); }
        public ChalkedString BgYellow { get => new ChalkedString(Message, Style.WithBackground(ConsoleColor.Yellow)); }
        #endregion

        public static implicit operator ChalkedString(string message)
        {
            return new ChalkedString(message);
        }

        public static ChalkedStringBuilder operator +(ChalkedString message1, ChalkedString message2)
        {
            ChalkedStringBuilder builder = new ChalkedStringBuilder();
            builder.Append(message1);
            builder.Append(message2);
            return builder;
        }

        public override string ToString()
        {
            return Style.Open + Message + Style.Close;
        }
    }
}
