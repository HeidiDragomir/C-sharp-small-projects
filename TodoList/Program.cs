Console.WriteLine("Hello!");

var todos = new List<string>();

bool shallExit = false;


while (!shallExit)
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "S":
        case "s":

            SeeAllTodos();

            break;

        case "A":
        case "a":

            AddTodo();

            break;

        case "R":
        case "r":

            RemoveTodo();

            break;
        case "E":
        case "e":

            shallExit = true;
            break;
        default:

            Console.WriteLine("Invalid choice.");
            break;
    }
}

Console.ReadKey();


void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        ShowNoTodosMessages();
        return;
    }

    //foreach (string todo in todos)
    //{
    //    Console.WriteLine((todos.IndexOf(todo) + 1) + ". " + todo + ";");
    //}

    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }


}


void AddTodo()
{
    string description;

    do
    {
        Console.WriteLine("Enter the TODO description:");

        description = Console.ReadLine();

    }
    while (!IsDescriptionValid(description));

    todos.Add(description);
    Console.WriteLine("TODO successfully added: " + description);

}

bool IsDescriptionValid(string description)
{
    if (description == "")
    {
        Console.WriteLine("The description cannot be empty.");
        return false;
    }
    if (todos.Contains(description))
    {
        Console.WriteLine("The description must be unique.");
        return false;
    }

    return true;

}

void RemoveTodo()
{

    if (todos.Count == 0)
    {
        ShowNoTodosMessages();
        return;
    }

    int index;

    do
    {
        Console.WriteLine("Select the index of the TODO you want to remove:");

        SeeAllTodos();
    }
    while (!TryReadIndex(out index));


    RemoveTodoAtIndex(index - 1);

}


bool TryReadIndex(out int index)
{
    var userInput = Console.ReadLine();

    if (userInput == "")
    {
        index = 0;

        Console.WriteLine("Selected index cannot be empty.");

        return false;
    }

    if (int.TryParse(userInput, out index) && index >= 1 && index <= todos.Count)
    {
        return true;
    }

    Console.WriteLine("The given index is not valid.");

    return false;
}


void RemoveTodoAtIndex(int index)
{

    var todoToBeRemoved = todos[index];

    todos.RemoveAt(index);

    Console.WriteLine("TODO removed: " + todoToBeRemoved);
}

static void ShowNoTodosMessages()
{
    Console.WriteLine("No TODOs have been added yet.");
}


