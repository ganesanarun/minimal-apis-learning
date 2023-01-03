class Todo
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool IsComplete { get; set; }

    public string? Secret { get; set; }

    public void Deconstruct(out int id, out string name, out bool isComplete) {
        id = Id;
        name = Name;
        isComplete = IsComplete;
    }
}