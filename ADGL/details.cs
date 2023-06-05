using System;
namespace ADGL;
public static class Details
{
    public static string Version => "1.0.0";
    public static string Snapshot => "000";
    public static string FullVersion => Version + "-" + Snapshot;
    public static string OneDigitVersion => "1";
    public static string CountVersion => "1";
}