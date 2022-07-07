using System;
using System.Diagnostics;
using System.Linq;

namespace Exalgord{
    internal class Teste{
        private static int[] array100;
        private static int[] array1000;
        private static int[] array10000;

        static void Main(string[] args){
            ArrayList();

            var stopwatch = new Stopwatch();

            stopwatch.Start();
            TestarQuickSortRec(ObterArray100());
            stopwatch.Stop();

            Console.WriteLine($"QuickSort Recursivo: {stopwatch.Elapsed}");
            stopwatch.Reset();
            stopwatch.Start();
            TestarQuickSortItr(ObterArray100());
            stopwatch.Stop();

            Console.WriteLine($"QuickSort Iterativo: {stopwatch.Elapsed}");
            stopwatch.Reset();
            stopwatch.Start();
            TestarQuickSortRec(ObterArray1000());
            stopwatch.Stop();

            Console.WriteLine($"QuickSort Recursivo: {stopwatch.Elapsed}");
            stopwatch.Reset();
            stopwatch.Start();
            TestarQuickSortItr(ObterArray1000());
            stopwatch.Stop();

            Console.WriteLine($"QuickSort Iterativo: {stopwatch.Elapsed}");
            stopwatch.Reset();
            stopwatch.Start();
            TestarQuickSortRec(ObterArray10000());
            stopwatch.Stop();

            Console.WriteLine($"QuickSort Recursivo: {stopwatch.Elapsed}");
            stopwatch.Reset();
            stopwatch.Start();
            TestarQuickSortItr(ObterArray10000());
            stopwatch.Stop();

            Console.WriteLine($"QuickSort Iterativo: {stopwatch.Elapsed}");
            stopwatch.Reset();
        }
        private static void ArrayList(){
            var random = new Random();

            array100 = new int[100];
            array1000 = new int[1000];
            array10000 = new int[10000];

            ArrayListed(array100, random);
            ArrayListed(array1000, random);
            ArrayListed(array10000, random);
        }
        private static void ArrayListed(int[] array, Random random){
            for (var i = 0; i < array.Length - 1; i++)
            {
                array[i] = random.Next(0, array.Length);
            }
        }
        private static void TestarQuickSortItr(int[] arr){
            new QuickSortItr().Sort(arr);
        }
        private static void TestarQuickSortRec(int[] arr){
            new QuickSortRec().Sort(ref arr, 0, arr.Length - 1);
        }
        private static int[] ObterArray100(){
            int[] arr = new int[100];
            Array.Copy(array100, arr, array100.Length);
            return arr;
        }
        private static int[] ObterArray1000(){
            int[] arr = new int[1000];
            Array.Copy(array1000, arr, array1000.Length);
            return arr;
        }
        private static int[] ObterArray10000(){
            int[] arr = new int[10000];
            Array.Copy(array10000, arr, array10000.Length);
            return arr;
        }
    }
}