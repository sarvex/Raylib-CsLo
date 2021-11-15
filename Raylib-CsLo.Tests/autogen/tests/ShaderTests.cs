//# raylib 4.0 bindings.   Lgpl Licensed.  Source here: https://github.com/NotNotTech/Raylib-CsLo
//# Find Raylib+docs here:   https://github.com/raysan5/raylib/blob/master/src/raylib.h
//# This file, and it's containing folder are automatically generated.  Do not Modify.
using System;
using System.Runtime.InteropServices;
using Xunit;

namespace Raylib_CsLo.UnitTests
{
    /// <summary>Provides validation of the <see cref="Shader" /> struct.</summary>
    public static unsafe partial class ShaderTests
    {
        /// <summary>Validates that the <see cref="Shader" /> struct is blittable.</summary>
        [Fact]
        public static void IsBlittableTest()
        {
            Assert.Equal(sizeof(Shader), Marshal.SizeOf<Shader>());
        }

        /// <summary>Validates that the <see cref="Shader" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Fact]
        public static void IsLayoutSequentialTest()
        {
            Assert.True(typeof(Shader).IsLayoutSequential);
        }

        /// <summary>Validates that the <see cref="Shader" /> struct has the correct size.</summary>
        [Fact]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.Equal(16, sizeof(Shader));
            }
            else
            {
                Assert.Equal(8, sizeof(Shader));
            }
        }
    }
}
