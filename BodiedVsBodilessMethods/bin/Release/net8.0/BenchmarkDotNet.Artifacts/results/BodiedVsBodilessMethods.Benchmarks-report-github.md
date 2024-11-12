```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4317/23H2/2023Update/SunValley3)
Intel Core i7-1065G7 CPU 1.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method          | Count  | Mean           | Error         | StdDev      | StdErr      | Min            | Q1             | Median         | Q3             | Max            | Op/s          | Rank | Allocated |
|---------------- |------- |---------------:|--------------:|------------:|------------:|---------------:|---------------:|---------------:|---------------:|---------------:|--------------:|-----:|----------:|
| **BodiedMethods**   | **10**     |       **8.645 ns** |     **0.1378 ns** |   **0.1289 ns** |   **0.0333 ns** |       **8.364 ns** |       **8.620 ns** |       **8.673 ns** |       **8.716 ns** |       **8.820 ns** | **115,673,283.3** |    **1** |         **-** |
| BodilessMethods | 10     |       8.707 ns |     0.0474 ns |   0.0421 ns |   0.0112 ns |       8.653 ns |       8.672 ns |       8.707 ns |       8.724 ns |       8.792 ns | 114,852,355.8 |    1 |         - |
| **BodiedMethods**   | **100**    |     **112.416 ns** |     **2.2777 ns** |   **3.6127 ns** |   **0.6289 ns** |     **107.238 ns** |     **109.478 ns** |     **111.502 ns** |     **114.765 ns** |     **121.138 ns** |   **8,895,509.6** |    **2** |         **-** |
| BodilessMethods | 100    |     107.742 ns |     0.9741 ns |   0.8134 ns |   0.2256 ns |     106.476 ns |     107.242 ns |     107.547 ns |     108.035 ns |     109.780 ns |   9,281,445.3 |    2 |         - |
| **BodiedMethods**   | **1000**   |   **1,080.122 ns** |    **21.4981 ns** |  **45.3468 ns** |   **6.1709 ns** |   **1,021.470 ns** |   **1,049.788 ns** |   **1,068.489 ns** |   **1,091.819 ns** |   **1,274.476 ns** |     **925,821.3** |    **4** |         **-** |
| BodilessMethods | 1000   |   1,006.453 ns |     8.8721 ns |   7.8649 ns |   2.1020 ns |     995.109 ns |   1,000.882 ns |   1,005.836 ns |   1,012.495 ns |   1,022.378 ns |     993,588.2 |    3 |         - |
| **BodiedMethods**   | **10000**  |  **10,209.553 ns** |   **131.0058 ns** | **116.1333 ns** |  **31.0379 ns** |  **10,075.030 ns** |  **10,113.296 ns** |  **10,196.648 ns** |  **10,221.461 ns** |  **10,419.015 ns** |      **97,947.5** |    **5** |         **-** |
| BodilessMethods | 10000  |  10,287.530 ns |   179.3199 ns | 199.3135 ns |  45.7257 ns |  10,078.625 ns |  10,172.951 ns |  10,217.649 ns |  10,277.512 ns |  10,800.684 ns |      97,205.1 |    5 |         - |
| **BodiedMethods**   | **100000** | **101,930.137 ns** |   **819.9809 ns** | **767.0106 ns** | **198.0413 ns** | **100,715.540 ns** | **101,260.529 ns** | **102,113.770 ns** | **102,535.291 ns** | **103,246.826 ns** |       **9,810.6** |    **6** |         **-** |
| BodilessMethods | 100000 | 101,884.485 ns | 1,008.5278 ns | 943.3775 ns | 243.5790 ns | 100,775.903 ns | 101,207.892 ns | 101,513.647 ns | 102,545.892 ns | 104,168.225 ns |       9,815.0 |    6 |         - |