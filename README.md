Summary of Chapter 1: Introduction to Visual C#

This chapter introduces the fundamentals of Visual C# programming using Visual Studio, focusing on object-oriented concepts, the IDE environment, and building a first Windows Forms application.

1. Objects and Controls

· An object is a program component containing data (properties) and operations (methods).
· Controls are visible GUI objects (Labels, Buttons, TextBoxes) that enhance program functionality.
· A class is code describing a type of object.
· .NET Framework is a collection of classes used to build Windows programs; C# is a language supported by .NET.

2. The Visual Studio IDE

Key windows include:

· Designer Window – where you visually build the form.
· Solution Explorer – shows project files (e.g., Form1.cs, Program.cs).
· Properties Window – lists and edits object properties.
· Toolbox – contains controls to drag onto the form.

Features covered: Auto Hide (pushpin icon), docked vs. floating windows, menu bar, standard toolbar, and tooltips.

3. Projects and Solutions

· A project contains several files (Form1.cs, Program.cs).
· A solution is a container holding one or more projects.

4. Forms and Properties

· A Form is the window of the application. It has a bounding box and sizing handles for resizing.
· The Properties Window has two columns: property name and value. The Text property changes the title bar text.

5. Adding Controls

· Add from Toolbox by double-clicking or dragging.
· Move, resize, or delete controls (select and press Delete).
· Naming rules: first character must be a letter or underscore; no spaces; only alphanumeric characters and underscores.

6. Introduction to C# Code

Code is organized into:

· Namespaces – containers for classes.
· Classes – containers for methods.
· Methods – groups of statements performing operations.

Two auto-generated source files:

· Program.cs – startup code.
· Form1.cs – code associated with the form.

7. Event-Driven Programming

· Applications respond to events (clicks, key presses).
· Double-clicking a control creates a default event handler (e.g., myButton_Click).
· MessageBox.Show() displays a dialog box.

8. Label and PictureBox Controls

· Label: displays text; properties include Text, Name, Font, BorderStyle, AutoSize, TextAlign.
· PictureBox: displays images; properties include Image, SizeMode, Visible.
· Code can change properties at runtime (e.g., answerLabel.Text = "Hello").

9. IntelliSense

Automatic code completion that suggests keywords, variables, methods, classes, and properties as you type.

10. Comments, Blank Lines, and Indentation

· Line comments: // comment
· Block comments: /* comment */
· Blank lines and indentation improve readability.

11. Closing a Form

· Use this.Close(); to close the form.
· Common practice: add an Exit button with this code.

12. Syntax Errors

· The code editor underlines errors with a jagged line.
· Attempting to run with errors shows a build error dialog.


Main Window
The large white/gray area is your Windows Form.
The title is “My First Program”.
Two Buttons
There are two buttons on the form.
Both currently have the default text button1.
You can change their text using the Text property in the Properties window.

Message Box

When a button is clicked, a message box appears saying:
“Welcome to C#”
This is probably created using:
