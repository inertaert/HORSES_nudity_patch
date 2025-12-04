# HORSES Nudity Patch

[![MelonLoader](https://img.shields.io/badge/Mod%20Loader-MelonLoader-green)](https://melonwiki.xyz)

This **MelonLoader** mod removes the pixelation/censorship in the indie-horror game **[HORSES](https://www.gog.com/en/game/horses)**.

---

## **Installation**
### **Requirements**
- A copy of [HORSES](https://www.gog.com/en/game/horses).
- The [MelonLoader](https://melonwiki.xyz/#/) Unity Engine Mod Loader.

### **Steps**
1. **Install MelonLoader**:
   Download and install [MelonLoader](https://melonwiki.xyz/#/README) for HORSES, either by using the MelonLoader installer or zipping the MelonLoader files directly into the game directory.

2. **Download the Mod**:
   - Go to the [Releases](https://github.com/yourusername/yourrepo/releases) tab.
   - Download the latest version of the `nudity_patch.zip` file.

3. **Install the Mod**:
   - Extract the `.zip` file.
   - Copy `nudity_patch.dll` to your `HORSES\Mods\` folder.

4. **Verify Installation**:
   - Launch the game.
   - Alt-tab out and check for the **MelonLoader console window**.
   - Ensure "Nudity Patch" appears in the log as successfully loaded.

---

## **Uninstallation**
1. Delete `nudity_patch.dll` from the `HORSES\Mods\` folder.

2. (Optional:) Uninstall MelonLoader.
---

## **Building from Source**
### **Requirements**
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (or another compatible IDE).
- All game DLLs from `HORSES\Horses_Data\Managed\` and `HORSES\MelonLoader\net35\`.

### **Steps**
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/inertaert/HORSES_nudity_patch.git
   ```

2. **Set Up Dependencies**:
   - Create a `libs` folder in the project root.
   - Copy all `.dll` files from:
     - `HORSES\Horses_Data\Managed\` to `libs\`.
     - `HORSES\MelonLoader\net35\` to `libs\` (do not overwrite existing files).

3. **Open the Project**:
   - Open `nudity_patch.sln` in Visual Studio.

4. **Build the Project**:
   - Press `F6` or go to **Build** > **Build Solution**.
   - The compiled `nudity_patch.dll` will be in:
     ```
     nudity_patch\bin\Debug\netstandard2.1\nudity_patch.dll
     ```

5. **Install the Built Mod**:
   - Copy the built `nudity_patch.dll` to `HORSES\Mods\`.

---

## **License**
This project is open-source and available under the [MIT License](LICENSE).

---
