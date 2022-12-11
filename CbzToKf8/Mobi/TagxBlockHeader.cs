﻿// Copyright 2022 Carl Reinke
//
// This file is part of a program that is licensed under the terms of the GNU
// Affero General Public License Version 3 as published by the Free Software
// Foundation.
//
// This license does not grant rights under trademark law for use of any trade
// names, trademarks, or service marks.

namespace CbzToKf8.Mobi
{
    internal struct TagxBlockHeader
    {
        public const uint TagxMagicValue = 0x54414758;  // "TAGX"

        public uint TagxMagic;
        public uint TagxLength;
        public uint ValuesDescriptorLength;
    }
}
