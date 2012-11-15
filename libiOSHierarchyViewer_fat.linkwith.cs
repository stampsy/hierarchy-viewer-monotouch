using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libiOSHierarchyViewer_fat.a", LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true, LinkerFlags = "-ObjC -all_load", Frameworks = "CoreData")]
