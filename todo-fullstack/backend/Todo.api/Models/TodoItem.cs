namespace Todo.Api.Models;

public class TodoItem
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public bool Concluida { get; set; }
    
}