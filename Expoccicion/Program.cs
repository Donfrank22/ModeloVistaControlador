class Program
{
    static void Main(string[] args)
    {
        UsuarioModelo user = new UsuarioModelo();
        UserView view = new UserView();
        UsuarioControlador controller = new UsuarioControlador(user, view);

        // Actualizar datos del usuario
        controller.UpdateUser();

        // Mostrar los detalles del usuario
        controller.DisplayUser();

        Console.ReadLine();
    }
}