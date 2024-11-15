```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4317/23H2/2023Update/SunValley3)
Intel Core i7-1065G7 CPU 1.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method     | Count  | Mean          | Error         | StdDev        | StdErr       | Min           | Q1            | Median        | Q3            | Max           | Op/s         | Rank | Gen0   | Allocated |
|----------- |------- |--------------:|--------------:|--------------:|-------------:|--------------:|--------------:|--------------:|--------------:|--------------:|-------------:|-----:|-------:|----------:|
| **IsNull**     | **1**      |      **12.47 ns** |      **0.148 ns** |      **0.131 ns** |     **0.035 ns** |      **12.30 ns** |      **12.34 ns** |      **12.46 ns** |      **12.62 ns** |      **12.65 ns** | **80,179,786.5** |    **1** | **0.0076** |      **32 B** |
| EqualsNull | 1      |      12.34 ns |      0.139 ns |      0.124 ns |     0.033 ns |      12.12 ns |      12.29 ns |      12.35 ns |      12.38 ns |      12.57 ns | 81,014,352.0 |    1 | 0.0076 |      32 B |
| **IsNull**     | **100**    |     **204.84 ns** |      **2.851 ns** |      **2.381 ns** |     **0.660 ns** |     **200.21 ns** |     **202.97 ns** |     **205.15 ns** |     **206.80 ns** |     **208.35 ns** |  **4,881,969.4** |    **2** | **0.0076** |      **32 B** |
| EqualsNull | 100    |     201.23 ns |      2.937 ns |      2.747 ns |     0.709 ns |     196.04 ns |     199.47 ns |     201.93 ns |     202.81 ns |     206.87 ns |  4,969,410.6 |    2 | 0.0076 |      32 B |
| **IsNull**     | **1000**   |   **1,862.76 ns** |     **36.477 ns** |     **39.030 ns** |     **9.200 ns** |   **1,797.18 ns** |   **1,838.67 ns** |   **1,861.51 ns** |   **1,899.56 ns** |   **1,927.99 ns** |    **536,836.7** |    **3** | **0.0076** |      **32 B** |
| EqualsNull | 1000   |   1,849.60 ns |     20.791 ns |     19.448 ns |     5.021 ns |   1,820.52 ns |   1,829.64 ns |   1,853.24 ns |   1,863.95 ns |   1,879.82 ns |    540,657.6 |    3 | 0.0076 |      32 B |
| **IsNull**     | **10000**  |  **50,545.49 ns** |    **270.398 ns** |    **252.930 ns** |    **65.306 ns** |  **50,071.99 ns** |  **50,346.01 ns** |  **50,563.00 ns** |  **50,730.62 ns** |  **50,942.53 ns** |     **19,784.2** |    **4** |      **-** |      **32 B** |
| EqualsNull | 10000  |  51,156.00 ns |    820.575 ns |    767.566 ns |   198.185 ns |  50,023.26 ns |  50,497.60 ns |  51,038.55 ns |  51,709.58 ns |  52,413.09 ns |     19,548.0 |    4 |      - |      32 B |
| **IsNull**     | **100000** | **658,123.96 ns** | **11,504.003 ns** | **10,197.999 ns** | **2,725.530 ns** | **645,549.61 ns** | **649,855.30 ns** | **656,659.72 ns** | **664,957.96 ns** | **680,071.78 ns** |      **1,519.5** |    **5** |      **-** |      **32 B** |
| EqualsNull | 100000 | 658,702.57 ns | 13,021.905 ns | 14,473.813 ns | 3,320.520 ns | 645,593.95 ns | 648,512.40 ns | 650,997.07 ns | 665,348.14 ns | 689,133.11 ns |      1,518.1 |    5 |      - |      32 B |
