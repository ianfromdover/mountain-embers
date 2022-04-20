# Mountain Embers
CS4240 Interaction Design for AR and VR Assignment 1  
Collect small embers to light your campfire among cold, dark mountains.  
First ever environment design project in Unity 3D.

## Unity Version

- 2020.2.1f1
- Recommended: Nvidia RTX 2060

## Packages Required
- Cinemachine 2.6.11
- Terrain Tools 3.0.2-preview.3 (Preview Package, installation instructions below)
- **Test Framework `1.1.19` (This version should come with Unity 2020.2.1f1. The newer version has errors that I don't know how to fix)**
- TextMeshPro 3.0.6
- Timeline 1.4.8
- Unity Collaborate 1.3.9
- Unity UI 1.0.0
- Visual Studio Code Editor 1.2.4

## Install the Terrain Tools Package
1. Open an empty project.
2. Open the Package Manager panel.
3. Click on the settings icon(gear) at the top right corner near the window's searchbar.  
4. Select `Advanced Project Settings`, which opens a new window
![Package Manager](./pictures/1.png)
5. Tick the checkbox under `Package Manager section > Advanced Settings box > Enable Preview Packages`.  
![Package Manager](./pictures/2.png)
7. Go back to the Package Manager panel, and in the top left, change the drop-down menu to `Packages: Unity Registry`. 
8. Scroll down to find `Terrain Tools` and install, along with the other packages listed above.  
![Package Manager](./pictures/3.png)
10. You can now open the assignment project by double clicking its scene.
11. If there is a GUI problem, create a new project in unity and open it before opening this project.


## If avatar is pink or invisible on import
![Pink Avatar](./pictures/4.png)  
1. In the Hierarchy, expand the `Player Model`
![Source](./pictures/5.png)  
2. For the Body and Face objects, the `Skinned Mesh Renderer > Mesh` and `Material`s are missing. Drag them from the Project files into their slots. Searching for them is easier than navigating to them.
![Files in structure](./pictures/6.png)  
3. These are the corresponding folders. After applying the mesh and material, the problem is fixed. If you meet anymore problems, do not hesitate to contact Ian at ianhong@u.nus.edu

## Playing Instructions
1. Use `WASD` to move the character, and control the camera with the mouse. Press `Shift` to move faster. You start at the center of the map, at the campfire.
2. The character does not align with the camera angle but the controls are. Forward means forward from the camera, not global forward.
3. There are `6` fires placed around the map. Bring them to your campfire to make it grow bigger. You can only hold one at a time.
4. Each fire is visible from the location of each other fire. Just follow the paths on the ground to get to them.
5. Once you have finished, an achievement will be displayed.

## Assets Used
- Bridge and planks from [Shed, Tools, Bridge and Fences][1] by Quite Vibrant
- Skybox from [Stellar Sky][2] by Satsuru
- Terrain Brushes from [Terrain Sample Asset Pack][3] by Unity Technologies
- Grass, Trees and Ground Textures from [Standard Assets (for Unity 2018.4)][4] by Unity Technologies
- More Ground Textures from [Outdoor Ground Textures][5] by A dog's life software
- Flowers from [Grass and Flowers Pack 1][6] by Vladislav Pochezhertsev

## Original Assets
- Avatar was designed in [VRoid Studio][7]
- Fire was original, learnt from [CGHOW][8] and [Sirhaian'Arts][9] on Youtube

[1]: https://assetstore.unity.com/packages/3d/props/shed-tools-bridge-and-fences-104216
[2]: https://assetstore.unity.com/packages/2d/textures-materials/sky/stellar-sky-99558
[3]: https://assetstore.unity.com/packages/3d/environments/landscapes/terrain-sample-asset-pack-145808
[4]: https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-for-unity-2018-4-32351
[5]: https://assetstore.unity.com/packages/2d/textures-materials/floors/outdoor-ground-textures-12555
[6]: https://assetstore.unity.com/packages/2d/textures-materials/nature/grass-and-flowers-pack-1-17100
[7]: https://vroid.com/en/studio
[8]: https://www.youtube.com/watch?v=AoYCliRCQhs
[9]: https://www.youtube.com/watch?v=5Mw6NpSEb2o
