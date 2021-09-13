// * Summary *

BenchmarkDotNet=v0.13.1, OS=macOS Big Sur 11.5.2 (20G95) [Darwin 20.6.0]
Intel Core i7-9750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK=6.0.100-preview.7.21379.14
[Host]     : .NET 6.0.0 (6.0.21.37719), X64 RyuJIT
DefaultJob : .NET 6.0.0 (6.0.21.37719), X64 RyuJIT


|                                         Method | value |       Mean |     Error |    StdDev | Ratio | RatioSD |
|----------------------------------------------- |------ |-----------:|----------:|----------:|------:|--------:|
|                              UsingDefaultParse |   AUT |  60.494 ns | 1.2066 ns | 1.1287 ns | 12.29 |    0.32 |
|      UsingGenericLinqGeneratedDictionaryParser |   AUT |  18.050 ns | 0.3417 ns | 0.3656 ns |  3.67 |    0.09 |
| UsingOtherGenericLinqGeneratedDictionaryParser |   AUT |  18.842 ns | 0.3867 ns | 0.4137 ns |  3.82 |    0.12 |
|                  UsingExplicitDictionaryParser |   AUT |  15.537 ns | 0.2255 ns | 0.1999 ns |  3.15 |    0.07 |
|                                    UsingSwitch |   AUT |   4.925 ns | 0.0746 ns | 0.0697 ns |  1.00 |    0.00 |
|                                                |       |            |           |           |       |         |
|                              UsingDefaultParse |   BEL |  65.614 ns | 1.0476 ns | 1.5025 ns | 13.70 |    0.48 |
|      UsingGenericLinqGeneratedDictionaryParser |   BEL |  18.106 ns | 0.3477 ns | 0.5310 ns |  3.79 |    0.10 |
| UsingOtherGenericLinqGeneratedDictionaryParser |   BEL |  16.806 ns | 0.3006 ns | 0.2510 ns |  3.48 |    0.08 |
|                  UsingExplicitDictionaryParser |   BEL |  16.811 ns | 0.2025 ns | 0.1795 ns |  3.47 |    0.10 |
|                                    UsingSwitch |   BEL |   4.840 ns | 0.1240 ns | 0.1160 ns |  1.00 |    0.00 |
|                                                |       |            |           |           |       |         |
|                              UsingDefaultParse |   FIN |  98.763 ns | 1.9950 ns | 2.1346 ns | 23.33 |    0.71 |
|      UsingGenericLinqGeneratedDictionaryParser |   FIN |  19.252 ns | 0.3732 ns | 0.6730 ns |  4.52 |    0.18 |
| UsingOtherGenericLinqGeneratedDictionaryParser |   FIN |  16.821 ns | 0.3541 ns | 0.2957 ns |  3.96 |    0.08 |
|                  UsingExplicitDictionaryParser |   FIN |  15.622 ns | 0.2459 ns | 0.2300 ns |  3.69 |    0.10 |
|                                    UsingSwitch |   FIN |   4.237 ns | 0.0788 ns | 0.0737 ns |  1.00 |    0.00 |
|                                                |       |            |           |           |       |         |
|                              UsingDefaultParse |   SWE | 187.398 ns | 2.9083 ns | 2.7204 ns | 33.37 |    0.79 |
|      UsingGenericLinqGeneratedDictionaryParser |   SWE |  17.776 ns | 0.2790 ns | 0.2610 ns |  3.17 |    0.09 |
| UsingOtherGenericLinqGeneratedDictionaryParser |   SWE |  16.593 ns | 0.2353 ns | 0.2085 ns |  2.95 |    0.08 |
|                  UsingExplicitDictionaryParser |   SWE |  13.943 ns | 0.2040 ns | 0.2580 ns |  2.50 |    0.07 |
|                                    UsingSwitch |   SWE |   5.574 ns | 0.1314 ns | 0.1564 ns |  1.00 |    0.00 |
