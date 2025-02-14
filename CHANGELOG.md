# VRIDE's Channel Log

## V0.32.3 (19/11/2021)
* Reorganized some menu elements
* Now every response goes to VRIDE log

## V0.32.2 (21/10/2021)
* Fixed bad collisions for AFrames.

## V0.32.1 (26/09/2021)
* Fixed class template and method template.

## V0.32.0 (19/07/2021)
* Added new Javascript compiler: IronJS. Available in the File Explorer
* Fixed some bugs.

## V0.31.0 (03/07/2021)
* Added new type of code cube. Now it contains the source code, incomnig classes and outgoing classes.

## V0.30.0 (04/06/2021)
* Introducing CodeCubes, a default visualization for Pharo classes. Classes can be visualized as cubes, which expand to other cubes representing its dependences and variables.
* New WindowCubes: a more compact version of Playground and Browser.
* Added a panel that teaches the controls.
* Some minor bugs fixed.

## V0.29.0 (04/05/2021)
* Added streaming for separate windows (Windows 10 only)
* Added a 2D UI Keyboard, which reacts to the inputs of the physical one connected to the PC
* Added some icons to the main menu
* Now every keyboard must be instantiated from the menu, in favor of a better use of space.
* Fixed some bugs.

## V0.28.0 (26/04/2021)
* Enhanced editors. Text Highlighting has been restored, and line counters have been added.
* Desktop Streaming: Now it is possible to stream a desktop from a PC to VRIDE. 

## V0.27.2 (19/04/2021)
* Fixed intense white on UI highlighting
* Added Python Editor to session and log files

## V0.27.1 (14/04/2021)
* Fixed Python Err Output
* Added line to imported files
* Fixed Virtual Keyboard's Shift key 

## V0.27.0 (11/04/2021)
* VRIDE has now expanded to Python! New File Explorer and Python Editor to create and run Python files.
* Fixed bugs.

## V0.26.0 (31/03/2021)
* Added new keys to Virtual Keyboard
* Virtual Keyboard can now be dragged
* Improved Space Ship

## V0.25.0 (25/03/2021)
* Windows can be dragged forward and backward.
* It is possible to change between VR Hands and Sticks.
* Added delete button for deleting packages, classes and methods.
* Added new tool: Board.
* Fixed bad input handling during drag.

## V0.24.0 (12/03/2021)
* Added new environment: Forest.
* Added XR Hands.
* Fixed some minor bugs.

## V0.23.0 (04/03/2021)
* Changed Vive Input Utility to XR Interaction Toolkit. Now it should work properly on OS X and Linux.
* Improved VRIDE menu. Added new "Settings" section.
* It is possible to disable  the virtual keyboard once a window is opened.

## V0.22.0 (28/01/2021)
* Added button to show/hide the virtual keyboard.
* Added refresh button on Browser. Since loading packages sacrifices performance, it must be pressed if you want to see the packages.
* Now the keys from every virtual keyboard can be used with the pointers.

## V0.21.2 (14/01/2021)
* Fixed bad Pharo code parsing.
* Fixed some Roassal issues.

## V0.21.1 (12/01/2021)
* Added missing keys.

## V0.21.0 (09/01/2021)
* Added more skyboxes. Now it is possible to change the skybox by pressing A.

## V0.20.0 (05/01/2021)
* Improved logging system. Now it tracks each time the user changes position, moves a window to another point, and changes a window's scale and dimensions. Every window is now identified by their ID.
* Minor additions to AFrames.

## V0.19.3 (29/12/2020)
* Fixed bad Aframe parsing.

## V0.19.2 (27/12/2020)
* Fixed some Roassal and Aframe issues.
* Added AFrame Color on hover.

## V0.19.1 (19/12/2020)
* Added missing keys

## V0.19.0 (28/11/2020)
* Using two inputs to receive IP and port.
* Now compatible with Oculus Quest 2

## V0.18.7 (19/11/2020)
* Removed unnecessary objects.

## V0.18.6 (18/11/2020)
* Removed old input module. Using new Input UI System.

## v0.18.5 (13/11/2020)
* Fixed some input issues

## V0.18.4 (12/11/2020)
* Added default icon
* Fixed some bugs

## V0.18.3 (09/11/2020)
* Code refactoring
* Better performance

## V0.18.2 (06/11/2020)
* Updated Unity + XR Plugins

## V0.18.1 (04/11/2020)
* Added window that shows the tasks that will be used during the test.
* Fixed some lightning issues.

## V0.18.0 (29/10/2020)
* Improved Keyboard layout. Now each window will have just one keyboard instead of two. The Do, Print, Inspect, Accept, Copy and Paste buttons are now part of PunchKeyboard as a UI Panel. Tab and Delete buttons where added.
* Fixed minor bugs.

## V0.17.0 (27/10/2020)
* Added buttons for resizing and scaling.
* Added support for Oculus Android.

## V0.16.0 (22/10/2020)
* Upgraded to Unity 2020.1.10f1
* Improved some UI elements.
* Fixed incorrect text parsing on server requests.
* Fixed bad keycode mapping on Punchkeyboard.

## V0.15.0 (15/10/2020)
* Fixed dragging for AFrames and their primitives,
* Reduced size of VIVE colliders.
* Fixed some bugs in the text editors. 

## V0.14.3 (08/10/2020)
* Fixed some playground and browser bugs.
* Fixed many AFrame layout issues.
* Using VIU ViveRig as the main camera.
* Improved some UI elements.
* Add new skyboxes (created by Richard Whitelock)

## V0.14.2 (05/10/2020)
* Fixed AFrame size.
* Reduced capsule collider radius.

## V0.14.1 (02/10/2020)
* AFrame lines working properly.
* Fixed AFrame dragging

## V0.14.0 (01/10/2020)
* Added AFrame exporter for Roassal3 (only primitives and text working by now)
* The execution order for every exporter is as follows: AFrame -> SVG -> PNG
* Using capsule colliders on hand controllers.
* Fixed some keyboard bugs.

## V0.13.2 (28/09/2020)
* Fixed some bugs

## V0.13.1 (22/09/2020)
* Using default ViveColliders

## V0.13.0 (21/09/2020)
* Added PunchKeyboard by Jonathan Ravasz.
* Added an About section.
* User can now change between VRIDE Keyboard or PunchKeyboard.
* Both keyboards have collision detection.

## V0.12.2 (19/09/2020)
* Using Vive Input Utility as the main Camera Rig.

## V0.12.1 (18/09/2020)
* Fixed collisions

## V0.12.0 (18/09/2020)
* Added Roassal 2 and 3 examples. You can see them on the menu.
* Now you can use "Transcript show:" to log into the VRIDE log window
* It is possible to create a Roassal view by just calling the "view" property (Roassal2) or "canvas" property (Roassal3). PNG will be the default format by now.
* Fixed some visual issues.

## V0.11.1 (10/09/2020)
* Fixed Vive Teleporting

## V0.11.0 (08/09/2020)
* Added a virtual keyboard.
* Fixed minor bugs.

## V0.10.2 (04/09/2020)
* Fixed player position.

## V0.10.1 (01/09/2020)
* Added package, class and method filters.

## V0.10.0 (29/08/2020)
* Added VIVE Input Utility plugin.
* VR controls optimized for HTC VIVE.
* Added Roassal3 compatibility (only for PNG images).
* Some code refactoring.

## V0.9.3 (25/08/2020)
* Improved performance while loading packages from the image.

## V0.9.2 (18/08/2020)
* Fixed bug that didn't show new methods with arguments.
* Improved title screen graphics.

## V0.9.1 (17/08/2020)
* Moved sysData to SaveAndLoadModule.cs
* Added vertical window movement.
* Fixed some Playground bugs related to Roassal2.

NOTE: Due to implementantion issues, all local variables must ALWAYS be declared before using them.

## V0.9.0 (13/08/2020)
* Now the User can specify the IP they will connect to.
* Fixed a bug that appeared when the User dragged a window.
* Fixed log file and session file locations.

## V0.8.2 (30/07/2020)
* Changed log.txt location.
* Turned off text highlighting due to malfunctions after recent Unity updates.
* Turned off internal Pharo server due to compatibility issues with other platforms.
* Fixed inspector's text editor bug.
* Made some code improvements.

## V0.8.1 (24/07/2020)
* Fixed package, class and method creation.
* Fixed UI layouts.
* Fixed text editor bugs.
* Fixed Esc button.

## V0.8.0 (07/07/2020)
* Added missing packages from Pharo image.
* Added Class-Side and Instance-Side
* Code refactoring

## V0.7.0 (28/06/2020)
* Pharo Image included.
* Added log file with timestamps
* Added Browser Packages section
* Added cache System.
* Fixed some visual issues
* Improved Mouse and Keyboard controls
* Improved window dragging

## V0.6.2 (01/06/2020)
* Fixed some inspector bugs.

## V0.6.1 (26/05/2020)
* Fixed bug where two or more classes and their methods are shown at the same time

## V0.6.0 (24/05/2020)
* Changed camera behaviour for desktop mode.
* Added window close button.
* Windows can now be dragged left and right.
* Added compatibility with Roassal2's Grapher.
* Now browsers contain the same information (classes and methods)
* Fixed some coding and minor bugs

## V0.5.0 (10/05/2020)
* Added SteamVR controlls.

## V0.4.0 (06/05/2020)
* Added a title screen
* Added support for future VR controls (still in development)
* Fixed some bugs that occur during method definition
* Some prefabs improvements

## V0.3.0 (02/05/2020)
* Now you can invoke as many instances of browsers and playgrounds as you want (see the Controls section in the README file)
* Text Highlighting was improved
* Prefabs now have colored borders

## V0.2.1 (29/04/2020)
* Improved Prefabs

## V0.2.0 (26/04/2020)
* Now the inspector is working.
* Fixed bug where a method's name could have linebreaks and blank spaces, leading to duplicated methods on update.

## V0.1.0 (21/04/2020)
* Added working browser
* Added working text editor
* Includes keyboard controls
