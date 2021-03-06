﻿// Copyright (c) Sammi Husky. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;

namespace SALT.Scripting.MSC
{
    public static class MSC_INFO
    {
        #region Sizes
        public static Dictionary<uint, int> Sizes = new Dictionary<uint, int>()
        {
            {0x2, 4},
            {0x3, 0},
            {0x4, 4},
            {0x6, 0},
            {0x7, 0},
            {0x0a, 4},
            {0x0b, 3},
            {0x0d, 2},
            {0x0e, 0},
            {0x0f, 0},
            {0x10, 0},
            {0x11, 0},
            {0x12, 0},
            {0x13, 0},
            {0x14, 3},
            {0x15, 3},
            {0x16, 0},
            {0x17, 0},
            {0x1a, 0},
            {0x1c, 3},
            {0x1d, 3},
            {0x1e, 3},
            {0x1f, 3},
            {0x23, 3},
            {0x25, 0},
            {0x26, 0},
            {0x27, 0},
            {0x28, 0},
            {0x29, 0},
            {0x2a, 0},
            {0x2b, 0},
            {0x2c, 1},
            {0x2d, 2},
            {0x2e, 4},
            {0x2f, 1},
            {0x30, 1},
            {0x31, 1},
            {0x34, 4},
            {0x35, 4},
            {0x36, 4},
            {0x38, 1},
            {0x39, 1},
            {0x3a, 0},
            {0x3b, 0},
            {0x3c, 0},
            {0x3d, 0},
            {0x3e, 0},
            {0x41, 3},
            {0x42, 3},
            {0x43, 3},
            {0x44, 3},
            {0x45, 3},
            {0x46, 0},
            {0x47, 0},
            {0x48, 0},
            {0x49, 0},
            {0x4a, 0},
            {0x4b, 0},
            {0x70, 2},
        };
        #endregion
        #region Names
        public static Dictionary<uint, string> NAMES = new Dictionary<uint, string>()
        {
            {0x2, "BeginSub"},
            {0x3, "End"},
            {0x4, "unk_4"},
            {0x6, "return_6"},
            {0x7, "return"},
            {0xa, "pushInt"},
            {0xb, "push3B"},
            {0xd, "pushShort"},
            {0xe, "unk_8E"},
            {0xf, "unk_1F"},
            {0x10, "unk_10"},
            {0x11, "unk_11"},
            {0x12, "unk_12"},
            {0x13, "unk_13"},
            {0x14, "unk_14"},
            {0x15, "unk_15"},
            {0x16, "unk_16"},
            {0x17, "unk_17"},
            {0x1a, "unk_1A"},
            {0x1c, "Set_Variable"},
            {0x1d, "unk_1D"},
            {0x1e, "unk_1E"},
            {0x1f, "unk_1F"},
            {0x23, "unk_23"},
            {0x25, "unk_25"},
            {0x26, "unk_26"},
            {0x27, "unk_27"},
            {0x28, "unk_28"},
            {0x29, "unk_29"},
            {0x2a, "unk_2A"},
            {0x2b, "unk_2B"},
            {0x2c, "unk_2C"},
            {0x2d, "unk_2D"},
            {0x2e, "unk_2E"},
            {0x2f, "Call_Func"},
            {0x30, "unk_30"},
            {0x31, "Call_Func2"},
            {0x34, "unk_34"},
            {0x35, "unk_35"},
            {0x36, "unk_36"},
            {0x38, "unk_38"},
            {0x39, "unk_39"},
            {0x3a, "unk_3A"},
            {0x3b, "unk_3B"},
            {0x3c, "unk_3C"},
            {0x3d, "unk_3D"},
            {0x3e, "unk_3E"},
            {0x41, "unk_41"},
            {0x42, "unk_42"},
            {0x43, "unk_43"},
            {0x44, "unk_44"},
            {0x45, "unk_45"},
            {0x46, "unk_46"},
            {0x47, "unk_47"},
            {0x48, "unk_48"},
            {0x49, "unk_49"},
            {0x4a, "unk_4A"},
            {0x4b, "unk_4B"},
            {0x70, "unk_70"},
        };
        #endregion
        #region Params

        #region Formats
        public static Dictionary<uint, string> FORMATS = new Dictionary<uint, string>()
        {
            {0x2, "B,B,B,B"},
            {0x3, string.Empty},
            {0x4, "I"},
            {0x6, string.Empty},
            {0x7, string.Empty},
            {0x0a, "I"},
            {0x0b, "B,B,B"},
            {0x0d, "H"},
            {0x0e, string.Empty},
            {0x0f, string.Empty},
            {0x10, string.Empty},
            {0x11, string.Empty},
            {0x12, string.Empty},
            {0x13, string.Empty},
            {0x14, "B,B,B"},
            {0x15, "B,B,B"},
            {0x16, string.Empty},
            {0x17, string.Empty},
            {0x1a, string.Empty},
            {0x1c, "B,B,B"},
            {0x1d, "B,B,B"},
            {0x1e, "B,B,B"},
            {0x1f, "B,B,B"},
            {0x23, "B,B,B"},
            {0x25, string.Empty},
            {0x26, string.Empty},
            {0x27, string.Empty},
            {0x28, string.Empty},
            {0x29, string.Empty},
            {0x2a, string.Empty},
            {0x2b, string.Empty},
            {0x2c, "B"},
            {0x2d, "B,B"},
            {0x2e, "I"},
            {0x2f, "B"},
            {0x30, "B"},
            {0x31, "B"},
            {0x34, "I"},
            {0x35, "I"},
            {0x36, "I"},
            {0x38, "B"},
            {0x39, "B"},
            {0x3a, string.Empty},
            {0x3b, string.Empty},
            {0x3c, string.Empty},
            {0x3d, string.Empty},
            {0x3e, string.Empty},
            {0x41, "B,B,B"},
            {0x42, "B,B,B"},
            {0x43, "B,B,B"},
            {0x44, "B,B,B"},
            {0x45, "B,B,B"},
            {0x46, string.Empty},
            {0x47, string.Empty},
            {0x48, string.Empty},
            {0x49, string.Empty},
            {0x4a, string.Empty},
            {0x4b, string.Empty},
            {0x70, "B,B"},
        };
        #endregion
        #region SYNTAX
        public static Dictionary<uint, string> SYNTAX = new Dictionary<uint, string>()
        {
            {0x2, string.Empty},
            {0x3, string.Empty},
            {0x4, string.Empty},
            {0x6, string.Empty},
            {0x7, string.Empty},
            {0x0a, string.Empty},
            {0x0b, string.Empty},
            {0x0d, string.Empty},
            {0x0e, string.Empty},
            {0x0f, string.Empty},
            {0x10, string.Empty},
            {0x11, string.Empty},
            {0x12, string.Empty},
            {0x13, string.Empty},
            {0x14, string.Empty},
            {0x15, string.Empty},
            {0x16, string.Empty},
            {0x17, string.Empty},
            {0x1a, string.Empty},
            {0x1c, "Global,unk,ID"},
            {0x1d, string.Empty},
            {0x1e, string.Empty},
            {0x1f, string.Empty},
            {0x23, string.Empty},
            {0x25, string.Empty},
            {0x26, string.Empty},
            {0x27, string.Empty},
            {0x28, string.Empty},
            {0x29, string.Empty},
            {0x2a, string.Empty},
            {0x2b, string.Empty},
            {0x2c, string.Empty},
            {0x2d, "ParamCount,ID"},
            {0x2e, string.Empty},
            {0x2f, "Function"},
            {0x30, string.Empty},
            {0x31, string.Empty},
            {0x34, string.Empty},
            {0x35, string.Empty},
            {0x36, string.Empty},
            {0x38, string.Empty},
            {0x39, string.Empty},
            {0x3a, string.Empty},
            {0x3b, string.Empty},
            {0x3c, string.Empty},
            {0x3d, string.Empty},
            {0x3e, string.Empty},
            {0x41, string.Empty},
            {0x42, string.Empty},
            {0x43, string.Empty},
            {0x44, string.Empty},
            {0x45, string.Empty},
            {0x46, string.Empty},
            {0x47, string.Empty},
            {0x48, string.Empty},
            {0x49, string.Empty},
            {0x4a, string.Empty},
            {0x4b, string.Empty},
            {0x70, string.Empty},
        };
        #endregion
        #endregion
    }
}
