using Spectre.Console;
using System.Reflection.Metadata;
using TCSA.OOP.LibraryManagementSystem.Models;

namespace TCSA.OOP.LibraryManagementSystem;

internal class Book : LibraryItem
{
    public string Author { get; set; }
    public string Category { get; set; }
    public int Pages { get; set; }

    internal Book(int id, string name, string author, string category, string location, int pages) : base(id, name, location)
    {
        Author = author;
        Category = category;
        Pages = pages;
    }

    public override void DisplayDetails()
    {
        var panel = new Panel(new Markup($"[bold]Book:[/] [cyan]{Name}[/] by [cyan]{Author}[/]") +
                                      $"\n[bold]Pages:[/] {Pages}" +
                                      $"\n[bold]Category:[/] [green]{Category}[/]" +
                                      $"\n[bold]Location:[/] [blue]{Location}[/]")
        {
            Border = BoxBorder.Rounded
        };

        AnsiConsole.Write(panel);
    }

}
