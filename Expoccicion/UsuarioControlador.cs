public class UsuarioControlador
{
    private UsuarioModelo _user;
    private UserView _view;

    public UsuarioControlador(UsuarioModelo user, UserView view)
    {
        _user = user;
        _view = view;
    }

    public void UpdateUser()
    {
        _user = _view.GetUserInput();
    }

    public void DisplayUser()
    {
        _view.DisplayUserDetails(_user.Name, _user.Age);
    }
}