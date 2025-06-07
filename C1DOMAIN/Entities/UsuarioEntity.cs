namespace C1DOMAIN.Entities
{
    public class UsuarioEntity : BaseEntity
    {
        public UsuarioEntity(int id, Guid guidId, bool usuarioStatus, DateTime usuarioDataCadastro, string usuarioLogin, string usuarioPassword, int filial_Id)
            : base(id, guidId) 
        {
            UsuarioStatus = usuarioStatus;
            UsuarioDataCadastro = usuarioDataCadastro;
            UsuarioLogin = usuarioLogin;
            UsuarioPassword = usuarioPassword;
            Filial_Id = filial_Id;
        }

        public bool UsuarioStatus { get; private set; }
        public DateTime UsuarioDataCadastro { get; private set; }
        public string UsuarioLogin { get; private set; }
        public string UsuarioPassword { get; private set; }
        public int Filial_Id { get; private set; }
    }
}
