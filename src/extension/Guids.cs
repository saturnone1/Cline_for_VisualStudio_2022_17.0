using System;

namespace VsClineAgent
{
    internal static class PackageGuids
    {
        public const string PackageGuidString = "ADCC53D2-7B09-4F8D-8534-1FF693AED219";
        public static readonly Guid PackageGuid = new Guid(PackageGuidString);

        public const string CommandSetGuidString = "AB1DE66B-E5D1-45D4-839F-ABCE67585458";
        public static readonly Guid CommandSetGuid = new Guid(CommandSetGuidString);

        public const string ChatToolWindowGuidString = "AF8E74F0-397B-4CFA-A5DE-37307946FF4E";
        public static readonly Guid ChatToolWindowGuid = new Guid(ChatToolWindowGuidString);
    }

    internal static class PackageCommandIds
    {
        public const int OpenChatWindow = 0x0100;
        public const int ClearChatHistory = 0x0101;
    }
}
