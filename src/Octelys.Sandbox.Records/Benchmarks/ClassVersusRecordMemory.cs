using BenchmarkDotNet.Attributes;
using Octelys.Sandbox.Records.Entities;

namespace Octelys.Sandbox.Records.Benchmarks;

[MemoryDiagnoser]
[ShortRunJob]
public class ClassVersusRecordMemory
{
    private List<BandClass> _bandClasses = [];
    private List<BandRecordStruct> _bandRecordStructs = [];
    private List<BandRecordClass> _bandRecordClasses = [];
    
    [Params(1_000, 10_000, 100_000, 1_000_000, 10_000_000)]
    public int ListSize { get; set; }
    
    [IterationSetup]
    public void Setup()
    {
        _bandClasses = new List<BandClass>(ListSize);
        _bandRecordStructs = new List<BandRecordStruct>(ListSize);
        _bandRecordClasses = new List<BandRecordClass>(ListSize);
    }
    
    [Benchmark]
    public void BenchmarkClassAllocations()
    {
        for (int i = 0; i < ListSize; i++)
        {
            _bandClasses.Add
            (
                new BandClass
                {
                    Name = "Name",
                    Origin = "Origin"
                }
            );
        }
    }
    
    [Benchmark]
    public void BenchmarkRecordStructsAllocations()
    {
        for (int i = 0; i < ListSize; i++)
        {
            _bandRecordStructs.Add
            (
                new BandRecordStruct
                (
                    "Name",
                    "Origin"
                )
            );
        }
    }
    
    [Benchmark]
    public void BenchmarkRecordClassesAllocations()
    {
        for (int i = 0; i < ListSize; i++)
        {
            _bandRecordClasses.Add
            (
                new BandRecordClass
                (
                    "Name",
                    "Origin"
                )
            );
        }
    }
}