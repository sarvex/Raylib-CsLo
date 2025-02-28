//# raylib 4.0 bindings.   MPL 2.0 Licensed.  Source here: https://github.com/NotNotTech/Raylib-CsLo
//# Find Raylib+docs here:   https://github.com/raysan5/raylib/blob/master/src/raylib.h
//# This file, and it's containing folder are automatically generated.  Do not Modify.
using Raylib_CsLo.InternalHelpers;
using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Raylib_CsLo
{
    public static unsafe partial class RayGui
    {
        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiEnable();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiDisable();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiLock();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiUnlock();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool GuiIsLocked();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiFade(float alpha);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiSetState(int state);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GuiGetState();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiSetFont(Font font);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Font GuiGetFont();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiSetStyle(int control, int property, int value);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GuiGetStyle(int control, int property);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool GuiWindowBox(Rectangle bounds, [NativeTypeName("const char *")] sbyte* title);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiGroupBox(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiLine(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiPanel(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Rectangle GuiScrollPanel(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, Rectangle content, Vector2* scroll);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiLabel(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool GuiButton(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool GuiLabelButton(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool GuiToggle(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, [MarshalAs(UnmanagedType.U1)] bool active);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GuiToggleGroup(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, int active);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool GuiCheckBox(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, [MarshalAs(UnmanagedType.U1)] bool @checked);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GuiComboBox(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, int active);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool GuiDropdownBox(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, int* active, [MarshalAs(UnmanagedType.U1)] bool editMode);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool GuiSpinner(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, int* value, int minValue, int maxValue, [MarshalAs(UnmanagedType.U1)] bool editMode);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool GuiValueBox(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, int* value, int minValue, int maxValue, [MarshalAs(UnmanagedType.U1)] bool editMode);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool GuiTextBox(Rectangle bounds, [NativeTypeName("char *")] sbyte* text, int textSize, [MarshalAs(UnmanagedType.U1)] bool editMode);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool GuiTextBoxMulti(Rectangle bounds, [NativeTypeName("char *")] sbyte* text, int textSize, [MarshalAs(UnmanagedType.U1)] bool editMode);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float GuiSlider(Rectangle bounds, [NativeTypeName("const char *")] sbyte* textLeft, [NativeTypeName("const char *")] sbyte* textRight, float value, float minValue, float maxValue);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float GuiSliderBar(Rectangle bounds, [NativeTypeName("const char *")] sbyte* textLeft, [NativeTypeName("const char *")] sbyte* textRight, float value, float minValue, float maxValue);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float GuiProgressBar(Rectangle bounds, [NativeTypeName("const char *")] sbyte* textLeft, [NativeTypeName("const char *")] sbyte* textRight, float value, float minValue, float maxValue);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiStatusBar(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiDummyRec(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Vector2 GuiGrid(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, float spacing, int subdivs);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GuiListView(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, int* scrollIndex, int active);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GuiListViewEx(Rectangle bounds, [NativeTypeName("const char **")] sbyte** text, int count, int* focus, int* scrollIndex, int active);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GuiMessageBox(Rectangle bounds, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("const char *")] sbyte* message, [NativeTypeName("const char *")] sbyte* buttons);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GuiTextInputBox(Rectangle bounds, [NativeTypeName("const char *")] sbyte* title, [NativeTypeName("const char *")] sbyte* message, [NativeTypeName("const char *")] sbyte* buttons, [NativeTypeName("char *")] sbyte* text, int textMaxSize, int* secretViewActive);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Color GuiColorPicker(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Color GuiColorPanel(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float GuiColorBarAlpha(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, float alpha);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float GuiColorBarHue(Rectangle bounds, [NativeTypeName("const char *")] sbyte* text, float value);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiLoadStyle([NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiLoadStyleDefault();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GuiIconText(int iconId, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiDrawIcon(int iconId, int posX, int posY, int pixelSize, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int *")]
        public static extern uint* GuiGetIcons();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int *")]
        public static extern uint* GuiGetIconData(int iconId);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiSetIconData(int iconId, [NativeTypeName("unsigned int *")] uint* data);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiSetIconScale([NativeTypeName("unsigned int")] uint scale);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiSetIconPixel(int iconId, int x, int y);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GuiClearIconPixel(int iconId, int x, int y);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool GuiCheckIconPixel(int iconId, int x, int y);

        [NativeTypeName("#define RAYGUI_VERSION \"3.2\"")]
        public static ReadOnlySpan<byte> RAYGUI_VERSION => new byte[] { 0x33, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define SCROLLBAR_LEFT_SIDE 0")]
        public const int SCROLLBAR_LEFT_SIDE = 0;

        [NativeTypeName("#define SCROLLBAR_RIGHT_SIDE 1")]
        public const int SCROLLBAR_RIGHT_SIDE = 1;
    }
}
