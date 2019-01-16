# NB Web Explorer
A NB web browser ;-)

<p align="center">
  <img src="https://github.com/xlfdll/xlfdll.github.io/raw/master/images/projects/NBWebExplorer.png"
       alt="NB Web Explorer">
</p>

Based on Internet Explorer's Trident engine. Designed for Windows versions that have only Internet Explorer (Windows 2000, XP, Vista, 7, or 8.x).

## System Requirements
* .NET Framework 2.0

[Runtime configuration](https://docs.microsoft.com/en-us/dotnet/framework/migration-guide/how-to-configure-an-app-to-support-net-framework-4-or-4-5) is needed for running in .NET Framework 4.0+.

To get maximum performance and standard compliance, upgrade Internet Explorer to the latest version.

## Usage
Just choose a build (x86, x64, or AnyCPU) and run.

Some features are supported only in certain architecture build. For example, 32-bit ActiveX controls can only work in x86 build.

## Development Prerequisites
* Visual Studio 2013+

Before the build, generate-build-number.sh needs to be executed in a Git / Bash shell to generate build information code file (BuildInfo.cs).
