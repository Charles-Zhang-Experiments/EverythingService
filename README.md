# Everything Service

Compare this with `Directory.GetFiles(@"C:\\", "*. *", new EnumerationOptions() { IgnoreInaccessible = true, RecurseSubdirectories = true });` and the speedup is very significant.

Notice Everything64.dll provides IPC to Everything service - the Everything.exe file is likely just a Forms application that calls this dll, because the DLL's interface is almost identical to the GUI interface (i.e. operational, rather providing a more lower-level API). This can be confirmed by the fact that Everything is installed as a Windows service. On the other hand, per [customization](https://www.voidtools.com/support/everything/customizing/) documentation, notice "Everything can be customized through the Everything.ini, registry and Everything options." This provides uncertainty to programs that rely on specific behavior of searching configurations - notably, things like `exclude_hidden_files_and_folders` and `index_folder_size`, and paths exclusions, all of which are NOT configurable through SDK. In that sense, it's not much different from using [CSV exports](https://www.voidtools.com/support/everything/file_lists/) - however it's curious when using CLI options to `Everything.exe` how does it handle file/folder exclusions, because if `Everything.exe` depends on `EverythingXX.dll`, then it should also be restricted by user configurations?

## References

* https://www.voidtools.com/support/everything/sdk/csharp/: Official example
* https://github.com/dipique/everythingio: Self-contained code setup; This template has issue with `IsFolder`, which is fixed in this
* https://github.com/chaojian-zhang/EverythingKMD: Advanced use in host application as example