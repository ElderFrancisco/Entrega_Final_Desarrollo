using Entity;
using Entity.DbModels;

namespace Mapper
{
    public static class UsuarioMapper
    {
        public static UsuarioEntity ToEntity(Usuario usuario)
        {
            return new UsuarioEntity
            {
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                Dni = usuario.Dni,
                Contraseña = usuario.Contraseña,
                Usuario = usuario.Usuario1,
                Admin = usuario.Admin,
                //Facturas = usuario.Facturas.Select(FacturaMapper.ToEntity).ToList(),

            };
        }
        public static Usuario ToDbModel(UsuarioEntity usuarioEntity)
        {
            return new Usuario
            {
                Nombre = usuarioEntity.Nombre,
                Apellido = usuarioEntity.Apellido,
                Dni = usuarioEntity.Dni,
                Contraseña = usuarioEntity.Contraseña,
                Usuario1 = usuarioEntity.Usuario,
                Admin = usuarioEntity.Admin
            };
        }
    }
}
