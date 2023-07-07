public class UserView
{
    public void DisplayUserDetails(string name, int age)
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
    }

    public UsuarioModelo GetUserInput()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        return new UsuarioModelo { Name = name, Age = age };
    }
}