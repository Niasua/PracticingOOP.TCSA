using Spectre.Console;

var menuChoices = new string[3] { "View Books", "Add Book", "Delete Book" };

var choice = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
    .Title("What do you want to do next?")
    .AddChoices(menuChoices));