# Pause Menu

added pause menu to Bibigun game. Press P or Escape to pause.



Created panel UI element in canvas object. Then created two buttons as the panel's child objects.  
From hierarchy menu, disabled the pause menu panel. Added [script](/Assets/Script/PauseMenu.cs) to canvas object.  
The script has GameObject variable that connected to the pause menu object we created earlier so we can activate or deactivate according to the input, serialized KeyCode so we can easily define the desired key to pause the game and a boolean static variable that says if game is paused.  
In the update loop, there is a check for press on escape key or the key variable we defined earier. if so,  
the pause function is executed. Pause function changes the current value of the boolean variable, and sets the time scale  
and pause menu activation accordingly.


### Resuming
Resuming can be done by pressing p or escape again or by clicking the Resume button in pause menu.


![](Resume.gif)

### Returning to Main Menu
Returning to main menu by clicking the Resume button in pause menu.


![](Main-Menu.gif)
