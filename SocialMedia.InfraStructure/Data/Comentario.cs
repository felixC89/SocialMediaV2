using System;
using System.Collections.Generic;

namespace SocialMedia.InfraStructure.Data
{
    public partial class Comentario
    {
        public int IdComentario { get; set; }
        public int IdPublicacion { get; set; }
        public int IdUsuario { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public bool Activo { get; set; }

        public Publicacion IdPublicacionNavigation { get; set; }
        public Usuario IdUsuarioNavigation { get; set; }
    }
}
