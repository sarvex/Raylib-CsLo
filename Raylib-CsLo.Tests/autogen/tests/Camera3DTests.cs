//# raylib 4.0 bindings.   Lgpl Licensed.  Source here: https://github.com/NotNotTech/Raylib-CsLo
//# Find Raylib+docs here:   https://github.com/raysan5/raylib/blob/master/src/raylib.h
//# This file, and it's containing folder are automatically generated.  Do not Modify.
using System.Runtime.InteropServices;
using Xunit;

namespace Raylib_CsLo.UnitTests
{
    /// <summary>Provides validation of the <see cref="Camera3D" /> struct.</summary>
    public static unsafe partial class Camera3DTests
    {
        /// <summary>Validates that the <see cref="Camera3D" /> struct is blittable.</summary>
        [Fact]
        public static void IsBlittableTest()
        {
            Assert.Equal(sizeof(Camera3D), Marshal.SizeOf<Camera3D>());
        }

        /// <summary>Validates that the <see cref="Camera3D" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Fact]
        public static void IsLayoutSequentialTest()
        {
            Assert.True(typeof(Camera3D).IsLayoutSequential);
        }

        /// <summary>Validates that the <see cref="Camera3D" /> struct has the correct size.</summary>
        [Fact]
        public static void SizeOfTest()
        {
            Assert.Equal(44, sizeof(Camera3D));
        }
    }
}
