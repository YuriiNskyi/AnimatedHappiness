# AnimatedHappiness
Test console application, which calculates a bunch of simple methods.

Consists of four parts.

## AnimatedHappiness
Main console application, which provides bridge between user and application below.
## AnimatedHappiness.Core
Provides `AnimatedHappinessCalculator` - static class, which calculates three tasks:
- Unique numbers in both arrays.
- Unique odd numbers in first array and their quantity in second array.
- Sum of unique even numbers in first array, which not present in second array.
## AnimatedHappiness.Tests
Simple unit tests of `AnimatedHappinessCalculator`.
## AnimatedHappiness.Benchmarks
Benchmark, which measures performance of `AnimatedHappinessCalculator`.
### Example of benchmark result
``` ini

BenchmarkDotNet=v0.11.3, OS=Windows 10.0.17134.523 (1803/April2018Update/Redstone4)
Intel Core i5-7200U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.2.200-preview-009648
  [Host]     : .NET Core 2.2.0 (CoreCLR 4.6.27110.04, CoreFX 4.6.27110.04), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.0 (CoreCLR 4.6.27110.04, CoreFX 4.6.27110.04), 64bit RyuJIT


```
|                    Method | Length |            Mean |         Error |          StdDev |          Median |
|-------------------------- |------- |----------------:|--------------:|----------------:|----------------:|
|    **CalculateUniqueNumbers** |      **0** |        **312.4 ns** |      **23.84 ns** |        **69.91 ns** |        **297.0 ns** |
| CalculateUniqueOddNumbers |      0 |        364.9 ns |      21.08 ns |        62.15 ns |        370.3 ns |
|   CalculateEvenNumbersSum |      0 |        453.1 ns |      31.78 ns |        93.21 ns |        456.9 ns |
|    **CalculateUniqueNumbers** |      **1** |        **667.9 ns** |      **34.16 ns** |        **98.01 ns** |        **678.2 ns** |
| CalculateUniqueOddNumbers |      1 |        725.0 ns |      38.62 ns |       112.65 ns |        721.7 ns |
|   CalculateEvenNumbersSum |      1 |        792.7 ns |      57.98 ns |       170.96 ns |        740.7 ns |
|    **CalculateUniqueNumbers** |      **5** |      **1,555.9 ns** |     **108.87 ns** |       **321.02 ns** |      **1,469.3 ns** |
| CalculateUniqueOddNumbers |      5 |      1,866.8 ns |     135.75 ns |       398.14 ns |      1,797.1 ns |
|   CalculateEvenNumbersSum |      5 |              NA |            NA |              NA |              NA |
|    **CalculateUniqueNumbers** |     **10** |      **3,016.8 ns** |     **237.71 ns** |       **700.90 ns** |      **3,019.0 ns** |
| CalculateUniqueOddNumbers |     10 |      4,668.0 ns |     291.46 ns |       859.39 ns |      4,517.9 ns |
|   CalculateEvenNumbersSum |     10 |              NA |            NA |              NA |              NA |
|    **CalculateUniqueNumbers** |     **25** |      **6,421.2 ns** |     **210.03 ns** |       **602.60 ns** |      **6,452.1 ns** |
| CalculateUniqueOddNumbers |     25 |     18,575.8 ns |   1,010.33 ns |     2,978.97 ns |     17,590.8 ns |
|   CalculateEvenNumbersSum |     25 |              NA |            NA |              NA |              NA |
|    **CalculateUniqueNumbers** |     **50** |     **11,856.6 ns** |     **642.51 ns** |     **1,894.45 ns** |     **11,933.0 ns** |
| CalculateUniqueOddNumbers |     50 |     58,289.8 ns |   1,376.71 ns |     3,950.03 ns |     57,423.2 ns |
|   CalculateEvenNumbersSum |     50 |              NA |            NA |              NA |              NA |
|    **CalculateUniqueNumbers** |    **100** |     **18,864.5 ns** |     **694.00 ns** |     **1,923.07 ns** |     **19,204.4 ns** |
| CalculateUniqueOddNumbers |    100 |    189,206.5 ns |   4,287.34 ns |    11,951.38 ns |    189,524.4 ns |
|   CalculateEvenNumbersSum |    100 |              NA |            NA |              NA |              NA |
|    **CalculateUniqueNumbers** |    **250** |     **45,727.1 ns** |     **903.90 ns** |     **1,267.14 ns** |     **45,437.7 ns** |
| CalculateUniqueOddNumbers |    250 |  1,088,649.8 ns |  21,710.81 ns |    35,671.48 ns |  1,076,409.6 ns |
|   CalculateEvenNumbersSum |    250 |              NA |            NA |              NA |              NA |
|    **CalculateUniqueNumbers** |    **500** |     **89,645.9 ns** |   **1,771.69 ns** |     **2,810.09 ns** |     **88,464.2 ns** |
| CalculateUniqueOddNumbers |    500 |  4,648,447.4 ns | 208,364.16 ns |   614,366.43 ns |  4,427,896.2 ns |
|   CalculateEvenNumbersSum |    500 |              NA |            NA |              NA |              NA |
|    **CalculateUniqueNumbers** |   **1000** |    **207,274.7 ns** |  **11,362.73 ns** |    **33,503.27 ns** |    **207,787.2 ns** |
| CalculateUniqueOddNumbers |   1000 | 18,335,928.5 ns | 558,223.22 ns | 1,645,933.77 ns | 18,148,292.2 ns |
|   CalculateEvenNumbersSum |   1000 |              NA |            NA |              NA |              NA |

## Example of usage
Main console application:
```
dotnet .\AnimatedHappiness.dll -p <path to the specified .json file>
```
Benchmarks:
```
dotnet .\AnimatedHappiness.Benchmarks.dll
```
