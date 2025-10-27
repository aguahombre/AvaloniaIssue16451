A ```ServerCompositionSimplePen``` leaks every time the ```Click Me 2 ``` button is pressed.
The ```Click Me``` button will do a full GC Collect if needed to prove the leak.

The leak appears to be the pen used to draw the button border.
