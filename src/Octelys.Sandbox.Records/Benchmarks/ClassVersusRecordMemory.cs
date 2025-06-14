using BenchmarkDotNet.Attributes;
using Octelys.Sandbox.Records.Entities;

namespace Octelys.Sandbox.Records.Benchmarks;

[MemoryDiagnoser]
[ShortRunJob]
public class ClassVersusRecordMemory
{
    private List<BandClass> _bandClasses = [];
    private List<BandRecord> _bandRecords = [];
    
    [Params(1_000, 10_000, 100_000, 1_000_000, 10_000_000)]
    public int ListSize { get; set; }
    
    [IterationSetup]
    public void Setup()
    {
        _bandClasses = new List<BandClass>(ListSize);
        _bandRecords = new List<BandRecord>(ListSize);
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
    public void BenchmarkRecordsAllocations()
    {
        for (int i = 0; i < ListSize; i++)
        {
            _bandRecords.Add
            (
                new BandRecord
                (
                    "Name",
                    "Origin"
                )
            );
        }
    }
}