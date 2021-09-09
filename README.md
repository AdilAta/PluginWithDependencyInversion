# PluginWithDependencyInversion



##Traditional Flow of dependency

![TraditionalDependencyFlow](https://github.com/AdilAta/PluginWithDependencyInversion/blob/main/Images/TraditionalDependencyFlow.drawio.png)


Flow using dependency inversion where business layer has zero dependencies on any other services that it uses.

![PluginWithDependencyInversion](https://github.com/AdilAta/PluginWithDependencyInversion/blob/main/Images/PluginWithDependencyInversion.drawio.png)

This code demonstrates the later flow

Business layer has zero dependencies but its still using other dlls without being dependant on them.

The services are being injected to business layer without business layer knowing them.

Web project, besides being host project, also playing the role of coordinator. Any dependency can be plugged in to the business layer without business layer knowing anything about those packages. This can be done even dynamically


Here is the dependency map generated from Visual Studio Map tool inside Architcture Menu:

![DependencyMapGeneratedFromVisualStudio](https://github.com/AdilAta/PluginWithDependencyInversion/blob/main/Images/MapGeneratedFromVisualStudio.PNG)

