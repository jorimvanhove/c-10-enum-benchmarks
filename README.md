// * Summary *

BenchmarkDotNet=v0.13.1, OS=macOS Big Sur 11.5.2 (20G95) [Darwin 20.6.0]
Intel Core i7-9750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.100-preview.7.21379.14
[Host]     : .NET 6.0.0 (6.0.21.37719), X64 RyuJIT
DefaultJob : .NET 6.0.0 (6.0.21.37719), X64 RyuJIT


|                                         Method | value |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|----------------------------------------------- |------ |-----------:|----------:|----------:|-----------:|------:|--------:|
|                              UsingDefaultParse |   AUT |  58.459 ns | 1.5070 ns | 4.2009 ns |  57.265 ns |  1.00 |    0.00 |
|      UsingGenericLinqGeneratedDictionaryParser |   AUT |  17.331 ns | 0.3678 ns | 0.3777 ns |  17.295 ns |  0.28 |    0.02 |
| UsingOtherGenericLinqGeneratedDictionaryParser |   AUT |  17.725 ns | 0.2967 ns | 0.2477 ns |  17.765 ns |  0.29 |    0.02 |
|                  UsingExplicitDictionaryParser |   AUT |  14.828 ns | 0.1847 ns | 0.1728 ns |  14.795 ns |  0.24 |    0.02 |
|                                    UsingSwitch |   AUT |   4.886 ns | 0.1233 ns | 0.1211 ns |   4.846 ns |  0.08 |    0.01 |
|                                                |       |            |           |           |            |       |         |
|                              UsingDefaultParse |   BEL |  60.914 ns | 1.2416 ns | 1.6575 ns |  60.285 ns |  1.00 |    0.00 |
|      UsingGenericLinqGeneratedDictionaryParser |   BEL |  16.683 ns | 0.2371 ns | 0.2217 ns |  16.612 ns |  0.27 |    0.01 |
| UsingOtherGenericLinqGeneratedDictionaryParser |   BEL |  15.721 ns | 0.1390 ns | 0.1161 ns |  15.700 ns |  0.26 |    0.01 |
|                  UsingExplicitDictionaryParser |   BEL |  15.801 ns | 0.1311 ns | 0.1095 ns |  15.778 ns |  0.26 |    0.01 |
|                                    UsingSwitch |   BEL |   4.757 ns | 0.0550 ns | 0.0487 ns |   4.750 ns |  0.08 |    0.00 |
|                                                |       |            |           |           |            |       |         |
|                              UsingDefaultParse |   FIN |  93.941 ns | 1.1898 ns | 0.9936 ns |  93.757 ns |  1.00 |    0.00 |
|      UsingGenericLinqGeneratedDictionaryParser |   FIN |  17.835 ns | 0.2377 ns | 0.2223 ns |  17.797 ns |  0.19 |    0.00 |
| UsingOtherGenericLinqGeneratedDictionaryParser |   FIN |  15.490 ns | 0.3043 ns | 0.3125 ns |  15.405 ns |  0.17 |    0.00 |
|                  UsingExplicitDictionaryParser |   FIN |  14.079 ns | 0.2139 ns | 0.2000 ns |  13.992 ns |  0.15 |    0.00 |
|                                    UsingSwitch |   FIN |   4.220 ns | 0.1119 ns | 0.1289 ns |   4.158 ns |  0.05 |    0.00 |
|                                                |       |            |           |           |            |       |         |
|                              UsingDefaultParse |   SWE | 180.393 ns | 2.8922 ns | 2.5638 ns | 180.206 ns |  1.00 |    0.00 |
|      UsingGenericLinqGeneratedDictionaryParser |   SWE |  16.687 ns | 0.1063 ns | 0.0887 ns |  16.703 ns |  0.09 |    0.00 |
| UsingOtherGenericLinqGeneratedDictionaryParser |   SWE |  15.715 ns | 0.1439 ns | 0.1346 ns |  15.680 ns |  0.09 |    0.00 |
|                  UsingExplicitDictionaryParser |   SWE |  12.739 ns | 0.0707 ns | 0.0591 ns |  12.741 ns |  0.07 |    0.00 |
|                                    UsingSwitch |   SWE |   5.143 ns | 0.0533 ns | 0.0473 ns |   5.131 ns |  0.03 |    0.00 |

