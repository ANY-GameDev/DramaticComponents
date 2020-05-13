# Pause Menu

We added pause menu to Bibigun game. Press P or Escape to pause.



We reated panel UI element in canvas object. Then created two buttons as the panel's child objects.  
From hierarchy menu, disabled the pause menu panel. Added [script](/Assets/Script/PauseMenu.cs) to canvas object.  
The script has GameObject variable that connected to the PauseMenu object we created earlier so we can activate or deactivate according to the input, serialized KeyCode so we can easily define the desired key to pause the game and a boolean static variable that says if game is paused.  
In the update loop, there is a check for press on escape key or the key variable we defined earier. if so, the pause function is executed. Pause function changes the current value of the boolean variable, and sets the time scale and pause menu activation accordingly.
When pause menu is activated, there are two buttons. for each button we added an onclick event, both was through the PauseMenu in canvas object (so for the event, the canvas object was connected). Resume will call the Pause function and Main menu will call LoadMenu function. LoadMenu is using the function LoadScene from UnityEngine.SceneManagement.
Finaly, we adden an animation to the pause menu, to make the transition smoother. We changed the animator updating mode to unscaled time so it will not stop when we pause because we set the scaleTime to zero.


We needed to change in existing scripts: in both enemy and laser the formula had used the unscaledDeltaTime. this caused a problem where setting the timescale to zero was not stopping the rotation of the cows and the instantiation of the lasers. So, instead, we used the deltaTime which fixed it.


### Resuming
Resuming can be done by pressing p or escape again or by clicking the Resume button in pause menu.


![](Resume.gif)

### Returning to Main Menu
Returning to main menu by clicking the Resume button in pause menu.


![](Main-Menu.gif)
