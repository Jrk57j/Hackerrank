using hackerrankbullshit;
using hackerrankbullshit.Comparison;
using hackerrankbullshit.Conversions;
using hackerrankbullshit.Mathy;
using hackerrankbullshit.Prints;
using hackerrankbullshit.Sorting;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

class Program
{
	static void Main(string[] args)
	{
		BS bs = new();

		PlusMinus pm = new();
		bs.OutputString(pm.GetType().Name, pm.Run());

		MiniMaxSum mms = new();
		bs.OutputString(mms.GetType().Name, mms.Run());

		TimeConversion tc = new();
		bs.OutputString(tc.GetType().Name, tc.Run());

		FindMedian fm = new();
		bs.OutputString(fm.GetType().Name, fm.Run().ToString());

		//DiagonalDifference dd = new();
		//dd.Run();

		CountingSort cs = new();
		bs.OutputIntList(cs.GetType().Name, cs.Run());

		CompareTwoVersions ctv = new();
		bs.OutputInt(ctv.GetType().Name, ctv.Run());

		ZigZag zz = new();
		bs.OutputIntList(zz.GetType().Name, zz.Run());
		
		CompareTheTriplets ctt = new();
		bs.OutputIntList(ctt.GetType().Name, ctt.Run());

		AVeryBigSum avbs = new AVeryBigSum();
		bs.OutputLong(avbs.GetType().Name, avbs.Run());

		StairCase sc = new();
		sc.Run();
		Console.WriteLine();

		BirthdayCakeCandles bcc = new();
		bs.OutputInt(bcc.GetType().Name,  bcc.Run());

		DayOfTheProgrammer dotp = new();
		bs.OutputString(dotp.GetType().Name, dotp.Run());
	}
}
