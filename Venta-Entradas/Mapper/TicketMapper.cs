using Entity;
using Entity.DbModels;

namespace Mapper
{
    public static class TicketMapper
    {
        public static TicketEntity ToEntity (Ticket ticket)
        {
            return new TicketEntity
            {
                Usuario = UsuarioMapper.ToEntity(ticket.UsuarioNavigation),
                Evento = EventoMapper.ToEntity(ticket.IdEventoNavigation),
                Factura = FacturaMapper.ToEntity(ticket.IdFacturaNavigation),
                Id = ticket.Id
            };
        }
        public static Ticket ToDbModel(TicketEntity ticketEntity)
        {
            return new Ticket
            {
                Usuario = ticketEntity.Usuario.Usuario,
                IdEvento = ticketEntity.Evento.Id,
                IdFactura = ticketEntity.Factura.Id,
                Id = ticketEntity.Id

            };
        }
        //agrego Esta funcion pq nose pq le agrega el id 0, y falla al insertar en la db
        //public static Ticket ToDbModelToInsert(TicketEntity ticketEntity)
        //{
        //    return new Ticket
        //    {
        //        Usuario = ticketEntity.Usuario.Usuario,
        //        IdEvento = ticketEntity.Evento.Id,
        //        IdFactura = ticketEntity.Factura.Id,
        //        //Id = ticketEntity.Id

        //    };
        //}
    }
}
