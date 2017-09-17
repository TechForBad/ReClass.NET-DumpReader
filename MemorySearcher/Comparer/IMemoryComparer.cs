﻿namespace ReClassNET.MemorySearcher.Comparer
{
	public interface IMemoryComparer
	{
		ScanCompareType CompareType { get; }
		int ValueSize { get; }

		bool Compare(byte[] data, int index, out ScanResult result);

		bool Compare(byte[] data, int index, ScanResult previous, out ScanResult result);
	}
}
