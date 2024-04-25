
namespace SistemaLogin
{
    static class CadastroUsuarios
    {
        private static Usuario[] usuarios = 
        { 
            new Usuario(){ Nome = "JVAMORIM", Senha = "123456" },
            new Usuario(){ Nome = "VIROBERTO", Senha = "Amorim" },
            new Usuario(){ Nome = "AMORIM", Senha = "abc123" } 
        }; 

        // Propiedade
        private static Usuario _userLogado = null;
        public static Usuario UsuarioLogado
        {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }
        //

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {   
                    UsuarioLogado = usuario;
                    return true;
                }
            }

            return false;
        }
    }
}