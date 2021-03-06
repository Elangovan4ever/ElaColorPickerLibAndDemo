

Public Interface IDropDownDisplayAdapter

    ' The current color. The ColorPicker doesn't store the color value itself; it uses
    ' this property exposed by the adapter class (2nd task from teh article).
    Property Color() As System.Drawing.Color

    ' The text that the adapter should display. ColorPicker sets the text to the current color
    ' name or to an empty string, if the ColorPicker.TextDisplayed property is set to False.
    ' (3rd task from the article)
    Property Text() As String

    ' This property and event allows the ColorPicker to interrogate and control 
    ' the appearance of the adapter (i.e. dropped-down, or "normal").
    ' (4th task from the article)
    Property HasDropDownAppearance() As Boolean
    Event DropDownAppearanceChanged As EventHandler

    ' This is the actual adapted control. We've deliberately chosen to "unhide" this aspect
    ' of the adapter pattern (that is, the fact that the adaptee itself must be a Control descendant), 
    ' because it simplified the implementation and seemed to be "natural" in this particular context.
    ' (1st task from the article and additional services not mentioned in the article - search
    ' through the code for ".Adaptee" to learn about the various way this property is used).
    ReadOnly Property Adaptee() As Control
End Interface
