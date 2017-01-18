using System.Diagnostics;
using Xunit;

namespace InstaSharper.Tests.Utils
{
    public sealed class RunnableInDebugOnlyTheory : TheoryAttribute
    {
        public RunnableInDebugOnlyTheory()
        {
            if (!Debugger.IsAttached)
                Skip = "This theory only running in interactive mode.";
        }
    }
}