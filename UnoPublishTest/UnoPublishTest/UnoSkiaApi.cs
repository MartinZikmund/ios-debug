using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SkiaSharp;

internal static class UnoSkiaApi
{
    private const string SKIA_Apple = "@rpath/libSkiaSharp.framework/libSkiaSharp";

    [DllImport(SKIA_Apple, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void sk_canvas_draw_text_blob(IntPtr canvas, IntPtr textBlob, float x, float y, IntPtr paint);

    [DllImport(SKIA_Apple, CallingConvention = CallingConvention.Cdecl)]
    internal static extern unsafe void sk_canvas_set_matrix(IntPtr canvas, SKMatrix44* matrix);

    [DllImport(SKIA_Apple, CallingConvention = CallingConvention.Cdecl)]
    internal static extern unsafe void sk_rrect_set_rect_radii(IntPtr rrect, SKRect* rect, SKPoint* radii);

    [DllImport(SKIA_Apple, CallingConvention = CallingConvention.Cdecl)]
    internal static extern IntPtr sk_textblob_builder_make(IntPtr builder);

    [DllImport(SKIA_Apple, CallingConvention = CallingConvention.Cdecl)]
    internal static extern void sk_textblob_unref(IntPtr textBlob);
}
