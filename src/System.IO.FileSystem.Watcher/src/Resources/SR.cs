// This is auto generated file. Please don’t modify manually.
// The file is generated as part of the build through the ResourceGenerator tool 
// which takes the project resx resource file and generated this source code file.
// By default the tool will use Resources\Strings.resx but projects can customize
// that by overriding the StringResourcesPath property group.
namespace System
{
    internal static partial class SR
    {
#pragma warning disable 0414
        private const string s_resourcesName = "System.IO.FileSystem.Watcher.resources"; // assembly Name + .resources
#pragma warning restore 0414

#if !DEBUGRESOURCES
        internal static string ObjectDisposed_FileClosed {
              get { return SR.GetResourceString("ObjectDisposed_FileClosed", null); }
        }
        internal static string BufferSizeTooLarge {
              get { return SR.GetResourceString("BufferSizeTooLarge", null); }
        }
        internal static string FSW_IOError {
              get { return SR.GetResourceString("FSW_IOError", null); }
        }
        internal static string FSW_BufferOverflow {
              get { return SR.GetResourceString("FSW_BufferOverflow", null); }
        }
        internal static string InvalidDirName {
              get { return SR.GetResourceString("InvalidDirName", null); }
        }
        internal static string InvalidEnumArgument {
              get { return SR.GetResourceString("InvalidEnumArgument", null); }
        }
        internal static string IO_FileExists_Name {
              get { return SR.GetResourceString("IO_FileExists_Name", null); }
        }
        internal static string ArgumentOutOfRange_FileLengthTooBig {
              get { return SR.GetResourceString("ArgumentOutOfRange_FileLengthTooBig", null); }
        }
        internal static string IO_PathTooLong {
              get { return SR.GetResourceString("IO_PathTooLong", null); }
        }
        internal static string IO_PathNotFound_NoPathName {
              get { return SR.GetResourceString("IO_PathNotFound_NoPathName", null); }
        }
        internal static string IO_PathNotFound_Path {
              get { return SR.GetResourceString("IO_PathNotFound_Path", null); }
        }
        internal static string IO_FileNotFound {
              get { return SR.GetResourceString("IO_FileNotFound", null); }
        }
        internal static string IO_FileNotFound_FileName {
              get { return SR.GetResourceString("IO_FileNotFound_FileName", null); }
        }
        internal static string UnauthorizedAccess_IODenied_NoPathName {
              get { return SR.GetResourceString("UnauthorizedAccess_IODenied_NoPathName", null); }
        }
        internal static string UnauthorizedAccess_IODenied_Path {
              get { return SR.GetResourceString("UnauthorizedAccess_IODenied_Path", null); }
        }
        internal static string IO_SharingViolation_File {
              get { return SR.GetResourceString("IO_SharingViolation_File", null); }
        }
        internal static string IO_SharingViolation_NoFileName {
              get { return SR.GetResourceString("IO_SharingViolation_NoFileName", null); }
        }
#else
        internal static string ObjectDisposed_FileClosed {
              get { return SR.GetResourceString("ObjectDisposed_FileClosed", @"Cannot access a closed file."); }
        }
        internal static string BufferSizeTooLarge {
              get { return SR.GetResourceString("BufferSizeTooLarge", @"The specified buffer size is too large. FileSystemWatcher cannot allocate {0} bytes for the internal buffer."); }
        }
        internal static string FSW_IOError {
              get { return SR.GetResourceString("FSW_IOError", @"Error reading the {0} directory."); }
        }
        internal static string FSW_BufferOverflow {
              get { return SR.GetResourceString("FSW_BufferOverflow", @"Too many changes at once in directory:{0}."); }
        }
        internal static string InvalidDirName {
              get { return SR.GetResourceString("InvalidDirName", @"The directory name {0} is invalid."); }
        }
        internal static string InvalidEnumArgument {
              get { return SR.GetResourceString("InvalidEnumArgument", @"The value of argument '{0}' ({1}) is invalid for Enum type '{2}'."); }
        }
        internal static string IO_FileExists_Name {
              get { return SR.GetResourceString("IO_FileExists_Name", @"The file '{0}' already exists."); }
        }
        internal static string ArgumentOutOfRange_FileLengthTooBig {
              get { return SR.GetResourceString("ArgumentOutOfRange_FileLengthTooBig", @"Specified file length was too large for the file system."); }
        }
        internal static string IO_PathTooLong {
              get { return SR.GetResourceString("IO_PathTooLong", @"The specified path, file name, or both are too long. The fully qualified file name must be less than 260 characters, and the directory name must be less than 248 characters."); }
        }
        internal static string IO_PathNotFound_NoPathName {
              get { return SR.GetResourceString("IO_PathNotFound_NoPathName", @"Could not find a part of the path."); }
        }
        internal static string IO_PathNotFound_Path {
              get { return SR.GetResourceString("IO_PathNotFound_Path", @"Could not find a part of the path '{0}'."); }
        }
        internal static string IO_FileNotFound {
              get { return SR.GetResourceString("IO_FileNotFound", @"Unable to find the specified file."); }
        }
        internal static string IO_FileNotFound_FileName {
              get { return SR.GetResourceString("IO_FileNotFound_FileName", @"Could not find file '{0}'."); }
        }
        internal static string UnauthorizedAccess_IODenied_NoPathName {
              get { return SR.GetResourceString("UnauthorizedAccess_IODenied_NoPathName", @"Access to the path is denied."); }
        }
        internal static string UnauthorizedAccess_IODenied_Path {
              get { return SR.GetResourceString("UnauthorizedAccess_IODenied_Path", @"Access to the path '{0}' is denied."); }
        }
        internal static string IO_SharingViolation_File {
              get { return SR.GetResourceString("IO_SharingViolation_File", @"The process cannot access the file '{0}' because it is being used by another process."); }
        }
        internal static string IO_SharingViolation_NoFileName {
              get { return SR.GetResourceString("IO_SharingViolation_NoFileName", @"The process cannot access the file because it is being used by another process."); }
        }

#endif
    }
}
