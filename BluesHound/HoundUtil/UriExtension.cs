using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace HoundUtil
{
    internal static class UriExtension
    {
        public static Uri FileUrlFromPath(string path)
        {
            const string prefix = @"\\";
            const string extended = @"\\?\";
            const string extendedUnc = @"\\?\UNC\";
            const string device = @"\\.\";
            const StringComparison comp = StringComparison.Ordinal;

            if (path.StartsWith(extendedUnc, comp))
            {
                path = prefix + path.Substring(extendedUnc.Length);
            }
            else if (path.StartsWith(extended, comp))
            {
                path = prefix + path.Substring(extended.Length);
            }
            else if (path.StartsWith(device, comp))
            {
                path = prefix + path.Substring(device.Length);
            }

            int len = 1;
            var buffer = new StringBuilder(len);
            int result = UrlCreateFromPath(path, buffer, ref len, 0);
            if (len == 1) Marshal.ThrowExceptionForHR(result);

            buffer.EnsureCapacity(len);
            result = UrlCreateFromPath(path, buffer, ref len, 0);
            if (result == 1) throw new ArgumentException("Argument is not a valid path.", "path");
            Marshal.ThrowExceptionForHR(result);
            return new Uri(buffer.ToString());
        }
        [DllImport("shlwapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int UrlCreateFromPath(string path, StringBuilder url, ref int urlLength, int reserved);
    }

    
}
