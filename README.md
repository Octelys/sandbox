# Benchmarks

## ClassVersusRecordMemory: Class vs Record in a list

This benchmark explores the benefits of using a `record` instead of a `class`:

| Method                      | ListSize | Mean          | Error         | StdDev       | Gen0       | Gen1       | Gen2      | Allocated   |
|---------------------------- |--------- |--------------:|--------------:|-------------:|-----------:|-----------:|----------:|------------:|
| BenchmarkClassAllocations   | 1000     |      18.81 us |     21.654 us |     1.187 us |          - |          - |         - |     32736 B |
| BenchmarkRecordsAllocations | 1000     |      12.00 us |      0.011 us |     0.001 us |          - |          - |         - |       736 B |
| BenchmarkClassAllocations   | 10000    |      71.22 us |     10.033 us |     0.550 us |          - |          - |         - |    320736 B |
| BenchmarkRecordsAllocations | 10000    |      45.42 us |     14.838 us |     0.813 us |          - |          - |         - |       736 B |
| BenchmarkClassAllocations   | 100000   |     526.49 us |    253.009 us |    13.868 us |          - |          - |         - |   3200736 B |
| BenchmarkRecordsAllocations | 100000   |     271.58 us |    111.876 us |     6.132 us |          - |          - |         - |       736 B |
| BenchmarkClassAllocations   | 1000000  |  27,978.87 us |  9,155.867 us |   501.864 us |  6000.0000 |  3000.0000 | 1000.0000 |  32002576 B |
| BenchmarkRecordsAllocations | 1000000  |   2,453.68 us |    844.039 us |    46.265 us |          - |          - |         - |       736 B |
| BenchmarkClassAllocations   | 10000000 | 676,569.07 us | 88,963.177 us | 4,876.372 us | 54000.0000 | 20000.0000 | 3000.0000 | 320002768 B |
| BenchmarkRecordsAllocations | 10000000 |  24,265.59 us |  2,954.323 us |   161.936 us |          - |          - |         - |       736 B |