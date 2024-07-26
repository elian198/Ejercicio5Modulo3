﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Ejercicio5Modulo3.Models.Entity
{
    public partial class Usuario
    {
        public int Id { get; set; }

        [JsonPropertyName("name.first")]
        public string Nombre { get; set; }

        [JsonPropertyName("name.last")]
        public string Apellido { get; set; }

        [JsonPropertyName("dob.age")]
        public int Edad { get; set; }

        [JsonPropertyName("gender")]
        public string Genero { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("login.username")]
        public string NombreUsuario { get; set; }

        [JsonPropertyName("login.password")]
        public string Password { get; set; }

        [JsonPropertyName("city")]
        public string Ciudad { get; set; }

        [JsonPropertyName("state")]
        public string Estado { get; set; }

        [JsonPropertyName("country")]
        public string Pais { get; set; }

        public Usuario(
            string nombre, string apellido, int edad,
            string genero, string email, string nombreUsuario, string password, 
            string ciudad, string estado, string pais)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Genero = genero;
            Email = email;
            NombreUsuario = nombreUsuario;
            Password = password;
            Ciudad = ciudad;
            Estado = estado;
            Pais = pais;
        }
    }


}