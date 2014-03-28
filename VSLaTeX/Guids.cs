// Guids.cs
// MUST match guids.h
using System;

namespace Informagic.VSLaTeX
{
    static class GuidList
    {
        public const string guidVSLaTeXPkgString = "ded84600-4bf1-4137-803a-454d7e26e5da";
        public const string guidVSLaTeXCmdSetString = "7526674d-df26-4b79-b3c1-c116959de2ea";

        public static readonly Guid guidVSLaTeXCmdSet = new Guid(guidVSLaTeXCmdSetString);
    };
}