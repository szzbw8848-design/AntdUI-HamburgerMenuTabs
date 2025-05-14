namespace AntdUI_HamburgerMenuTabs.Common
{
    internal class Common
    {
        public static long SizeFormat(long size, out string unit)
        {
            long s = 1024;
            if (size >= s && size < s * s)
            {
                unit = "KB";
                return size / s;
            }
            else if (size >= s * s && size < s * s * s)
            {
                unit = "MB";
                return size / s / s;
            }
            else if (size >= s * s * s && size < s * s * s * s)
            {
                unit = "GB";
                return size / s / s / s;
            }
            else if (size >= s * s * s * s)
            {
                unit = "TB";
                return size / s / s / s / s;
            }
            else
            {
                unit = "B";
                return size;
            }
        }
    }
}