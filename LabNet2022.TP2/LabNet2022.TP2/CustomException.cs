using System;

namespace LabNet2022.TP2
{
    public class CustomException : Exception
    {

        public CustomException(string message) : base(message)
        {

        }

        public override string Message => $"Lab Net 2022 {base.Message}";

    }
}
