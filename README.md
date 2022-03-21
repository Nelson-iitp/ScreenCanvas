# ScreenCanvas

> Turn your desktop into a canvas!

## About

ScreenCanvas is a paint-like program that uses a transparent overlay (the 'canvas') on top working screen. 
This allows the background content to be visible all the time and allows you to write/draw on top of it. 
This 'transparent overlay' can be extended virtually to infinity and can be switched between multiple screens.

![1](mdsrc/1.png)

ScreenCanvas is supported for windows7 and above. Requires .NET framework 4.8 or above.


## Installation

ScreenCanvas is stand-alone, no installation required. You can compile from source code or use pre-compiled binaries available in zip format.

* [Download](https://github.com/Nelson-iitp/ScreenCanvas/raw/main/ScreenCanvas/ScreenCanvas.zip) and Extract zip

* Run `ScreenCanvas.exe` executable - this will show a green icon on the top left corner of working screen

* **Double click** on Icon to toggle canvas
	* green icon means desktop is accessible
	* red icon means ScreenCanvas Overlay is On - desktop not accessible
	* ![2](mdsrc/2.png) 
	
* When the Overlay is on, **right click** anywhere on the overlay(canvas) to see pallete and other options
	* ![4](mdsrc/4.png)

* Right-click on Icon or use system-tray icon for more options
	* ![3](mdsrc/3.png)
___

## Mouse Controls

```
Double-Click Icon	:	Toggle Canvas Overlay
Left-Drag Icon		:	Move Icon
Righ-Click Icon		:	Alt-menu
Middle-Click Icon	:	Clear Canvas

Left-Click Canvas	:	Selected itool or function
Right-Click Canvas	:	Toggle Pallete and itools
Middle-Click Canvas	:	Pan to point (view-port)
Middle-Drag Canvas	:	Pan View
```

## Keyboard Controls


### General Controls

```
Enter		Toggle Canvas mode
Escape		If canvas is ON then switch it OFF, otherwise quit app
F2		Shows recently handled files, `ctrl+C` clear recent list
F5		Refresh Canvas
F1		Toggle notification sounds
Z/Y		Undo/Redo
D		Toggle Browser <-- use for file browsing & bookmarking
```


### Canvas Controls

```
Arrow Keys	pan by screen width or height
 shift +	pan by 100 pixels
 alt +		pan to align the canvas to the edge of the screen
 ctrl +		resize canvas in choosen direction 
 		 - (right,up to increase size in x,y direction)
		 - (left,down to decrease size in x,y direction)
		 

Space		Show Overlay (fits the canvas in view - select view if canvas is very large)
 alt +			Reset Pan
 shift +		Clear Canvas
 ctrl + alt	Reset Canvas size to default (set values on settings page)
 ctrl +		Screenshot primary screen (quick screenshot)
 ctrl + shift +	Screenshot All screens (useful only when multiple display connected)

```

### Region Selection 

```
A		* itool.Selector for selecting rectangular regions on canvas
ctrl + A	* select full canvas
shift + C	* itool.ScreenCopy for copying a rectangular region on screen (screen clip)   

Delete		* Deletes selected region
ctrl + X	* Cuts selected region
ctrl + C	* Copies selected region (only when the _selecting flag is on)          
ctrl + V	* Paste image from clipboard (maintain size, uses one point to paste)
shift + V		* Paste image from clipboard (re-sizeable, uses 2 points to paste)
```


### Import/Export

```
C	Export whatever(image) is on the clipboard  to disk using a save file dialog

V	Import whatever is in the clipboard
	if there are files(images) in the clipboard (copied files) then import them (perform drag-drop)
	if there is an Image in the clipboard, paste it on canvas and resize canvas to image size
```



### Files I/O

To Open files, simply drag-drop

```
ctrl + W	Write changes on any files that were opened (drag-drop)
W			Close Image (set _opened flag to false)
Reset pan		> Alt + W	to reset pan after closing
Clear canvas		> shift + W	to clear canvas after closing

S			Save Canvas - Uses 3 flags
~ Solid Background	> shift + S	to save on solid color - the transparency key itself
~ On Selected Region	> ctrl + S	to save the selection - instead of the whole canvas
~ Manual Save		> Alt + S	to save manually at a selected location

Space
 ctrl +		Screenshot primary screen (quick screenshot)
 ctrl + shift +	Screenshot All screens (useful only when multiple display connected)
```

### Editor Tools

```
P			itools.Pointer
M			itools.Marker
N			itools.Calligraphy
H			itools.Path
E			itools.Eraser	(+shift to toggle eraser trails)
B			itools.Table
I			itools.Ellipse
K			itools.ColorPicker
T			itools.Text 
shift + T		Toggle pasting text from clipboard
ctrl + T	Shows the text-box widget (for entering text)
+/-		Changes the Width of the current itool . Markers, Shape or Eraser
```

### Axis & Grid

```
U			itools.AxisMarker for marking points on Axis & Grid 
ctrl + U	Clear axis points (that were marked)
shift + U		Toggle axis visibility
Alt + U		Toggle perpendicular drop (from marked points)
```

___
