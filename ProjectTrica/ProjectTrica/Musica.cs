using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace ProjectTrica
{
    class Musica
    {
        string ruta = Directory.GetCurrentDirectory() + "\\Musicas\\";
        SoundPlayer tocar;
        public void direccion(string a)
        {
            tocar = new SoundPlayer(ruta + a);
        }
        public void Reproductor()
        {
            tocar.PlayLooping();
        }
    }
}
