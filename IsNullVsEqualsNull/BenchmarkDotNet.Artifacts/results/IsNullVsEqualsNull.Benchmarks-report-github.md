```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4317/23H2/2023Update/SunValley3)
Intel Core i7-1065G7 CPU 1.30GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.403
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method     | Count  | Mean | Error | Rank |
|----------- |------- |-----:|------:|-----:|
| IsNull     | 1      |   NA |    NA |    ? |
| EqualsNull | 1      |   NA |    NA |    ? |
| IsNull     | 100    |   NA |    NA |    ? |
| EqualsNull | 100    |   NA |    NA |    ? |
| IsNull     | 1000   |   NA |    NA |    ? |
| EqualsNull | 1000   |   NA |    NA |    ? |
| IsNull     | 10000  |   NA |    NA |    ? |
| EqualsNull | 10000  |   NA |    NA |    ? |
| IsNull     | 100000 |   NA |    NA |    ? |
| EqualsNull | 100000 |   NA |    NA |    ? |

Benchmarks with issues:
  Benchmarks.IsNull: DefaultJob [Count=1]
  Benchmarks.EqualsNull: DefaultJob [Count=1]
  Benchmarks.IsNull: DefaultJob [Count=100]
  Benchmarks.EqualsNull: DefaultJob [Count=100]
  Benchmarks.IsNull: DefaultJob [Count=1000]
  Benchmarks.EqualsNull: DefaultJob [Count=1000]
  Benchmarks.IsNull: DefaultJob [Count=10000]
  Benchmarks.EqualsNull: DefaultJob [Count=10000]
  Benchmarks.IsNull: DefaultJob [Count=100000]
  Benchmarks.EqualsNull: DefaultJob [Count=100000]
