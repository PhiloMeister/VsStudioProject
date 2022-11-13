
//Choices justifications
For this small project we decided to play with the enabling/disabling
of the different components to reduce the amount of code.

The algorithms X and Y are based on the picture with the colorFilter applied 
only instead of using the picture that has been modified with the edge detection
because it was more logical to us.

For the sake of consistency, we have decided to name all graphical elements and related codes 
using the same syntax: 'the type of the element' followed by an 'explicit name'.
For example : 
- labelError for the label displaying a possible error message to the user, 
- btnResetFilters for the button allowing the filters to be reseted and 
btnResetFilters_Click for the method associated with its click.

We also decided to delete either all useless or commented code to keep it clean.


The user is able to :
- choose a picture
- add color filters
	(one or many)
- add edge detection
	(only available after the color filters)
- play with the X and Y algorithms with the threshold
	(2 filters mandatory)
	(only available after the color filters)
	(the algorithms are based on the picture with the colorFilter only)
- See the chart area result of the X and Y algorithms
- Can save the modified image
