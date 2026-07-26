using System;

namespace Data.Enum;

public static class FFI {
    public static string FromCharCode(long c) => ((char)c).ToString();
    public static long ToCharCode(string c) => c.Length > 0 ? (long)c[0] : 0;
}
