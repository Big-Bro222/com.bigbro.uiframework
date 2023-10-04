# Read Me
### Description: 
This is a sample project for init a new custom [npm package](https://docs.unity3d.com/Manual/CustomPackages.html#EmbedMe) inside Unity

### Get Started:
- Download from the git repo
- Drag the entire package inside *Packages/URPPackageTemplate* to the package folder of your new project and wait for compiling
- In the package manager, import Download go to the *Samples~* folder

### Work with package:
- First work inside your project to make sure that everything works properly
- Seperate the script for runtime and also make prefabs into the Sample folders
- Upload package folder for either git or scope registory

### Folder Heirarchy
```md
UnityPackageExample/
┣ Assets/
┃ ┣ New Scene.unity
┃ ┣ New Scene.unity.meta
┃ ┣ Samples/...
┃ ┣ ...
┣ Library/...
┣ Logs/...
┣ obj/...
┣ Packages/
┃ ┣ <package-name>/
┃ ┃ ┣ Editor/
┃ ┃ ┃ ┣ <company-name>.<package-name>.Editor.asmdef
┃ ┃ ┃ ┣ <company-name>.<package-name>.Editor.asmdef.meta
┃ ┃ ┃ ┣ HelloWorldEditor.cs
┃ ┃ ┃ ┗ HelloWorldEditor.cs.meta
┃ ┃ ┣ Runtime/
┃ ┃ ┃ ┣ Core/
┃ ┃ ┃ ┃ ┣ <company-name>.<package-name>.Runtime.Core.asmdef
┃ ┃ ┃ ┃ ┣ <company-name>.<package-name>.Runtime.Core.asmdef.meta
┃ ┃ ┃ ┃ ┣ GetUnityVersion.cs
┃ ┃ ┃ ┃ ┗ GetUnityVersion.cs.meta
┃ ┃ ┃ ┗ Core.meta
┃ ┃ ┣ Samples~/
┃ ┃ ┃ ┣ ImageSample/...
┃ ┃ ┃ ┗ SceneSample/...
┃ ┃ ┣ Tests/
┃ ┃ ┃ ┣ Runtime/
┃ ┃ ┃ ┗ Runtime.meta
┃ ┃ ┣ com.<company-name>.asmdef
┃ ┃ ┣ com.<company-name>.asmdef.meta
┃ ┃ ┣ Editor.meta
┃ ┃ ┣ package.json
┃ ┃ ┣ package.json.meta
┃ ┃ ┣ README.md
┃ ┃ ┣ README.md.meta
┃ ┃ ┣ Runtime.meta
┃ ┃ ┗ Tests.meta
┃ ┣ manifest.json
┃ ┗ packages-lock.json
┣ ProjectSettings/...
┣ UserSettings/...
┣ .gitattributes
┣ .gitignore
┣ LICENSE
┣ ...
┣ README.md
┗ URPPackageTemplate.sln
```
