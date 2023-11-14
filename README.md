# Fall2020_CSC403_Project

See Wiki for details.

Added Features:

- MainMenu Class:
	From the main menu, users have the ability to start or stop the game and visit the settings page.
	A sound track plays in the background while users are on the main menu.

- Projectile Class
	Each projectile has 5 attributes: speed, damage, positon, collider, and an inFlight state.
	The arrowMove method determine which way the arrow should fly based on the last key the user pressed and updates the position and collider of the arrow.

- Sound Class
	The play method starts the song on a loop.
	The stop method stops the song (this is not a pause) and disposes of the resources that were allocated.
	The SetVolume method is under current production.

- Settings:
  	There is a settings page for the main menu and an in game settings page. The settings page on the main menu is accessed through the "Settings" button. Once on one
   	of the settings pages the user has options: A. Go back to the main menu, B. Go to the controls page to view in game controls, and C. Toggle the music On / Off.
  	Pressing 'P' will bring up the settings page in game. 

- Inventory class:
	Contains a List of strings (itemstorage) which is used to store all items meant to saved for the player to use at a later time.
  	The inventory class keeps track of the current status of the inventory window, whether or not it is shown.
	Pressing the 'i' button opens and closes the inventory window.
	Use the Left (or a) and Right (or d) arrows to select items.

 - Item class:
	Generic class for currently implpemented Health Items and for any future items to be implemented.
 
 - HealthItem:
	Class for Items that heal. Has a set healing value. Contains a collider and initial position to know when the player is collecting the item.
	Contains an use function that overrides the Item use function. Adds health to the player.
