//# raylib 4.0 bindings.   Lgpl Licensed.  Source here: https://github.com/NotNotTech/Raylib-CsLo
//# Find Raylib+docs here:   https://github.com/raysan5/raylib/blob/master/src/raylib.h
//# This file, and it's containing folder are automatically generated.  Do not Modify.
namespace Raylib_CsLo
{
    public unsafe partial struct Material
    {
        public Shader shader;

        public MaterialMap* maps;

        [NativeTypeName("float [4]")]
        public fixed float @params[4];
    }
}
