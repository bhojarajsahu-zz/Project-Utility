// Guids.cs
// MUST match guids.h
using System;

namespace bhojarajsahu88.SBLUtility
{
    static class GuidList
    {
        public const string guidSBLUtilityPkgString = "da7aca7b-fd57-4ab7-b1ec-293c1f4166ed";
        public const string guidSBLUtilityCmdSetString = "4ade2348-088f-428e-b9a4-b4a92d0c30d1";

        public static readonly Guid guidSBLUtilityCmdSet = new Guid(guidSBLUtilityCmdSetString);
    };
}