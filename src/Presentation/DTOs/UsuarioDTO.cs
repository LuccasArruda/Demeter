namespace Presentation.DTOs
{
    public class UsuarioDTO
    {
        namespace Demeter.Presentation.DTOs
    {
        public class UsuarioDTO
        {
            public int Codigo { get; set; }
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Telefone { get; set; }
            public List<Ambiente> Ambientes { get; set; }
        }
    }

}
}