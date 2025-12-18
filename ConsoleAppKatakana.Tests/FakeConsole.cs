using ConsoleAppTP20251210.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject
{
    internal class FakeConsole : IEditConsole
    {
        public List<string> Outputs { get; } = new ();
        public void SetNewColor()
        {
            //Nothing happens
        }

        public void WriteNewLineTitle(string text)
        {
            Outputs.Add(text);
        }
    }
}
