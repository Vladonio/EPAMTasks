using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// Задача: реализовать метод Filter, который должен возвращать входной массив, в котором удалены элементы, которые встречаются более одного раза.
//   * Значения в массиве должны следовать в том порядке, в котором они следуют в оригинальном массиве.
//   * Если в массиве встречаются повторяющиеся значения, то они ВСЕ значения должны быть удалены.
//   * Метод должен выбрасывать исключение ArgumentNullException в случае, если в метод передали null.
//   * В решении разрешается использовать только конструкции языка. Использовать LINQ запрещено.

public class Program
{
	public static int[] Filter(int[] source)
	{
		if ( source == null )
			throw new ArgumentNullException();
		
		HashSet<int> uniqueElements = new HashSet<int>();
		
		//var tempList = source.ToList();
		var tempList = GetListFromArray(source);
		for (int i = 0; i < source.Length; i++)
		{	
			if ( uniqueElements.Contains(source[i]) )
				tempList.RemoveAll((int x) => x == source[i]);
			uniqueElements.Add(source[i]);
		}
		
		return GetArrayFromList(tempList);
	}

	// ДОБАВЬТЕ НОВЫЕ МЕТОДЫ, ЕСЛИ НЕОБХОДИМО
	
	public static List<int> GetListFromArray(int[] source)
	{
		List<int> result = new List<int>();
		foreach (int el in source)
		{
			result.Add(el);
		}
		return result;
	}
	
	public static int[] GetArrayFromList(List<int> source)
	{
		int[] result = new int[source.Count()];
		for (int i = 0; i < source.Count(); i++)
		{
			result[i] = source[i];
		}
		return result;
	}

	// ----- ЗАПРЕЩЕНО ИЗМЕНЯТЬ КОД МЕТОДОВ, КОТОРЫЕ НАХОДЯТСЯ НИЖЕ -----

	public static void Main()
	{
		Console.WriteLine("Task is done when all test cases are correct:");
		
		int testCaseNumber = 1;

		TestReturnedValues(testCaseNumber++, new int[] { }, new int[] { });
		TestReturnedValues(testCaseNumber++, new int[] { 0 }, new int[] { 0 });
		TestReturnedValues(testCaseNumber++, new int[] { 0, 1}, new int[] { 0, 1 });
		TestReturnedValues(testCaseNumber++, new int[] { 0, 0}, new int[] { });
		TestReturnedValues(testCaseNumber++, new int[] { 0, 1, 0}, new int[] { 1 });
		TestReturnedValues(testCaseNumber++, new int[] { 0, 1, 0, 1 }, new int[] { });
		TestReturnedValues(testCaseNumber++, new int[] { 0, 1, 2, 2, 5, 4, 4, 5, 1, 8, 4, 9, 1, 3, 4, 5, 7 }, new int[] { 0, 8, 9, 3, 7 });
		TestException<ArgumentNullException>(testCaseNumber++, null);
		
		if (correctTestCaseAmount == testCaseNumber - 1)
		{
			Console.WriteLine("Task is done.");
		}
		else
		{
			Console.WriteLine("TASK IS NOT DONE.");
		}
	}

	private static void TestReturnedValues(int testCaseNumber, int[] array, int[] expectedResult)
	{
		try
		{
			var result = Filter(array);
			
			if (result.SequenceEqual(expectedResult))
			{
				Console.WriteLine(correctCaseTemplate, testCaseNumber);
				correctTestCaseAmount++;
			}
			else
			{
				Console.WriteLine(incorrectCaseTemplate, testCaseNumber);
			}
		}
		catch(Exception)
		{
			Console.WriteLine(correctCaseTemplate, testCaseNumber);
		}
	}
	
	private static void TestException<T>(int testCaseNumber, int[] array) where T : Exception
	{
		try
		{
			Filter(array);
			Console.WriteLine(incorrectCaseTemplate, testCaseNumber);
		}
		catch (T)
		{
			Console.WriteLine(correctCaseTemplate, testCaseNumber);
			correctTestCaseAmount++;
		}
		catch (Exception)
		{
			Console.WriteLine(incorrectCaseTemplate, testCaseNumber);
		}
	}

	private static string correctCaseTemplate = "Case #{0} is correct.";
	private static string incorrectCaseTemplate = "Case #{0} IS NOT CORRECT";
	private static int correctTestCaseAmount = 0;
}