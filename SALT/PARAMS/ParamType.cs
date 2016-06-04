﻿// Copyright (c) Sammi Husky. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SALT.PARAMS
{
    public enum ParamType : byte
    {
        u8 = 1,
        s8 = 2,
        u16 = 3,
        s16 = 4,
        u32 = 5,
        s32 = 6,
        f32 = 7,
        str = 8,
        group = 0x20
    }
}
