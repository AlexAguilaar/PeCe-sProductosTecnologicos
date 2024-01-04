using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Datos


{
    public static class TicketsList
    {
        private static List<TicketsEntity> _listadoTickets = new List<TicketsEntity>();

        public static List<TicketsEntity> ListadoTickets
        {
            get { return _listadoTickets; }
            set { _listadoTickets = value; }
        }
    }
}

