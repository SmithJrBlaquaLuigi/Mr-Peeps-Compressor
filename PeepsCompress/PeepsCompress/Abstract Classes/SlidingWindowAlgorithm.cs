﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PeepsCompress
{
    abstract class SlidingWindowAlgorithm : Compression
    {

        public int[] findAllMatches(ref List<byte> dictionary, byte match)
        {
            List<int> matchPositons = new List<int>();

            for (int i = 0; i < dictionary.Count; i++)
            {
                if (dictionary[i] == match)
                {
                    matchPositons.Add(i);
                }
            }

            return matchPositons.ToArray();
        } //Consider moving this into a SlidingAlgorithm parent class

        public int[] findLargestMatch(ref List<byte> dictionary, int[] matchesFound, ref byte[] file, int fileIndex)
        {
            int[] matchSizes = new int[matchesFound.Length];

            for (int i = 0; i < matchesFound.Length; i++)
            {
                int matchSize = 1;
                bool matchFound = true;

                while (matchFound && (fileIndex + matchSize < file.Length && matchesFound[i] + matchSize < dictionary.Count))
                {
                    if (file[fileIndex + matchSize] == dictionary[matchesFound[i] + matchSize])
                    {
                        matchSize++;
                    }
                    else
                    {
                        matchFound = false;
                    }

                }

                matchSizes[i] = matchSize;
            }

            int[] bestMatch = new int[2];

            bestMatch[0] = matchesFound[0];
            bestMatch[1] = matchSizes[0];

            for (int i = 1; i < matchesFound.Length; i++)
            {
                if (matchSizes[i] > bestMatch[1])
                {
                    bestMatch[0] = matchesFound[i];
                    bestMatch[1] = matchSizes[i];
                }
            }

            return bestMatch;

        } //Consider moving this into a SlidingAlgorithm parent class

    }
}
