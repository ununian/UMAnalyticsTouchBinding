using System;
using ObjCRuntime;

[assembly: LinkWith("libMobClickLibrary.a",
    LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator64 | LinkTarget.Arm64, 
    SmartLink = true,
    ForceLoad = true,
    LinkerFlags = "-lz")]
