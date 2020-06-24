using System;
using System.Windows.Forms;

namespace ProyectoPoo.Controlador
{
    public class InvalidCharacterForNicknameException :Exception
    {
        public InvalidCharacterForNicknameException() : base("El nickname no puede tener mas de 10 caracteres.") {}
    }
}