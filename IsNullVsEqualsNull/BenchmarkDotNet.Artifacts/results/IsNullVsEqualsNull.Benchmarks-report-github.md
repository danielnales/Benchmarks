```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4317/23H2/2023Update/SunValley3)
Intel Core i7-1065G7 CPU 1.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method     | Count  | Mean          | Error        | StdDev       | StdErr       | Min           | Q1            | Median        | Q3            | Max           | Op/s         | Rank | Gen0   | Allocated |
|----------- |------- |--------------:|-------------:|-------------:|-------------:|--------------:|--------------:|--------------:|--------------:|--------------:|-------------:|-----:|-------:|----------:|
| **IsNull**     | **1**      |      **12.26 ns** |     **0.156 ns** |     **0.146 ns** |     **0.038 ns** |      **12.00 ns** |      **12.16 ns** |      **12.32 ns** |      **12.36 ns** |      **12.51 ns** | **81,553,571.7** |    **1** | **0.0076** |      **32 B** |
| EqualsNull | 1      |      12.60 ns |     0.263 ns |     0.360 ns |     0.071 ns |      12.19 ns |      12.36 ns |      12.43 ns |      12.84 ns |      13.47 ns | 79,334,546.8 |    1 | 0.0076 |      32 B |
| **IsNull**     | **100**    |     **216.93 ns** |     **4.358 ns** |     **5.666 ns** |     **1.157 ns** |     **206.63 ns** |     **213.33 ns** |     **216.38 ns** |     **219.85 ns** |     **232.58 ns** |  **4,609,881.5** |    **3** | **0.0076** |      **32 B** |
| EqualsNull | 100    |     201.63 ns |     1.906 ns |     1.592 ns |     0.441 ns |     197.49 ns |     201.36 ns |     201.84 ns |     202.72 ns |     203.65 ns |  4,959,458.1 |    2 | 0.0076 |      32 B |
| **IsNull**     | **1000**   |   **1,861.80 ns** |    **24.127 ns** |    **21.388 ns** |     **5.716 ns** |   **1,830.20 ns** |   **1,847.80 ns** |   **1,857.79 ns** |   **1,880.52 ns** |   **1,895.25 ns** |    **537,114.4** |    **4** | **0.0076** |      **32 B** |
| EqualsNull | 1000   |   1,866.18 ns |    32.785 ns |    30.668 ns |     7.918 ns |   1,803.67 ns |   1,848.43 ns |   1,857.07 ns |   1,883.39 ns |   1,921.96 ns |    535,853.3 |    4 | 0.0076 |      32 B |
| **IsNull**     | **10000**  |  **50,493.10 ns** |   **763.976 ns** |   **677.245 ns** |   **181.001 ns** |  **49,627.86 ns** |  **49,885.06 ns** |  **50,285.85 ns** |  **51,024.99 ns** |  **51,556.21 ns** |     **19,804.7** |    **5** |      **-** |      **32 B** |
| EqualsNull | 10000  |  51,274.83 ns |   989.130 ns |   925.233 ns |   238.894 ns |  50,088.40 ns |  50,453.45 ns |  50,921.28 ns |  52,271.30 ns |  52,502.28 ns |     19,502.7 |    5 |      - |      32 B |
| **IsNull**     | **100000** | **650,413.83 ns** | **6,542.832 ns** | **5,800.050 ns** | **1,550.129 ns** | **643,569.34 ns** | **645,232.71 ns** | **649,927.00 ns** | **653,774.32 ns** | **660,906.64 ns** |      **1,537.5** |    **6** |      **-** |      **32 B** |
| EqualsNull | 100000 | 647,234.89 ns | 2,779.750 ns | 2,464.176 ns |   658.579 ns | 643,284.72 ns | 646,168.70 ns | 646,544.19 ns | 648,193.77 ns | 652,893.31 ns |      1,545.0 |    6 |      - |      32 B |
