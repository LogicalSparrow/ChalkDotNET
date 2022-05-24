using System;
using System.Collections.Generic;
using System.Text;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("ChalkDotNET.Tests")]
namespace ChalkDotNET
{
    public class ChalkedStringBuilder
    {
        internal Queue<ChalkedString> Messages { get; set; }

        public ChalkedStringBuilder()
        {
            Messages = new Queue<ChalkedString>();
        }

        public void Append(ChalkedString message)
        {
            Messages.Enqueue(message);
        }

        public void AppendLine(ChalkedString message)
        {
            Messages.Enqueue(message);
            Messages.Enqueue(new ChalkedString(Environment.NewLine, message.Style));
        }

        public static ChalkedStringBuilder operator +(ChalkedStringBuilder builder, ChalkedString message)
        {
            builder.Append(message);
            return builder;
        }

        public static ChalkedStringBuilder operator +(ChalkedStringBuilder builder1, ChalkedStringBuilder builder2)
        {
            foreach(var message in builder2.Messages)
                builder1.Append(message);
            return builder1;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach(var message in Messages)
            {
                builder.Append(message.ToString());
            }
            return builder.ToString();
        }
    }
}
