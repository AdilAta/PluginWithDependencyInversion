# PluginWithDependencyInversion

Traditional Flow of dependency

![TraditionalDependencyFlow](https://github.com/AdilAta/PluginWithDependencyInversion/blob/main/Images/TraditionalDependencyFlow.drawio.png)


Flow using dependency inversion where business layer has zero dependencies on any other services that it uses.

Web project, besides being host project, also playing the role of coordinator. Any dependency can be plugged in to the business layer without business layer knowing anything about those packages. This can be done even dynamically

![PluginWithDependencyInversion](https://github.com/AdilAta/PluginWithDependencyInversion/blob/main/Images/PluginWithDependencyInversion.drawio.png)

Here is the dependency map generated from Visual Studio Map tool inside Architcture Menu:

![DependencyMapGeneratedFromVisualStudio](https://github.com/AdilAta/PluginWithDependencyInversion/blob/main/Images/MapGeneratedFromVisualStudio.PNG)

