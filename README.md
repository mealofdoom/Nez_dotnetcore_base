# Nez_dotnetcore_base

  This is a "solution" template for the Nez framework targetting dotnet core and using FNA.

  There are two sample projects in here, NezBasicWindow, which simply opens a window, and Nez-Samples, which is a fork
of the official Nez-Samples repository @ https://github.com/prime31/Nez-Samples. The latter has been modified both to target
the platforms of this solution, but also to fix some build errors that were caused by conflicting project references.

  In order to compile the projects just run:

`
dotnet build
`

`
dotnet run
`

The Nez-Samples project requires the FNA libs, which you can find in the following link:

https://github.com/FNA-XNA/FNA/wiki/1:-Download-and-Update-FNA#2-download-native-libraries


If any issues arise when building/compiling please create an issue. With that said I cannot offer support to either FNA or Nez
and issues with said libraries should be forwarded to their respective repos:

Nez: https://github.com/prime31/Nez

FNA: https://github.com/FNA-XNA/FNA

