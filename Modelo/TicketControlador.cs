using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    



public static class TicketControlador
{
    public static string Create(Ticket p)

    {
        var res = TicketsList.ListadoTickets.Find(x => x.Nombre == p.Nombre);

        if (res != null)
            return $"El ticket {p.Nombre} ya está registrado.";

        TicketsEntity entity = new TicketsEntity()
        {
            Nombre = p.Nombre,
            Rut = p.Rut,
            Telefono = p.Telefono,
            Email = p.Email,
            PersonaEmpresa = p.PersonaEmpresa,
            SoporteTecnico = p.SoporteTecnico,
            Reparacion = p.Reparacion,
            Devolucion = p.Devolucion,
            Producto = p.Producto,
            Descripcion = p.Descripcion
        };

        TicketsList.ListadoTickets.Add(entity);

        return $"El ticket {p.Nombre} ha sido agregado con éxito!";
    }

    public static Ticket Read(string id)
    {
        var res = TicketsList.ListadoTickets.Find(x => x.Id == id);

        if (res == null)
            return null;

        Ticket p = new Ticket()
        {
            Id = res.Id,
            Nombre = res.Nombre,
            Rut = res.Rut,
            Telefono = res.Telefono,
            Email = res.Email,
            PersonaEmpresa = res.PersonaEmpresa,
            SoporteTecnico = res.SoporteTecnico,
            Reparacion = res.Reparacion,
            Devolucion = res.Devolucion,
            Producto = res.Producto,
            Descripcion = res.Descripcion,
            CreatedAt = res.RetornarCreatedAt()
        };

        return p;
    }

    public static string Update(string id, string Producto, string Descripcion)
    {
        var res = TicketsList.ListadoTickets.Find(x => x.Id == id);

        if (res == null)
            return $"El ticket {id} no existe en los registros";

        res.Producto = Producto;
        res.Descripcion = Descripcion;

        return $"El ticket {id} ha sido actualizada con éxito!";
    }

    public static string Delete(string id)
    {
        var res = TicketsList.ListadoTickets.Find(x => x.Id == id);

        if (res == null)
            return $"El ticket con {id} no existe o no pudo ser encontrada";

            TicketsList.ListadoTickets.Remove(res);

        return $"El ticket {id} ha sido eliminada con éxito!";
    }

    public static List<Ticket> ReadAll()
    {
        List<Ticket> tickets = new List<Ticket>();

            TicketsList.ListadoTickets.ForEach(x =>
        {
            Ticket p = new Ticket()
            {
                Id = x.Id,
                Nombre = x.Nombre,
                Rut = x.Rut,
                Telefono = x.Telefono,
                Email = x.Email,
                PersonaEmpresa = x.PersonaEmpresa,
                SoporteTecnico = x.SoporteTecnico,
                Reparacion = x.Reparacion,
                Devolucion = x.Devolucion,
                Producto = x.Producto,
                Descripcion = x.Descripcion,
                CreatedAt = x.RetornarCreatedAt()
            };

            tickets.Add(p);
        });

        return tickets;
    }

    public static List<Ticket> Search(string filtro)
    {
        List<Ticket> tickets = new List<Ticket>();

            TicketsList.ListadoTickets
                .Where(x =>
                x.Nombre.Contains(filtro) ||
                x.Producto.Contains(filtro) ||
                x.Producto.Contains(filtro))
            .ToList()
            .ForEach(x =>
            {
                Ticket p = new Ticket()
                {
                    Id = x.Id,
                    Nombre = x.Nombre,
                    Rut = x.Rut,
                    Telefono = x.Telefono,
                    Email = x.Email,
                    PersonaEmpresa = x.PersonaEmpresa,
                    SoporteTecnico = x.SoporteTecnico,
                    Reparacion = x.Reparacion,
                    Devolucion = x.Devolucion,
                    Producto = x.Producto,
                    Descripcion = x.Descripcion,
                    CreatedAt = x.RetornarCreatedAt()
                };

                tickets.Add(p);
            });

        return tickets;
    }
}

}
