![License](https://img.shields.io/badge/License-CC%20BY--NC--SA%204.0-green)
![KSP Version](https://img.shields.io/badge/KSP-1.12.x-blue.svg)
![Latest Commit](https://img.shields.io/github/last-commit/TheFiveEchoes/TheFiveEchoes/main.svg)

[![Discord](https://github.com/TheFiveEchoes/TheFiveEchoes/blob/main/ImageAssets/Discord.png?raw=true)](https://discord.gg/57w8HjEQyp)

# The Five Echoes

**_The Five Echoes_ is a planet pack for Kerbal Space Program that aims at providing a vast amount of different celestial objects to explore. With a system replacer and multiple interstellar systems in planning, plus an integrated story mode, there will certainly be a lot to discover.**

## Contents
 - [**Installation**](https://github.com/TheFiveEchoes/TheFiveEchoes#installation)
 - [**Compatibility**](https://github.com/TheFiveEchoes/TheFiveEchoes#compatibility)
 - [**Mod Settings**](https://github.com/TheFiveEchoes/TheFiveEchoes#mod-settings)
 - [**Credits & License**](https://github.com/TheFiveEchoes/TheFiveEchoes#credits-and-license)

# Installation

**Note:** _The Five Echoes_ will be added to CKAN once Version 1.0 releases. Until then the mod will have to be installed manually.

1. Install the following dependencies:
    - [**Kopernicus**](https://github.com/Kopernicus/Kopernicus) **and its dependencies**: Used to make custom celestial objects possible.
    - [**AdvancedPQSTools**](https://github.com/CharonSSS/AdvancedPQSTools) **and its dependencies**: Includes PQSMods and shaders used by TFE's celestial objects.
    - [**BurstPQS**](https://github.com/Phantomical/BurstPQS) **and its dependencies**: Required by AdvancedPQSTools.
    - [**VertexHeightOblateAdvanced**](https://github.com/jamespglaze/VertexHeightOblateAdvanced) **and its dependencies**: Used by some of TFE's celestial objects.
2. Install _The Five Echoes_
    - Before updating to a newer version make sure to first uninstall any previous version of _The Five Echoes_ to avoid possible errors.
    - Download the following:
        - **TheFiveEchoes-Core.zip**: Includes core configs, plugins, textures and other assets used throughout _The Five Echoes_.
        - **TheFiveEchoes-Rhakuutra.zip**: This is the system replacer and is **required** for the mod to work.
        - **Other star systems of your choice**: Those will be provided once they are ready for release.
        - Download the following depending on which scale you want to play _The Five Echoes_ in:
            - **TheFiveEchoes-RealScaleAddons.zip**: For playing in real scale, this includes configs that allow for playing in real scale with stock and most modded parts.
            - Addons for quarter and stock scale will be provided once rescale becomes implemented.
    - Copy the contents inside the GameData folder provided in each .zip into your KSP install's GameData folder.

>[!IMPORTANT]
> Do NOT directly copy the GameData folder in the .zip files into your KSP install's GameData folder as that will break stuff!
> Only copy the folders INSIDE of the GameData folder in the .zip files into your KSP install's GameData folder
> It is also highly recommended to install all dependencies via CKAN as this will also automatically download any dependency's dependencies

# Compatibility

**_The Five Echoes_ is compatible with**:
- [**Parallax Continued**](https://github.com/Gameslinx/Parallax-Continued): _The Five Echoes_ provides its own Parallax Continued textures. Currently terrain & scaled textures are supported, with implementation of custom scatters planned for future updates.
- [**Scatterer**](https://github.com/LGhassen/Scatterer): StockScattererConfigs is required for the caustics texture, all other configs and textures are provided by _The Five Echoes_.
- [**TiltEm Continued**](https://github.com/ballisticfox/TiltEm-Continued): Via settings allows for the enabling/disabling of axial tilt and system planes.

**These mods are planned to have compatibilty with _The Five Echoes_ in the future**:
- [**Singularity**](https://github.com/LGhassen/Singularity): For providing gravitational lensing effects for wormholes and other certain objects.
- [**EVE Volumetrics V5**](https://www.patreon.com/blackrack/posts/true-volumetric-139879553): For volumetric clouds and other effects like shooting stars.
- [**EVE Redux**](https://github.com/LGhassen/EnvironmentalVisualEnhancements): For non-volumetric clouds.

# Mod Settings

**In order to access and modify the mod's settings, go into the GameData folder of the KSP install you installed _The Five Echoes_ on and open `TheFiveEchoes/TheFiveEchoesSettings.cfg` in a text editor of your choice

The following settings can be modified:
- `SystemScale`: Currently not yet implemented, this will allow for rescaling the system. `3` is for Real Scale (default), `2` is for Quarter Scale & `1` is for Stock Scale.
- `UseWormholes`: Currently not yet implemented. `True` is the default and will enable the wormhole system once interstellar systems are added. `False` disables the wormhole system.
- `EnableAxialTilt`: For enabling/diabling the Axial Tilt via TiltEm Continued. `False` is the default and disables Axial Tilt. `True` enables the Axial Tilt.
- `EnableSystemPlanes`: Currently not yet implemented. For enabling/disabling System Planes (the orbital inclination reference plane of a star) via TiltEm Continued. `True` is the default and enables System Planes. `False` disables System Planes.
- `WhiteStarLight`: For enabling/disabling white starlight for all stars. `False` is the default and makes stars emit light roughly in the color they would emit in real life. `True` makes all stars emit white light (hex code #FFFFFF).
- `AutoDeleteCache`: For enabling/disabling automatic cache file deletion. `False` is the default and keeps all cache files after generation. `True` makes it so that all cache files under `TheFiveEchoes/Cache` are deleted at the SpaceCenter scene.
- `TimeOffset`: For offsetting the start time at a new save. `True` is the default and offsets the time to noon at Reatir-50 when creating a new save, which is the date equivalent to the March Equinox here on Earth. `False` will make it so there is no time offset at the start of a new save.

# Credits and License

## The Five Echoes
Developed by Space Fox Oprissmian
Licensed under the [CC-BY-NC-SA 4.0](https://creativecommons.org/licenses/by-nc-sa/4.0/deed.en) license
### The following plugins and their source code are licensed via the [MIT License](https://opensource.org/license/mit):
- TheFiveEchoes/_Core/Plugins/TheFiveEchoes.dll

## The following content has been directly included from other mods under permission from the mod's license and/or the mod author(s) themselves:

TheFiveEchoes/_Core/Plugins/OrbitPlotter.dll (from RSS-Origin-2):
- Licensed under the [CC-BY-NC-SA 4.0](https://creativecommons.org/licenses/by-nc-sa/4.0/deed.en) license
- Credit goes to [Charon_S](https://github.com/CharonSSS) and [Aebestach](https://github.com/Aebestach)

TheFiveEchoes-RealScaleAddons/PhysicsModifications.cfg (from Realism Overhaul)
- Licensed under the [CC-BY-SA](https://creativecommons.org/licenses/by-sa/4.0/deed.en) license

TheFiveEchoes-RealScaleAddons/EngineReconfig.cfg
- Credit goes to [gabo](https://github.com/gabo463)

## Special thanks go to the co-developer(s) & contributors:

- Chitak for working on Khemistry compatiblity
- sdschildberg for the general idea/layout of the Tengris gas/ice giant system in Proximarus
- Evelyn (aka. Acidic Pancakes) for helping out with science defs, easter egg ideas & celestial object ideas/layouts/refinements
