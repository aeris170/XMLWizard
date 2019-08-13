# ResaRf's XML Wizard
 A simple XML Editor in C#. Written using Visual Studio 2017. Windows Forms used for 
 GUI.
 
### Download: [ResaRf's XML Wizard](https://github.com/aeris170/XMLWizard/raw/master/XMLWizard/bin/Release/Wizard.exe)
 
## Features:
  * Lightweight (ONLY 677 KB!)
  * Ability to add child nodes in a structurally manner
  * Ability to add text `(#PCDATA)` to existing nodes
  * Ability to load from *.XML to program
  * Ability to save to *.XML
  * Ability to change the appearance of nodes in application
  
## Controls:
  * Controls are very simple.
  * Double-click node to expand/collapse
  * Press F2 on node to Rename
  * Right click on node to open Context Menu
  * You can do all of these from the `PropertyGrid` control on the right too.
    
## Technical Details:
  * Uses `XmlReader` and `XmlDocument` to read nodes from .XML file as a `NodeTree`
  * Uses `XmlDocument` to save nodes to .XML file as a `NodeTree`
  * Uses a `TreeView` control to browse XML Content
    
## Screenshots:
![wizard_1](https://user-images.githubusercontent.com/25724155/62969537-22910c80-be16-11e9-9816-c16324b0ce61.png)
![wizard_2](https://user-images.githubusercontent.com/25724155/62969582-448a8f00-be16-11e9-9dad-67080c3430fe.png)
![wizard_3](https://user-images.githubusercontent.com/25724155/62969605-5704c880-be16-11e9-83db-71f32016dbfa.png)
![wizard_4](https://user-images.githubusercontent.com/25724155/62969702-83204980-be16-11e9-81ad-ddaf2dca4eb5.png)
![wizard_5](https://user-images.githubusercontent.com/25724155/62969731-929f9280-be16-11e9-8e0a-102aa048f1d4.png)

