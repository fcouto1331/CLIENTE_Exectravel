namespace C3APPLICATION.DTOs
{
    public class UsuarioDTO : BaseDTO
    {
        public bool UsuarioStatus { get; set; }
        public DateTime UsuarioDataCadastro { get; set; }
        public string? UsuarioLogin { get; set; }
        public string? UsuarioPassword { get; set; }
        public int Filial_Id { get; set; }
    }
}
