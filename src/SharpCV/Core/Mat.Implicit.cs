﻿using NumSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharpCV
{
    public partial class Mat
    {
        public static implicit operator IntPtr(Mat mat)
            => mat._handle;

        public static implicit operator Mat(IntPtr handle)
            => new Mat(handle);

        public static implicit operator NDArray(Mat mat)
            => mat.data;
    }
}
