using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {

            return nucleotide.Replace("G", "c").Replace("C", "g").Replace("T", "a").Replace("A", "u").ToUpper();
           
        }
    }
}
