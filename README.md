# ConsoleGUI

## Current project overview
The naming of projects show their _most essential_ chain of dependencies, e.g. _GUI.Console.Windows_ depends on _GUI.Console_ (which in turn depends on _GUI_). This is done to retain my sanity.

### GUI (core)
This project is really just UI, there's no graphical component yet. It contains all the abstract types related to implementing UI capabilities like event handling.

### GUI.Console (Rendering platform)
This project is an example implementation of a platform to render to. It implements various interfaces related to providing UI in a console context.

## Levels of abstraction

The project is organized in several layers of abstraction, to keep it as extensible as possible.

1. UI Core - Layer (_GUI_)

The core contains strictly UI, no-GUI. It also contains a means of forwarding input, and contains the main update loop,
which notifies the rendering engine to update the screen, and input handlers to poll input.

2. Rendering platform - Layer (_GUI.Console_ and _GUI.Console.Controls_)

This layer is a unique layer to this project, and is the main focus of it. It abstracts the display of controls to not just being limited to pixels.
This layer includes a project which implements a text-based UI, and concrete controls which utilize the console window.

An idea for the future, might be to also make a pixel-based (or maybe vector-based) rendering platform.

3. OS API - Layer (_GUI.Console.Windows_)

This layer implements specific OS capabilities, that are dependent on OS API calls, like input and rendering. It is built on top of a rendering platform.

## Notes for myself
These are things to keep in mind when developing
 - Internationalization

Including internationalization would be awesome. But I'm not sure how I can do it properly with the current levels of abstraction.
The issue is that the UI library isn't (for now) intended to include strings in Controls, with the immediate next level of abstraction being _Rendering platform_,
i18n would become platform dependent.

 - Layout controls

Some basic layout controls are a must, otherwise it's barely a UI library. I will have to find the right place to include them. I'm still hoping I can do it in a platform-agnostic way, by not including them in _Rendering platform_.

 - Databinding(?)

Proably an advanced feature, but would be awesome to have. Always wanted to dive into reactive programming.

### Out-of-scope
These are things I've deemed out-of-scope for this project.

 - Accessibility

Providing deliberate support for screen reader and similar would depend heavily on the Rendering platform layer, and would be difficult to abstract properly. Furthermore, this project is mostly for fun, and I don't know anyone using a screen reader or similar.
