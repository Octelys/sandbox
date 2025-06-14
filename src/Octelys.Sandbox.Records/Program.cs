using System.Reflection;
using BenchmarkDotNet.Running;

namespace Octelys.Sandbox.Records;

public class Program
{
    public static void Main
    (
        string[] args
    )
    {
        Assembly assembly = typeof(Program).Assembly;

        BenchmarkRunner.Run
        (
            assembly,
            args: args
        );
    }
}