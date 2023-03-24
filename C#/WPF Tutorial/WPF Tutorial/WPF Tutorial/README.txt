this tutorial follows the C# WPF Tutorial series from Kampa Plays on youtube
Describes the basic wpf user interface and specific topics like data binding etc....
https://www.youtube.com/playlist?list=PLih2KERbY1HHOOJ2C6FOrVXIwg4AZ-hk1


tutorial 3 - Hello world tutorial
	- introduced to wpf creator UI and VS wpf layout.
xaml file serves as the user interface (UI) for the applciation
	describes the UI layout 
	similar to HTML, it is a markup language (XAML) X Application Markup Language
code behind or the .cs file serves as the business logic for the UI
	describes the logic behind user interface ie event handlers and other stuff

Tutorial 4 - code behind tutorial
	- manipulating UI elements from code behind
	- ways to do this: 
		1. Data Binding
		2. Control access via name 

Tutorial 5 - Basics of Grid Layouts
	- focusing on ui layouts and grid control
	- grid is the default control added to the window.
	- window can only have one thing set as the main content
		-> this means that everything has to go into one main item
		-> there is normally one overall grid, and everything goes inside of it.
		-> EG can't have zero grids and multiple textboxes, but can have one grid 
		   with 100 textboxes inside of it.
	- most formatting would be done in an external file to make styling modular (similar to a css file)

Tutorial 6 - Basics of user controls
	- more complex grid structure. 
	- utilizing views and usercontrols for the views.
	- exporting the complex structure to a user control
	- importing the user control into the main window using the namespace

Tutorial 7 Custom Textbox Control
	- create a user control for custom textboxes that have:
		1. placeholder textblocks
		2. user input textboxes
		3. clear buttons
	- user control created in the view>usercontrol DIR
		- linked via importing the namespace
	- placeholder textbox.text is binded to a property "PlaceHolder" in the 
	  custom textbox user control class.
	- each individual textbox in the main window sets the unique placeholder
	  using the PlaceHolder property (accessible because the textbox is of custom
	  class UserControls:ClearableTextBox)

Tutorial 8 Data Bindings