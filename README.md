  CATGPT Desktop App (Windows Forms)

CATGPT Desktop App is a C# Windows Forms application that demonstrates a modern desktop UI layout using a parent–child form architecture. The project focuses on clean navigation, modular design, and a scalable structure suitable for building larger desktop applications such as dashboards, chat systems, or admin panels.

  Project Description:-

This project uses a main container form to host multiple child forms inside a panel. Instead of opening multiple windows, the application dynamically loads one form at a time within the main window, providing a smooth and professional user experience.

The application is designed as a layout foundation and is database-ready, with MySQL support included for future expansion.

  Features:-

Multi-form navigation using a single main window

Dynamic loading of child forms inside a panel

Only one active child form at a time

Modular and maintainable form structure

Clean separation of UI and logic

MySQL connector included for database integration

Scalable layout for real-world desktop applications

  Technologies Used:-

C#

.NET Framework 4.8

Windows Forms

MySQL (via MySql.Data)

Visual Studio

  Project Structure:-

Form1.cs – Main container form

HomeForm.cs – Home/Dashboard screen

SignForm.cs – Sign-in / User form

AboutForm.cs – About application screen

Program.cs – Application entry point

App.config – Configuration settings

  How It Works:-

The application starts with the main form. Navigation buttons load different child forms inside a central panel. When a new form is opened, the previously active form is closed automatically, ensuring better memory usage and a cleaner UI.

  Future Enhancements:-

Chatbot or API integration

Role-based navigation

Theme support (Dark/Light mode)

Improved validation and error handling

  Usage:-

Clone the repository

Open the solution in Visual Studio

Restore NuGet packages

Build and run the project

  Purpose:-

This project is intended for learning, practice, and portfolio use. It demonstrates proper Windows Forms navigation and layout design suitable for fresher-level and intermediate .NET developers.
