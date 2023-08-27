using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema1_4.Dominio
{
    internal class Equipo
    {

        public int EquipoNro { get; set; }
        public string NombreEquipo { get; set; }
        public string DirectorTecnico { get; set; }

        public List<Jugador> Jugadores { get; set; }

        public Equipo()
        {
            Jugadores = new List<Jugador>();
        }

        public void AgregarJugador(Jugador jugador)
        {
            Jugadores.Add(jugador);
        }

        public void QuitarJugador(int posicion)
        {
            Jugadores.RemoveAt(posicion);
        }

    }
}
