using NUnit.Framework;
[assembly: Parallelizable(ParallelScope.Fixtures)]
[assembly: LevelOfParallelism(3)]  // Adjust this to the number of desired threads
