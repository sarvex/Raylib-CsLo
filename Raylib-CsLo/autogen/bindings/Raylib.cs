//# raylib 4.0 bindings.   MPL 2.0 Licensed.  Source here: https://github.com/NotNotTech/Raylib-CsLo
//# Find Raylib+docs here:   https://github.com/raysan5/raylib/blob/master/src/raylib.h
//# This file, and it's containing folder are automatically generated.  Do not Modify.
using Raylib_CsLo.InternalHelpers;
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using static Raylib_CsLo.MaterialMapIndex;
using static Raylib_CsLo.MouseButton;
using static Raylib_CsLo.ShaderLocationIndex;

namespace Raylib_CsLo
{
    public static unsafe partial class Raylib
    {
        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void InitWindow(int width, int height, [NativeTypeName("const char *")] sbyte* title);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool WindowShouldClose();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void CloseWindow();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsWindowReady();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsWindowFullscreen();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsWindowHidden();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsWindowMinimized();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsWindowMaximized();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsWindowFocused();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsWindowResized();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsWindowState([NativeTypeName("unsigned int")] uint flag);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetWindowState([NativeTypeName("unsigned int")] uint flags);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ClearWindowState([NativeTypeName("unsigned int")] uint flags);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ToggleFullscreen();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MaximizeWindow();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MinimizeWindow();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void RestoreWindow();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetWindowIcon(Image image);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetWindowTitle([NativeTypeName("const char *")] sbyte* title);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetWindowPosition(int x, int y);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetWindowMonitor(int monitor);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetWindowMinSize(int width, int height);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetWindowSize(int width, int height);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetWindowOpacity(float opacity);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* GetWindowHandle();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetScreenWidth();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetScreenHeight();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetRenderWidth();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetRenderHeight();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetMonitorCount();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetCurrentMonitor();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Vector2 GetMonitorPosition(int monitor);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetMonitorWidth(int monitor);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetMonitorHeight(int monitor);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetMonitorPhysicalWidth(int monitor);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetMonitorPhysicalHeight(int monitor);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetMonitorRefreshRate(int monitor);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Vector2 GetWindowPosition();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Vector2 GetWindowScaleDPI();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetMonitorName(int monitor);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetClipboardText([NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetClipboardText();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void EnableEventWaiting();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DisableEventWaiting();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SwapScreenBuffer();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PollInputEvents();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void WaitTime(double seconds);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ShowCursor();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void HideCursor();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsCursorHidden();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void EnableCursor();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DisableCursor();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsCursorOnScreen();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ClearBackground(Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void BeginDrawing();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void EndDrawing();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void BeginMode2D(Camera2D camera);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void EndMode2D();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void BeginMode3D(Camera3D camera);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void EndMode3D();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void BeginTextureMode([NativeTypeName("RenderTexture2D")] RenderTexture target);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void EndTextureMode();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void BeginShaderMode(Shader shader);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void EndShaderMode();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void BeginBlendMode(int mode);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void EndBlendMode();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void BeginScissorMode(int x, int y, int width, int height);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void EndScissorMode();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void BeginVrStereoMode(VrStereoConfig config);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void EndVrStereoMode();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern VrStereoConfig LoadVrStereoConfig(VrDeviceInfo device);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadVrStereoConfig(VrStereoConfig config);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Shader LoadShader([NativeTypeName("const char *")] sbyte* vsFileName, [NativeTypeName("const char *")] sbyte* fsFileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Shader LoadShaderFromMemory([NativeTypeName("const char *")] sbyte* vsCode, [NativeTypeName("const char *")] sbyte* fsCode);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetShaderLocation(Shader shader, [NativeTypeName("const char *")] sbyte* uniformName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetShaderLocationAttrib(Shader shader, [NativeTypeName("const char *")] sbyte* attribName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetShaderValue(Shader shader, int locIndex, [NativeTypeName("const void *")] void* value, int uniformType);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetShaderValueV(Shader shader, int locIndex, [NativeTypeName("const void *")] void* value, int uniformType, int count);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetShaderValueMatrix(Shader shader, int locIndex, [NativeTypeName("Matrix")] Matrix4x4 mat);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetShaderValueTexture(Shader shader, int locIndex, [NativeTypeName("Texture2D")] Texture texture);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadShader(Shader shader);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Ray GetMouseRay(Vector2 mousePosition, [NativeTypeName("Camera")] Camera3D camera);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Matrix")]
        public static extern Matrix4x4 GetCameraMatrix([NativeTypeName("Camera")] Camera3D camera);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Matrix")]
        public static extern Matrix4x4 GetCameraMatrix2D(Camera2D camera);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Vector2 GetWorldToScreen(Vector3 position, [NativeTypeName("Camera")] Camera3D camera);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Vector2 GetScreenToWorld2D(Vector2 position, Camera2D camera);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Vector2 GetWorldToScreenEx(Vector3 position, [NativeTypeName("Camera")] Camera3D camera, int width, int height);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Vector2 GetWorldToScreen2D(Vector2 position, Camera2D camera);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetTargetFPS(int fps);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetFPS();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float GetFrameTime();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double GetTime();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetRandomValue(int min, int max);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetRandomSeed([NativeTypeName("unsigned int")] uint seed);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void TakeScreenshot([NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetConfigFlags([NativeTypeName("unsigned int")] uint flags);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void TraceLog(int logLevel, [NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetTraceLogLevel(int logLevel);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* MemAlloc([NativeTypeName("unsigned int")] uint size);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* MemRealloc(void* ptr, [NativeTypeName("unsigned int")] uint size);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void MemFree(void* ptr);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void OpenURL([NativeTypeName("const char *")] sbyte* url);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetTraceLogCallback([NativeTypeName("TraceLogCallback")] delegate* unmanaged[Cdecl]<int, sbyte*, sbyte*, void> callback);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetLoadFileDataCallback([NativeTypeName("LoadFileDataCallback")] delegate* unmanaged[Cdecl]<sbyte*, uint*, byte*> callback);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetSaveFileDataCallback([NativeTypeName("SaveFileDataCallback")] delegate* unmanaged[Cdecl]<sbyte*, void*, uint, Bool> callback);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetLoadFileTextCallback([NativeTypeName("LoadFileTextCallback")] delegate* unmanaged[Cdecl]<sbyte*, sbyte*> callback);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetSaveFileTextCallback([NativeTypeName("SaveFileTextCallback")] delegate* unmanaged[Cdecl]<sbyte*, sbyte*, Bool> callback);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* LoadFileData([NativeTypeName("const char *")] sbyte* fileName, [NativeTypeName("unsigned int *")] uint* bytesRead);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadFileData([NativeTypeName("unsigned char *")] byte* data);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool SaveFileData([NativeTypeName("const char *")] sbyte* fileName, void* data, [NativeTypeName("unsigned int")] uint bytesToWrite);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool ExportDataAsCode([NativeTypeName("const char *")] sbyte* data, [NativeTypeName("unsigned int")] uint size, [NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* LoadFileText([NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadFileText([NativeTypeName("char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool SaveFileText([NativeTypeName("const char *")] sbyte* fileName, [NativeTypeName("char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool FileExists([NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool DirectoryExists([NativeTypeName("const char *")] sbyte* dirPath);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsFileExtension([NativeTypeName("const char *")] sbyte* fileName, [NativeTypeName("const char *")] sbyte* ext);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetFileLength([NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetFileExtension([NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetFileName([NativeTypeName("const char *")] sbyte* filePath);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetFileNameWithoutExt([NativeTypeName("const char *")] sbyte* filePath);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetDirectoryPath([NativeTypeName("const char *")] sbyte* filePath);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetPrevDirectoryPath([NativeTypeName("const char *")] sbyte* dirPath);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetWorkingDirectory();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetApplicationDirectory();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool ChangeDirectory([NativeTypeName("const char *")] sbyte* dir);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsPathFile([NativeTypeName("const char *")] sbyte* path);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern FilePathList LoadDirectoryFiles([NativeTypeName("const char *")] sbyte* dirPath);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern FilePathList LoadDirectoryFilesEx([NativeTypeName("const char *")] sbyte* basePath, [NativeTypeName("const char *")] sbyte* filter, [MarshalAs(UnmanagedType.U1)] bool scanSubdirs);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadDirectoryFiles(FilePathList files);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsFileDropped();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern FilePathList LoadDroppedFiles();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadDroppedFiles(FilePathList files);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern nint GetFileModTime([NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* CompressData([NativeTypeName("const unsigned char *")] byte* data, int dataSize, int* compDataSize);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* DecompressData([NativeTypeName("const unsigned char *")] byte* compData, int compDataSize, int* dataSize);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* EncodeDataBase64([NativeTypeName("const unsigned char *")] byte* data, int dataSize, int* outputSize);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned char *")]
        public static extern byte* DecodeDataBase64([NativeTypeName("const unsigned char *")] byte* data, int* outputSize);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsKeyPressed(int key);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsKeyDown(int key);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsKeyReleased(int key);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsKeyUp(int key);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetExitKey(int key);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetKeyPressed();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetCharPressed();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsGamepadAvailable(int gamepad);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* GetGamepadName(int gamepad);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsGamepadButtonPressed(int gamepad, int button);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsGamepadButtonDown(int gamepad, int button);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsGamepadButtonReleased(int gamepad, int button);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsGamepadButtonUp(int gamepad, int button);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetGamepadButtonPressed();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetGamepadAxisCount(int gamepad);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float GetGamepadAxisMovement(int gamepad, int axis);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SetGamepadMappings([NativeTypeName("const char *")] sbyte* mappings);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsMouseButtonPressed(int button);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsMouseButtonDown(int button);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsMouseButtonReleased(int button);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsMouseButtonUp(int button);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetMouseX();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetMouseY();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Vector2 GetMousePosition();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Vector2 GetMouseDelta();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetMousePosition(int x, int y);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetMouseOffset(int offsetX, int offsetY);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetMouseScale(float scaleX, float scaleY);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float GetMouseWheelMove();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Vector2 GetMouseWheelMoveV();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetMouseCursor(int cursor);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetTouchX();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetTouchY();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Vector2 GetTouchPosition(int index);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetTouchPointId(int index);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetTouchPointCount();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetGesturesEnabled([NativeTypeName("unsigned int")] uint flags);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsGestureDetected(int gesture);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetGestureDetected();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float GetGestureHoldDuration();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Vector2 GetGestureDragVector();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float GetGestureDragAngle();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Vector2 GetGesturePinchVector();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float GetGesturePinchAngle();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetCameraMode([NativeTypeName("Camera")] Camera3D camera, int mode);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UpdateCamera([NativeTypeName("Camera *")] Camera3D* camera);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetCameraPanControl(int keyPan);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetCameraAltControl(int keyAlt);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetCameraSmoothZoomControl(int keySmoothZoom);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetCameraMoveControls(int keyFront, int keyBack, int keyRight, int keyLeft, int keyUp, int keyDown);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetShapesTexture([NativeTypeName("Texture2D")] Texture texture, Rectangle source);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawPixel(int posX, int posY, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawPixelV(Vector2 position, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawLine(int startPosX, int startPosY, int endPosX, int endPosY, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawLineV(Vector2 startPos, Vector2 endPos, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawLineEx(Vector2 startPos, Vector2 endPos, float thick, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawLineBezier(Vector2 startPos, Vector2 endPos, float thick, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawLineBezierQuad(Vector2 startPos, Vector2 endPos, Vector2 controlPos, float thick, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawLineBezierCubic(Vector2 startPos, Vector2 endPos, Vector2 startControlPos, Vector2 endControlPos, float thick, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawLineStrip(Vector2* points, int pointCount, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawCircle(int centerX, int centerY, float radius, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawCircleSector(Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawCircleSectorLines(Vector2 center, float radius, float startAngle, float endAngle, int segments, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawCircleGradient(int centerX, int centerY, float radius, Color color1, Color color2);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawCircleV(Vector2 center, float radius, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawCircleLines(int centerX, int centerY, float radius, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawEllipse(int centerX, int centerY, float radiusH, float radiusV, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawEllipseLines(int centerX, int centerY, float radiusH, float radiusV, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawRing(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawRingLines(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawRectangle(int posX, int posY, int width, int height, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawRectangleV(Vector2 position, Vector2 size, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawRectangleRec(Rectangle rec, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawRectanglePro(Rectangle rec, Vector2 origin, float rotation, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawRectangleGradientV(int posX, int posY, int width, int height, Color color1, Color color2);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawRectangleGradientH(int posX, int posY, int width, int height, Color color1, Color color2);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawRectangleGradientEx(Rectangle rec, Color col1, Color col2, Color col3, Color col4);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawRectangleLines(int posX, int posY, int width, int height, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawRectangleLinesEx(Rectangle rec, float lineThick, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawRectangleRounded(Rectangle rec, float roundness, int segments, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawRectangleRoundedLines(Rectangle rec, float roundness, int segments, float lineThick, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTriangle(Vector2 v1, Vector2 v2, Vector2 v3, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTriangleLines(Vector2 v1, Vector2 v2, Vector2 v3, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTriangleFan(Vector2* points, int pointCount, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTriangleStrip(Vector2* points, int pointCount, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawPoly(Vector2 center, int sides, float radius, float rotation, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawPolyLines(Vector2 center, int sides, float radius, float rotation, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawPolyLinesEx(Vector2 center, int sides, float radius, float rotation, float lineThick, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool CheckCollisionRecs(Rectangle rec1, Rectangle rec2);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool CheckCollisionCircles(Vector2 center1, float radius1, Vector2 center2, float radius2);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool CheckCollisionCircleRec(Vector2 center, float radius, Rectangle rec);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool CheckCollisionPointRec(Vector2 point, Rectangle rec);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool CheckCollisionPointCircle(Vector2 point, Vector2 center, float radius);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool CheckCollisionPointTriangle(Vector2 point, Vector2 p1, Vector2 p2, Vector2 p3);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool CheckCollisionPointPoly(Vector2 point, Vector2* points, int pointCount);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool CheckCollisionLines(Vector2 startPos1, Vector2 endPos1, Vector2 startPos2, Vector2 endPos2, Vector2* collisionPoint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool CheckCollisionPointLine(Vector2 point, Vector2 p1, Vector2 p2, int threshold);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Rectangle GetCollisionRec(Rectangle rec1, Rectangle rec2);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image LoadImage([NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image LoadImageRaw([NativeTypeName("const char *")] sbyte* fileName, int width, int height, int format, int headerSize);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image LoadImageAnim([NativeTypeName("const char *")] sbyte* fileName, int* frames);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image LoadImageFromMemory([NativeTypeName("const char *")] sbyte* fileType, [NativeTypeName("const unsigned char *")] byte* fileData, int dataSize);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image LoadImageFromTexture([NativeTypeName("Texture2D")] Texture texture);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image LoadImageFromScreen();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadImage(Image image);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool ExportImage(Image image, [NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool ExportImageAsCode(Image image, [NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image GenImageColor(int width, int height, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image GenImageGradientV(int width, int height, Color top, Color bottom);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image GenImageGradientH(int width, int height, Color left, Color right);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image GenImageGradientRadial(int width, int height, float density, Color inner, Color outer);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image GenImageChecked(int width, int height, int checksX, int checksY, Color col1, Color col2);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image GenImageWhiteNoise(int width, int height, float factor);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image GenImagePerlinNoise(int width, int height, int offsetX, int offsetY, float scale);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image GenImageCellular(int width, int height, int tileSize);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image ImageCopy(Image image);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image ImageFromImage(Image image, Rectangle rec);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image ImageText([NativeTypeName("const char *")] sbyte* text, int fontSize, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image ImageTextEx(Font font, [NativeTypeName("const char *")] sbyte* text, float fontSize, float spacing, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageFormat(Image* image, int newFormat);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageToPOT(Image* image, Color fill);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageCrop(Image* image, Rectangle crop);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageAlphaCrop(Image* image, float threshold);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageAlphaClear(Image* image, Color color, float threshold);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageAlphaMask(Image* image, Image alphaMask);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageAlphaPremultiply(Image* image);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageResize(Image* image, int newWidth, int newHeight);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageResizeNN(Image* image, int newWidth, int newHeight);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageResizeCanvas(Image* image, int newWidth, int newHeight, int offsetX, int offsetY, Color fill);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageMipmaps(Image* image);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageDither(Image* image, int rBpp, int gBpp, int bBpp, int aBpp);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageFlipVertical(Image* image);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageFlipHorizontal(Image* image);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageRotateCW(Image* image);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageRotateCCW(Image* image);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageColorTint(Image* image, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageColorInvert(Image* image);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageColorGrayscale(Image* image);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageColorContrast(Image* image, float contrast);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageColorBrightness(Image* image, int brightness);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageColorReplace(Image* image, Color color, Color replace);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Color* LoadImageColors(Image image);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Color* LoadImagePalette(Image image, int maxPaletteSize, int* colorCount);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadImageColors(Color* colors);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadImagePalette(Color* colors);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Rectangle GetImageAlphaBorder(Image image, float threshold);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Color GetImageColor(Image image, int x, int y);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageClearBackground(Image* dst, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageDrawPixel(Image* dst, int posX, int posY, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageDrawPixelV(Image* dst, Vector2 position, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageDrawLine(Image* dst, int startPosX, int startPosY, int endPosX, int endPosY, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageDrawLineV(Image* dst, Vector2 start, Vector2 end, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageDrawCircle(Image* dst, int centerX, int centerY, int radius, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageDrawCircleV(Image* dst, Vector2 center, int radius, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageDrawRectangle(Image* dst, int posX, int posY, int width, int height, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageDrawRectangleV(Image* dst, Vector2 position, Vector2 size, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageDrawRectangleRec(Image* dst, Rectangle rec, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageDrawRectangleLines(Image* dst, Rectangle rec, int thick, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageDraw(Image* dst, Image src, Rectangle srcRec, Rectangle dstRec, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageDrawText(Image* dst, [NativeTypeName("const char *")] sbyte* text, int posX, int posY, int fontSize, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ImageDrawTextEx(Image* dst, Font font, [NativeTypeName("const char *")] sbyte* text, Vector2 position, float fontSize, float spacing, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Texture2D")]
        public static extern Texture LoadTexture([NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Texture2D")]
        public static extern Texture LoadTextureFromImage(Image image);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("TextureCubemap")]
        public static extern Texture LoadTextureCubemap(Image image, int layout);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("RenderTexture2D")]
        public static extern RenderTexture LoadRenderTexture(int width, int height);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadTexture([NativeTypeName("Texture2D")] Texture texture);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadRenderTexture([NativeTypeName("RenderTexture2D")] RenderTexture target);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UpdateTexture([NativeTypeName("Texture2D")] Texture texture, [NativeTypeName("const void *")] void* pixels);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UpdateTextureRec([NativeTypeName("Texture2D")] Texture texture, Rectangle rec, [NativeTypeName("const void *")] void* pixels);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GenTextureMipmaps([NativeTypeName("Texture2D *")] Texture* texture);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetTextureFilter([NativeTypeName("Texture2D")] Texture texture, int filter);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetTextureWrap([NativeTypeName("Texture2D")] Texture texture, int wrap);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTexture([NativeTypeName("Texture2D")] Texture texture, int posX, int posY, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTextureV([NativeTypeName("Texture2D")] Texture texture, Vector2 position, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTextureEx([NativeTypeName("Texture2D")] Texture texture, Vector2 position, float rotation, float scale, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTextureRec([NativeTypeName("Texture2D")] Texture texture, Rectangle source, Vector2 position, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTextureQuad([NativeTypeName("Texture2D")] Texture texture, Vector2 tiling, Vector2 offset, Rectangle quad, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTextureTiled([NativeTypeName("Texture2D")] Texture texture, Rectangle source, Rectangle dest, Vector2 origin, float rotation, float scale, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTexturePro([NativeTypeName("Texture2D")] Texture texture, Rectangle source, Rectangle dest, Vector2 origin, float rotation, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTextureNPatch([NativeTypeName("Texture2D")] Texture texture, NPatchInfo nPatchInfo, Rectangle dest, Vector2 origin, float rotation, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTexturePoly([NativeTypeName("Texture2D")] Texture texture, Vector2 center, Vector2* points, Vector2* texcoords, int pointCount, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Color Fade(Color color, float alpha);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int ColorToInt(Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Vector4 ColorNormalize(Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Color ColorFromNormalized(Vector4 normalized);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Vector3 ColorToHSV(Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Color ColorFromHSV(float hue, float saturation, float value);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Color ColorAlpha(Color color, float alpha);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Color ColorAlphaBlend(Color dst, Color src, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Color GetColor([NativeTypeName("unsigned int")] uint hexValue);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Color GetPixelColor(void* srcPtr, int format);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetPixelColor(void* dstPtr, Color color, int format);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetPixelDataSize(int width, int height, int format);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Font GetFontDefault();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Font LoadFont([NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Font LoadFontEx([NativeTypeName("const char *")] sbyte* fileName, int fontSize, int* fontChars, int glyphCount);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Font LoadFontFromImage(Image image, Color key, int firstChar);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Font LoadFontFromMemory([NativeTypeName("const char *")] sbyte* fileType, [NativeTypeName("const unsigned char *")] byte* fileData, int dataSize, int fontSize, int* fontChars, int glyphCount);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern GlyphInfo* LoadFontData([NativeTypeName("const unsigned char *")] byte* fileData, int dataSize, int fontSize, int* fontChars, int glyphCount, int type);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Image GenImageFontAtlas([NativeTypeName("const GlyphInfo *")] GlyphInfo* chars, Rectangle** recs, int glyphCount, int fontSize, int padding, int packMethod);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadFontData(GlyphInfo* chars, int glyphCount);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadFont(Font font);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool ExportFontAsCode(Font font, [NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawFPS(int posX, int posY);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawText([NativeTypeName("const char *")] sbyte* text, int posX, int posY, int fontSize, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTextEx(Font font, [NativeTypeName("const char *")] sbyte* text, Vector2 position, float fontSize, float spacing, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTextPro(Font font, [NativeTypeName("const char *")] sbyte* text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTextCodepoint(Font font, int codepoint, Vector2 position, float fontSize, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTextCodepoints(Font font, [NativeTypeName("const int *")] int* codepoints, int count, Vector2 position, float fontSize, float spacing, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int MeasureText([NativeTypeName("const char *")] sbyte* text, int fontSize);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Vector2 MeasureTextEx(Font font, [NativeTypeName("const char *")] sbyte* text, float fontSize, float spacing);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetGlyphIndex(Font font, int codepoint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern GlyphInfo GetGlyphInfo(Font font, int codepoint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Rectangle GetGlyphAtlasRec(Font font, int codepoint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int* LoadCodepoints([NativeTypeName("const char *")] sbyte* text, int* count);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadCodepoints(int* codepoints);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetCodepointCount([NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetCodepoint([NativeTypeName("const char *")] sbyte* text, int* bytesProcessed);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* CodepointToUTF8(int codepoint, int* byteSize);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* TextCodepointsToUTF8([NativeTypeName("const int *")] int* codepoints, int length);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int TextCopy([NativeTypeName("char *")] sbyte* dst, [NativeTypeName("const char *")] sbyte* src);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool TextIsEqual([NativeTypeName("const char *")] sbyte* text1, [NativeTypeName("const char *")] sbyte* text2);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint TextLength([NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* TextFormat([NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* TextSubtext([NativeTypeName("const char *")] sbyte* text, int position, int length);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* TextReplace([NativeTypeName("char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* replace, [NativeTypeName("const char *")] sbyte* by);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* TextInsert([NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* insert, int position);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* TextJoin([NativeTypeName("const char **")] sbyte** textList, int count, [NativeTypeName("const char *")] sbyte* delimiter);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char **")]
        public static extern sbyte** TextSplit([NativeTypeName("const char *")] sbyte* text, [NativeTypeName("char")] sbyte delimiter, int* count);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void TextAppend([NativeTypeName("char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* append, int* position);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int TextFindIndex([NativeTypeName("const char *")] sbyte* text, [NativeTypeName("const char *")] sbyte* find);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* TextToUpper([NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* TextToLower([NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* TextToPascal([NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int TextToInteger([NativeTypeName("const char *")] sbyte* text);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawLine3D(Vector3 startPos, Vector3 endPos, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawPoint3D(Vector3 position, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawCircle3D(Vector3 center, float radius, Vector3 rotationAxis, float rotationAngle, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTriangle3D(Vector3 v1, Vector3 v2, Vector3 v3, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawTriangleStrip3D(Vector3* points, int pointCount, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawCube(Vector3 position, float width, float height, float length, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawCubeV(Vector3 position, Vector3 size, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawCubeWires(Vector3 position, float width, float height, float length, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawCubeWiresV(Vector3 position, Vector3 size, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawCubeTexture([NativeTypeName("Texture2D")] Texture texture, Vector3 position, float width, float height, float length, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawCubeTextureRec([NativeTypeName("Texture2D")] Texture texture, Rectangle source, Vector3 position, float width, float height, float length, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawSphere(Vector3 centerPos, float radius, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawSphereEx(Vector3 centerPos, float radius, int rings, int slices, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawSphereWires(Vector3 centerPos, float radius, int rings, int slices, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawCylinder(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawCylinderEx(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawCylinderWires(Vector3 position, float radiusTop, float radiusBottom, float height, int slices, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawCylinderWiresEx(Vector3 startPos, Vector3 endPos, float startRadius, float endRadius, int sides, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawPlane(Vector3 centerPos, Vector2 size, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawRay(Ray ray, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawGrid(int slices, float spacing);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Model LoadModel([NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Model LoadModelFromMesh(Mesh mesh);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadModel(Model model);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadModelKeepMeshes(Model model);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern BoundingBox GetModelBoundingBox(Model model);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawModel(Model model, Vector3 position, float scale, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawModelEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawModelWires(Model model, Vector3 position, float scale, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawModelWiresEx(Model model, Vector3 position, Vector3 rotationAxis, float rotationAngle, Vector3 scale, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawBoundingBox(BoundingBox box, Color color);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawBillboard([NativeTypeName("Camera")] Camera3D camera, [NativeTypeName("Texture2D")] Texture texture, Vector3 position, float size, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawBillboardRec([NativeTypeName("Camera")] Camera3D camera, [NativeTypeName("Texture2D")] Texture texture, Rectangle source, Vector3 position, Vector2 size, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawBillboardPro([NativeTypeName("Camera")] Camera3D camera, [NativeTypeName("Texture2D")] Texture texture, Rectangle source, Vector3 position, Vector3 up, Vector2 size, Vector2 origin, float rotation, Color tint);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UploadMesh(Mesh* mesh, [MarshalAs(UnmanagedType.U1)] bool dynamic);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UpdateMeshBuffer(Mesh mesh, int index, [NativeTypeName("const void *")] void* data, int dataSize, int offset);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadMesh(Mesh mesh);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawMesh(Mesh mesh, Material material, [NativeTypeName("Matrix")] Matrix4x4 transform);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DrawMeshInstanced(Mesh mesh, Material material, [NativeTypeName("const Matrix *")] Matrix4x4* transforms, int instances);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool ExportMesh(Mesh mesh, [NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern BoundingBox GetMeshBoundingBox(Mesh mesh);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void GenMeshTangents(Mesh* mesh);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Mesh GenMeshPoly(int sides, float radius);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Mesh GenMeshPlane(float width, float length, int resX, int resZ);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Mesh GenMeshCube(float width, float height, float length);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Mesh GenMeshSphere(float radius, int rings, int slices);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Mesh GenMeshHemiSphere(float radius, int rings, int slices);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Mesh GenMeshCylinder(float radius, float height, int slices);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Mesh GenMeshCone(float radius, float height, int slices);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Mesh GenMeshTorus(float radius, float size, int radSeg, int sides);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Mesh GenMeshKnot(float radius, float size, int radSeg, int sides);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Mesh GenMeshHeightmap(Image heightmap, Vector3 size);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Mesh GenMeshCubicmap(Image cubicmap, Vector3 cubeSize);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Material* LoadMaterials([NativeTypeName("const char *")] sbyte* fileName, int* materialCount);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Material LoadMaterialDefault();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadMaterial(Material material);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetMaterialTexture(Material* material, int mapType, [NativeTypeName("Texture2D")] Texture texture);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetModelMeshMaterial(Model* model, int meshId, int materialId);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern ModelAnimation* LoadModelAnimations([NativeTypeName("const char *")] sbyte* fileName, [NativeTypeName("unsigned int *")] uint* animCount);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UpdateModelAnimation(Model model, ModelAnimation anim, int frame);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadModelAnimation(ModelAnimation anim);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadModelAnimations(ModelAnimation* animations, [NativeTypeName("unsigned int")] uint count);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsModelAnimationValid(Model model, ModelAnimation anim);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool CheckCollisionSpheres(Vector3 center1, float radius1, Vector3 center2, float radius2);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool CheckCollisionBoxes(BoundingBox box1, BoundingBox box2);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool CheckCollisionBoxSphere(BoundingBox box, Vector3 center, float radius);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern RayCollision GetRayCollisionSphere(Ray ray, Vector3 center, float radius);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern RayCollision GetRayCollisionBox(Ray ray, BoundingBox box);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern RayCollision GetRayCollisionMesh(Ray ray, Mesh mesh, [NativeTypeName("Matrix")] Matrix4x4 transform);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern RayCollision GetRayCollisionTriangle(Ray ray, Vector3 p1, Vector3 p2, Vector3 p3);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern RayCollision GetRayCollisionQuad(Ray ray, Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void InitAudioDevice();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void CloseAudioDevice();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsAudioDeviceReady();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetMasterVolume(float volume);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Wave LoadWave([NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Wave LoadWaveFromMemory([NativeTypeName("const char *")] sbyte* fileType, [NativeTypeName("const unsigned char *")] byte* fileData, int dataSize);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Sound LoadSound([NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Sound LoadSoundFromWave(Wave wave);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UpdateSound(Sound sound, [NativeTypeName("const void *")] void* data, int sampleCount);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadWave(Wave wave);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadSound(Sound sound);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool ExportWave(Wave wave, [NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool ExportWaveAsCode(Wave wave, [NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PlaySound(Sound sound);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void StopSound(Sound sound);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PauseSound(Sound sound);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ResumeSound(Sound sound);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PlaySoundMulti(Sound sound);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void StopSoundMulti();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int GetSoundsPlaying();

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsSoundPlaying(Sound sound);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetSoundVolume(Sound sound, float volume);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetSoundPitch(Sound sound, float pitch);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetSoundPan(Sound sound, float pan);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Wave WaveCopy(Wave wave);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void WaveCrop(Wave* wave, int initSample, int finalSample);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void WaveFormat(Wave* wave, int sampleRate, int sampleSize, int channels);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float* LoadWaveSamples(Wave wave);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadWaveSamples(float* samples);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Music LoadMusicStream([NativeTypeName("const char *")] sbyte* fileName);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Music LoadMusicStreamFromMemory([NativeTypeName("const char *")] sbyte* fileType, [NativeTypeName("const unsigned char *")] byte* data, int dataSize);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadMusicStream(Music music);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PlayMusicStream(Music music);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsMusicStreamPlaying(Music music);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UpdateMusicStream(Music music);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void StopMusicStream(Music music);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PauseMusicStream(Music music);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ResumeMusicStream(Music music);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SeekMusicStream(Music music, float position);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetMusicVolume(Music music, float volume);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetMusicPitch(Music music, float pitch);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetMusicPan(Music music, float pan);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float GetMusicTimeLength(Music music);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float GetMusicTimePlayed(Music music);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AudioStream LoadAudioStream([NativeTypeName("unsigned int")] uint sampleRate, [NativeTypeName("unsigned int")] uint sampleSize, [NativeTypeName("unsigned int")] uint channels);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UnloadAudioStream(AudioStream stream);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void UpdateAudioStream(AudioStream stream, [NativeTypeName("const void *")] void* data, int frameCount);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsAudioStreamProcessed(AudioStream stream);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PlayAudioStream(AudioStream stream);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void PauseAudioStream(AudioStream stream);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void ResumeAudioStream(AudioStream stream);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.U1)] public static extern bool IsAudioStreamPlaying(AudioStream stream);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void StopAudioStream(AudioStream stream);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetAudioStreamVolume(AudioStream stream, float volume);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetAudioStreamPitch(AudioStream stream, float pitch);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetAudioStreamPan(AudioStream stream, float pan);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetAudioStreamBufferSizeDefault(int size);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SetAudioStreamCallback(AudioStream stream, [NativeTypeName("AudioCallback")] delegate* unmanaged[Cdecl]<void*, uint, void> callback);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void AttachAudioStreamProcessor(AudioStream stream, [NativeTypeName("AudioCallback")] delegate* unmanaged[Cdecl]<void*, uint, void> processor);

        [DllImport("raylib", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void DetachAudioStreamProcessor(AudioStream stream, [NativeTypeName("AudioCallback")] delegate* unmanaged[Cdecl]<void*, uint, void> processor);

        [NativeTypeName("#define RAYLIB_VERSION \"4.2\"")]
        public static ReadOnlySpan<byte> RAYLIB_VERSION => new byte[] { 0x34, 0x2E, 0x32, 0x00 };

        [NativeTypeName("#define LIGHTGRAY Color){ 200, 200, 200, 255 }")]
        public static readonly Color LIGHTGRAY = (Color)(new Color
        {
            r = 200,
            g = 200,
            b = 200,
            a = 255,
        });

        [NativeTypeName("#define GRAY Color){ 130, 130, 130, 255 }")]
        public static readonly Color GRAY = (Color)(new Color
        {
            r = 130,
            g = 130,
            b = 130,
            a = 255,
        });

        [NativeTypeName("#define DARKGRAY Color){ 80, 80, 80, 255 }")]
        public static readonly Color DARKGRAY = (Color)(new Color
        {
            r = 80,
            g = 80,
            b = 80,
            a = 255,
        });

        [NativeTypeName("#define YELLOW Color){ 253, 249, 0, 255 }")]
        public static readonly Color YELLOW = (Color)(new Color
        {
            r = 253,
            g = 249,
            b = 0,
            a = 255,
        });

        [NativeTypeName("#define GOLD Color){ 255, 203, 0, 255 }")]
        public static readonly Color GOLD = (Color)(new Color
        {
            r = 255,
            g = 203,
            b = 0,
            a = 255,
        });

        [NativeTypeName("#define ORANGE Color){ 255, 161, 0, 255 }")]
        public static readonly Color ORANGE = (Color)(new Color
        {
            r = 255,
            g = 161,
            b = 0,
            a = 255,
        });

        [NativeTypeName("#define PINK Color){ 255, 109, 194, 255 }")]
        public static readonly Color PINK = (Color)(new Color
        {
            r = 255,
            g = 109,
            b = 194,
            a = 255,
        });

        [NativeTypeName("#define RED Color){ 230, 41, 55, 255 }")]
        public static readonly Color RED = (Color)(new Color
        {
            r = 230,
            g = 41,
            b = 55,
            a = 255,
        });

        [NativeTypeName("#define MAROON Color){ 190, 33, 55, 255 }")]
        public static readonly Color MAROON = (Color)(new Color
        {
            r = 190,
            g = 33,
            b = 55,
            a = 255,
        });

        [NativeTypeName("#define GREEN Color){ 0, 228, 48, 255 }")]
        public static readonly Color GREEN = (Color)(new Color
        {
            r = 0,
            g = 228,
            b = 48,
            a = 255,
        });

        [NativeTypeName("#define LIME Color){ 0, 158, 47, 255 }")]
        public static readonly Color LIME = (Color)(new Color
        {
            r = 0,
            g = 158,
            b = 47,
            a = 255,
        });

        [NativeTypeName("#define DARKGREEN Color){ 0, 117, 44, 255 }")]
        public static readonly Color DARKGREEN = (Color)(new Color
        {
            r = 0,
            g = 117,
            b = 44,
            a = 255,
        });

        [NativeTypeName("#define SKYBLUE Color){ 102, 191, 255, 255 }")]
        public static readonly Color SKYBLUE = (Color)(new Color
        {
            r = 102,
            g = 191,
            b = 255,
            a = 255,
        });

        [NativeTypeName("#define BLUE Color){ 0, 121, 241, 255 }")]
        public static readonly Color BLUE = (Color)(new Color
        {
            r = 0,
            g = 121,
            b = 241,
            a = 255,
        });

        [NativeTypeName("#define DARKBLUE Color){ 0, 82, 172, 255 }")]
        public static readonly Color DARKBLUE = (Color)(new Color
        {
            r = 0,
            g = 82,
            b = 172,
            a = 255,
        });

        [NativeTypeName("#define PURPLE Color){ 200, 122, 255, 255 }")]
        public static readonly Color PURPLE = (Color)(new Color
        {
            r = 200,
            g = 122,
            b = 255,
            a = 255,
        });

        [NativeTypeName("#define VIOLET Color){ 135, 60, 190, 255 }")]
        public static readonly Color VIOLET = (Color)(new Color
        {
            r = 135,
            g = 60,
            b = 190,
            a = 255,
        });

        [NativeTypeName("#define DARKPURPLE Color){ 112, 31, 126, 255 }")]
        public static readonly Color DARKPURPLE = (Color)(new Color
        {
            r = 112,
            g = 31,
            b = 126,
            a = 255,
        });

        [NativeTypeName("#define BEIGE Color){ 211, 176, 131, 255 }")]
        public static readonly Color BEIGE = (Color)(new Color
        {
            r = 211,
            g = 176,
            b = 131,
            a = 255,
        });

        [NativeTypeName("#define BROWN Color){ 127, 106, 79, 255 }")]
        public static readonly Color BROWN = (Color)(new Color
        {
            r = 127,
            g = 106,
            b = 79,
            a = 255,
        });

        [NativeTypeName("#define DARKBROWN Color){ 76, 63, 47, 255 }")]
        public static readonly Color DARKBROWN = (Color)(new Color
        {
            r = 76,
            g = 63,
            b = 47,
            a = 255,
        });

        [NativeTypeName("#define WHITE Color){ 255, 255, 255, 255 }")]
        public static readonly Color WHITE = (Color)(new Color
        {
            r = 255,
            g = 255,
            b = 255,
            a = 255,
        });

        [NativeTypeName("#define BLACK Color){ 0, 0, 0, 255 }")]
        public static readonly Color BLACK = (Color)(new Color
        {
            r = 0,
            g = 0,
            b = 0,
            a = 255,
        });

        [NativeTypeName("#define BLANK Color){ 0, 0, 0, 0 }")]
        public static readonly Color BLANK = (Color)(new Color
        {
            r = 0,
            g = 0,
            b = 0,
            a = 0,
        });

        [NativeTypeName("#define MAGENTA Color){ 255, 0, 255, 255 }")]
        public static readonly Color MAGENTA = (Color)(new Color
        {
            r = 255,
            g = 0,
            b = 255,
            a = 255,
        });

        [NativeTypeName("#define RAYWHITE Color){ 245, 245, 245, 255 }")]
        public static readonly Color RAYWHITE = (Color)(new Color
        {
            r = 245,
            g = 245,
            b = 245,
            a = 255,
        });

        [NativeTypeName("#define MOUSE_LEFT_BUTTON MOUSE_BUTTON_LEFT")]
        public const MouseButton MOUSE_LEFT_BUTTON = MOUSE_BUTTON_LEFT;

        [NativeTypeName("#define MOUSE_RIGHT_BUTTON MOUSE_BUTTON_RIGHT")]
        public const MouseButton MOUSE_RIGHT_BUTTON = MOUSE_BUTTON_RIGHT;

        [NativeTypeName("#define MOUSE_MIDDLE_BUTTON MOUSE_BUTTON_MIDDLE")]
        public const MouseButton MOUSE_MIDDLE_BUTTON = MOUSE_BUTTON_MIDDLE;

        [NativeTypeName("#define MATERIAL_MAP_DIFFUSE MATERIAL_MAP_ALBEDO")]
        public const MaterialMapIndex MATERIAL_MAP_DIFFUSE = MATERIAL_MAP_ALBEDO;

        [NativeTypeName("#define MATERIAL_MAP_SPECULAR MATERIAL_MAP_METALNESS")]
        public const MaterialMapIndex MATERIAL_MAP_SPECULAR = MATERIAL_MAP_METALNESS;

        [NativeTypeName("#define SHADER_LOC_MAP_DIFFUSE SHADER_LOC_MAP_ALBEDO")]
        public const ShaderLocationIndex SHADER_LOC_MAP_DIFFUSE = SHADER_LOC_MAP_ALBEDO;

        [NativeTypeName("#define SHADER_LOC_MAP_SPECULAR SHADER_LOC_MAP_METALNESS")]
        public const ShaderLocationIndex SHADER_LOC_MAP_SPECULAR = SHADER_LOC_MAP_METALNESS;
    }
}
