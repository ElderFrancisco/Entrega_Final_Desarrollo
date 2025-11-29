using Entity;
using Entity.DbModels;

namespace Mapper
{
    public static class EventoMapper
    {

        public static EventoEntity ToEntity(Evento evento)
        {
            return new EventoEntity
            {
                Nombre = evento.Nombre,
                Descripcion = evento.Descripcion,
                Id = evento.Id,
                Precio = evento.Precio,
                Cantidad = evento.Cantidad


            };
        }
        public static Evento ToDbModel(EventoEntity eventoEntity)
        {
            return new Evento
            {
                Nombre = eventoEntity.Nombre,
                Descripcion = eventoEntity.Descripcion,
                Id = eventoEntity.Id,
                Precio = eventoEntity.Precio,
                Cantidad = eventoEntity.Cantidad

            };
        }
    }
}
