# Everything Service

Compare this with `Directory.GetFiles(@"C:\\", "*. *", new EnumerationOptions() { IgnoreInaccessible = true, RecurseSubdirectories = true });` and the speedup is very significant.

## References

* https://www.voidtools.com/support/everything/sdk/csharp/: Official example
* https://github.com/dipique/everythingio: Self-contained code setup; This template has issue with `IsFolder`, which is fixed in this
* https://github.com/chaojian-zhang/EverythingKMD: Advanced use in host application as example