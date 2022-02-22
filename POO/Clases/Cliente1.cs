﻿namespace POO.Clases
{
    public class Cliente
    {
        public string Identidad { get; set; }
        public string Nombre { get; set; }

        public Cliente() { }

        public Cliente(string identidad, string nombre)
        {
            Identidad = identidad;
            Nombre = nombre;
        }
    }
}
