using System;

namespace ProyectoPoo.Controlador
{
    public class DBErrorException : Exception
    {
        public DBErrorException() : base("Ha ocurrido un error en la base de datos"){}
    }
}