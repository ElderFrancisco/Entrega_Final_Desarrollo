using Entity;
using Entity.DbModels;

namespace Mapper
{
    public static class FacturaMapper
    {
        public static FacturaEntity ToEntity (Factura factura)
        {
            return new FacturaEntity
            {
                Id = factura.Id,
                Usuario = UsuarioMapper.ToEntity(factura.UsuarioNavigation),
                Metodo = factura.Metodo,
                Monto = factura.Monto,
                Fecha = factura.Fecha,
                Aprobado = factura.Aprobado,
                //Tickets = factura.Tickets.Select(TicketMapper.ToEntity).ToList()
            };
        }
        public static Factura ToDbModel (FacturaEntity facturaEntity)
        {
            return new Factura
            {
                Id = facturaEntity.Id,
                Usuario = facturaEntity.Usuario.Usuario,
                Metodo = facturaEntity.Metodo,
                Monto = facturaEntity.Monto,
                Fecha = facturaEntity.Fecha,
                Aprobado = facturaEntity.Aprobado
            };
        }
    }
}
