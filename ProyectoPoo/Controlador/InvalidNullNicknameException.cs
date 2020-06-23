using System;

namespace ProyectoPoo.Controlador
{
    public class InvalidNullNicknameException : Exception
    {
     public   InvalidNullNicknameException() : base("El nickname no puede quedar nulo"){}
    }
}