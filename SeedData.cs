﻿using FarolitoAPIs.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FarolitoAPIs.Data
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider, UserManager<Usuario> userManager)
        {
            using var context = new FarolitoDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<FarolitoDbContext>>());

            // Catálogo de componentes
            if (!context.Componentes.Any())
            {
                context.Componentes.AddRange(
                    new Componente { Nombre = "cable", estatus = true },
                    new Componente { Nombre = "regleta de conexión", estatus = true },
                    new Componente { Nombre = "antitirones", estatus = true },
                    new Componente { Nombre = "Tuerca paso 10/100", estatus = true },
                    new Componente { Nombre = "Rosetón", estatus = true },
                    new Componente { Nombre = "Florón", estatus = true },
                    new Componente { Nombre = "remate", estatus = true },
                    new Componente { Nombre = "Prensacables", estatus = true },
                    new Componente { Nombre = "Portalámparas", estatus = true },
                    new Componente { Nombre = "casquillo", estatus = true },
                    new Componente { Nombre = "arandela", estatus = true },
                    new Componente { Nombre = "pantalla", estatus = true },
                    new Componente { Nombre = "Bombilla", estatus = true }
                );
                
                context.SaveChanges();
            }

            //Catalogo de roles
            if (!context.Roles.Any())
            {
                var roles = new[] { "Administrador", "Cliente", "Logística", "Almacen", "Produccion" };

                foreach (var role in roles)
                {
                    if (!context.Roles.Any(r => r.Name == role))
                    {
                        var identityRole = new IdentityRole(role)
                        {
                            NormalizedName = role.ToUpper()
                        };
                        await context.Roles.AddAsync(identityRole);
                    }
                }
                await context.SaveChangesAsync();
            }

            //Catalogo de usuarios
            if (!context.Users.Any())
            {
                var users = new[]
                {
                    new Usuario { Id = "1", UserName = "alexa@mail.com", Email = "alexa@mail.com", EmailConfirmed = true, FullName = "Alexa Guerrero López" },
                    new Usuario { Id = "2", UserName = "almeida@mail.com", Email = "almeida@mail.com", EmailConfirmed = true, FullName = "Jose Angel Ramirez Almeida" },
                    new Usuario { Id = "3", UserName = "angel@mail.com", Email = "angel@mail.com", EmailConfirmed = true, FullName = "Angel Eduardo Juarez Alvizo" },
                    new Usuario { Id = "4", UserName = "akayasha1410@gmail.com", Email = "akayasha1410@gmail.com", EmailConfirmed = true, FullName = "Sergio de Jesús Salazar Cabrera" },
                    new Usuario { Id = "5", UserName = "adriandario@mail.com", Email = "adriandario@mail.com", EmailConfirmed = true, FullName = "Adrián Darío Bravo Luna" },
                    new Usuario { Id = "6", UserName = "Pjuancarlos@mail.com", Email = "Pjuancarlos@mail.com", EmailConfirmed = true, FullName = "Juan Carlos Pérez López" },
                    new Usuario { Id = "7", UserName = "Gmaríafernanda@mail.com", Email = "Gmaríafernanda@mail.com", EmailConfirmed = true, FullName = "María Fernanda González Martínez" },
                    new Usuario { Id = "8", UserName = "Vcarlos@mail.com", Email = "Vcarlos@mail.com", EmailConfirmed = true, FullName = "Carlos Vargas Mendoza" },
                    new Usuario { Id = "9", UserName = "Nluisa@mail.com", Email = "Nluisa@mail.com", EmailConfirmed = true, FullName = "Luisa Navarro Ortiz" },
                    new Usuario { Id = "10", UserName = "Jmanuel@mail.com", Email = "Jmanuel@mail.com", EmailConfirmed = true, FullName = "Manuel Jiménez Flores" },
                    new Usuario { Id = "11", UserName = "Rjoséluis@mail.com", Email = "Rjoséluis@mail.com", EmailConfirmed = true, FullName = "José Luis Rodríguez Hernández" },
                    new Usuario { Id = "12", UserName = "Ranasofía@mail.com", Email = "Ranasofía@mail.com", EmailConfirmed = true, FullName = "Ana Sofía Ramírez Torres" },
                    new Usuario { Id = "13", UserName = "Oluisfernando@mail.com", Email = "Oluisfernando@mail.com", EmailConfirmed = true, FullName = "Luis Fernando Ortiz Delgado" },
                    new Usuario { Id = "14", UserName = "Adaniela@mail.com", Email = "Adaniela@mail.com", EmailConfirmed = true, FullName = "Daniela Aguilar Morales" },
                    new Usuario { Id = "15", UserName = "Snatalia@mail.com", Email = "Snatalia@mail.com", EmailConfirmed = true, FullName = "Natalia Soto Ruiz" },
                    new Usuario { Id = "16", UserName = "Mandrés@mail.com", Email = "Mandrés@mail.com", EmailConfirmed = true, FullName = "Andrés Molina Castro" },
                    new Usuario { Id = "17", UserName = "Npaola@mail.com", Email = "Npaola@mail.com", EmailConfirmed = true, FullName = "Paola Núñez Gómez" },
                    new Usuario { Id = "18", UserName = "Spedro@mail.com", Email = "Spedro@mail.com", EmailConfirmed = true, FullName = "Pedro Sánchez Díaz" },
                    new Usuario { Id = "19", UserName = "Mgabriela@mail.com", Email = "Mgabriela@mail.com", EmailConfirmed = true, FullName = "Gabriela Moreno García" },
                    new Usuario { Id = "20", UserName = "Csofía@mail.com", Email = "Csofía@mail.com", EmailConfirmed = true, FullName = "Sofía Castillo Romero" },
                    new Usuario { Id = "21", UserName = "Jvaleria@mail.com", Email = "Jvaleria@mail.com", EmailConfirmed = true, FullName = "Valeria Jiménez Silva" },
                    new Usuario { Id = "22", UserName = "Hjavier@mail.com", Email = "Hjavier@mail.com", EmailConfirmed = true, FullName = "Javier Herrera Cruz" },
                    new Usuario { Id = "23", UserName = "Gmiguelángel@mail.com", Email = "Gmiguelángel@mail.com", EmailConfirmed = true, FullName = "Miguel Ángel Guzmán Flores" },
                    new Usuario { Id = "24", UserName = "Rsebastián@mail.com", Email = "Rsebastián@mail.com", EmailConfirmed = true, FullName = "Sebastián Ríos Domínguez" },
                    new Usuario { Id = "25", UserName = "Llorena@mail.com", Email = "Llorena@mail.com", EmailConfirmed = true, FullName = "Lorena López Ortiz" },
                    new Usuario { Id = "26", UserName = "Halejandro@mail.com", Email = "Halejandro@mail.com", EmailConfirmed = true, FullName = "Alejandro Hernández Cortés" },
                    new Usuario { Id = "27", UserName = "Fjulia@mail.com", Email = "Fjulia@mail.com", EmailConfirmed = true, FullName = "Julia Fernández Serrano" },
                    new Usuario { Id = "28", UserName = "Tguadalupe@mail.com", Email = "Tguadalupe@mail.com", EmailConfirmed = true, FullName = "Guadalupe Torres Ramos" },
                    new Usuario { Id = "29", UserName = "Bmiguel@mail.com", Email = "Bmiguel@mail.com", EmailConfirmed = true, FullName = "Miguel Bautista Navarro" },
                    new Usuario { Id = "30", UserName = "Dricardo@mail.com", Email = "Dricardo@mail.com", EmailConfirmed = true, FullName = "Ricardo Díaz Molina" },
                    new Usuario { Id = "31", UserName = "Lfrancisco@mail.com", Email = "Lfrancisco@mail.com", EmailConfirmed = true, FullName = "Francisco Luna Cabrera" },
                    new Usuario { Id = "32", UserName = "Mjosé@mail.com", Email = "Mjosé@mail.com", EmailConfirmed = true, FullName = "José Martínez González" },
                    new Usuario { Id = "33", UserName = "Ejavier@mail.com", Email = "Ejavier@mail.com", EmailConfirmed = true, FullName = "Javier Escobar Pérez" },
                    new Usuario { Id = "34", UserName = "Ladriana@mail.com", Email = "Ladriana@mail.com", EmailConfirmed = true, FullName = "Adriana López Hernández" },
                    new Usuario { Id = "35", UserName = "Dfernando@mail.com", Email = "Dfernando@mail.com", EmailConfirmed = true, FullName = "Fernando Domínguez Sánchez" },
                    new Usuario { Id = "36", UserName = "Mmariana@mail.com", Email = "Mmariana@mail.com", EmailConfirmed = true, FullName = "Mariana Martínez López" },
                    new Usuario { Id = "37", UserName = "Fgustavo@mail.com", Email = "Fgustavo@mail.com", EmailConfirmed = true, FullName = "Gustavo Flores Ramos" }
                };

                //Asignacion de roles a usuarios por UserName
                var userRoles = new Dictionary<string, string>
                {
                    { "alexa@mail.com", "Administrador" },
                    { "almeida@mail.com", "Administrador" },
                    { "angel@mail.com", "Administrador" },
                    { "akayasha1410@gmail.com", "Administrador" },
                    { "adriandario@mail.com", "Administrador" },
                    { "Pjuancarlos@mail.com", "Cliente" },
                    { "Gmaríafernanda@mail.com", "Cliente" },
                    { "Vcarlos@mail.com", "Cliente" },
                    { "Nluisa@mail.com", "Cliente" },
                    { "Jmanuel@mail.com", "Cliente" },
                    { "Rjoséluis@mail.com", "Logística" },
                    { "Ranasofía@mail.com", "Produccion" },
                    { "Oluisfernando@mail.com", "Almacen" },
                    { "Adaniela@mail.com", "Logística" },
                    { "Snatalia@mail.com", "Almacen" },
                    { "Mandrés@mail.com", "Almacen" },
                    { "Npaola@mail.com", "Produccion" },
                    { "Spedro@mail.com", "Cliente" },
                    { "Mgabriela@mail.com", "Cliente" },
                    { "Csofía@mail.com", "Cliente" },
                    { "Jvaleria@mail.com", "Cliente" },
                    { "Hjavier@mail.com", "Cliente" },
                    { "Gmiguelángel@mail.com", "Cliente" },
                    { "Rsebastián@mail.com", "Cliente" },
                    { "Llorena@mail.com", "Cliente" },
                    { "Halejandro@mail.com", "Cliente" },
                    { "Fjulia@mail.com", "Cliente" },
                    { "Tguadalupe@mail.com", "Cliente" },
                    { "Bmiguel@mail.com", "Cliente" },
                    { "Dricardo@mail.com", "Cliente" },
                    { "Lfrancisco@mail.com", "Cliente" },
                    { "Mjosé@mail.com", "Cliente" },
                    { "Ejavier@mail.com", "Cliente" },
                    { "Ladriana@mail.com", "Cliente" },
                    { "Dfernando@mail.com", "Cliente" },
                    { "Mmariana@mail.com", "Cliente" },
                    { "Fgustavo@mail.com", "Cliente" }
                };

                foreach (var user in users)
                {
                    if (await userManager.FindByNameAsync(user.UserName) == null)
                    {
                        await userManager.CreateAsync(user, "Password123!");
                    }
                }

                foreach (var userRole in userRoles)
                {
                    var user = await userManager.FindByNameAsync(userRole.Key);
                    if (user != null)
                    {
                        var role = userRole.Value;

                        if (!await userManager.IsInRoleAsync(user, role))
                        {
                            await userManager.AddToRoleAsync(user, role);
                        }
                    }
                }
            }

            // Registros de proveedores c:
            if (!context.Proveedors.Any())
            {
                context.Proveedors.AddRange(
                    new Proveedor { NombreEmpresa = "ORGON", NombreAtiende = "Julian", ApellidoM = "Perez", ApellidoP = "Mariel", Dirección = "Jose Maria Morelos, 110", Estatus = true, Teléfono = "12345678" },
                    new Proveedor { NombreEmpresa = "Steren", NombreAtiende = "Juan Carlos", ApellidoM = "Pérez", ApellidoP = "López", Dirección = "Avenida Insurgentes Sur 3500, Coyoacán, Ciudad de México, CDMX", Estatus = true, Teléfono = "52 55 5604 3578" },
                    new Proveedor { NombreEmpresa = "Gonher Proveedores", NombreAtiende = "María Fernanda", ApellidoM = "González", ApellidoP = "Martínez", Dirección = "Avenida Mariano Escobedo 151, Anáhuac I Secc, Miguel Hidalgo, Ciudad de México, CDMX", Estatus = true, Teléfono = "52 55 5580 6000" },
                    new Proveedor { NombreEmpresa = "Casa de las Lámparas", NombreAtiende = "José Luis", ApellidoM = "Rodríguez", ApellidoP = "Hernández", Dirección = "Isabel la Católica 36, Centro Histórico, Ciudad de México, CDMX", Estatus = true, Teléfono = "52 55 5512 1398" },
                    new Proveedor { NombreEmpresa = "Distribuidora Eléctrica Mexicana", NombreAtiende = "Ana Sofía", ApellidoM = "Ramírez", ApellidoP = "Torres", Dirección = "Calzada de Tlalpan 2735, Xotepingo, Coyoacán, Ciudad de México, CDMX", Estatus = true, Teléfono = "52 55 5601 2105" },
                    new Proveedor { NombreEmpresa = "Electrónica González", NombreAtiende = "Pedro", ApellidoM = "Sánchez", ApellidoP = "Díaz", Dirección = "Calle Victoria 57, Centro, Ciudad de México, CDMX", Estatus = true, Teléfono = "52 55 5512 0594" },
                    new Proveedor { NombreEmpresa = "Lámparas y Más", NombreAtiende = "Gabriela", ApellidoM = "Moreno", ApellidoP = "García", Dirección = "Avenida Revolución 130, Tacubaya, Ciudad de México, CDMX", Estatus = true, Teléfono = "52 55 5272 3280" },
                    new Proveedor { NombreEmpresa = "Conectores y Componentes", NombreAtiende = "Carlos", ApellidoM = "Vargas", ApellidoP = "Mendoza", Dirección = "Av. del Taller 49, Transito, Cuauhtémoc, Ciudad de México, CDMX", Estatus = true, Teléfono = "52 55 5578 4001" }
                );

                context.SaveChanges();
            }

            // Relación productos(componentes)/proveedor(proveedor)
            if (!context.Productoproveedors.Any())
            {
                context.Productoproveedors.AddRange(
                    new Productoproveedor { ProveedorId = 1, ComponentesId = 3 },
                    new Productoproveedor { ProveedorId = 1, ComponentesId = 4 },
                    new Productoproveedor { ProveedorId = 1, ComponentesId = 7 },
                    new Productoproveedor { ProveedorId = 1, ComponentesId = 11 },
                    new Productoproveedor { ProveedorId = 1, ComponentesId = 13 },
                    new Productoproveedor { ProveedorId = 2, ComponentesId = 3 },
                    new Productoproveedor { ProveedorId = 2, ComponentesId = 4 },
                    new Productoproveedor { ProveedorId = 2, ComponentesId = 7 },
                    new Productoproveedor { ProveedorId = 2, ComponentesId = 13 },
                    new Productoproveedor { ProveedorId = 3, ComponentesId = 7 },
                    new Productoproveedor { ProveedorId = 3, ComponentesId = 8 },
                    new Productoproveedor { ProveedorId = 3, ComponentesId = 11 },
                    new Productoproveedor { ProveedorId = 4, ComponentesId = 4 },
                    new Productoproveedor { ProveedorId = 4, ComponentesId = 5 },
                    new Productoproveedor { ProveedorId = 4, ComponentesId = 8 },
                    new Productoproveedor { ProveedorId = 5, ComponentesId = 1 },
                    new Productoproveedor { ProveedorId = 5, ComponentesId = 8 },
                    new Productoproveedor { ProveedorId = 5, ComponentesId = 9 },
                    new Productoproveedor { ProveedorId = 5, ComponentesId = 10 },
                    new Productoproveedor { ProveedorId = 5, ComponentesId = 12 },
                    new Productoproveedor { ProveedorId = 6, ComponentesId = 1 },
                    new Productoproveedor { ProveedorId = 6, ComponentesId = 7 },
                    new Productoproveedor { ProveedorId = 6, ComponentesId = 8 },
                    new Productoproveedor { ProveedorId = 6, ComponentesId = 9 },
                    new Productoproveedor { ProveedorId = 6, ComponentesId = 11 },
                    new Productoproveedor { ProveedorId = 6, ComponentesId = 13 },
                    new Productoproveedor { ProveedorId = 7, ComponentesId = 1 },
                    new Productoproveedor { ProveedorId = 7, ComponentesId = 7 },
                    new Productoproveedor { ProveedorId = 7, ComponentesId = 9 },
                    new Productoproveedor { ProveedorId = 7, ComponentesId = 10 },
                    new Productoproveedor { ProveedorId = 7, ComponentesId = 11 },
                    new Productoproveedor { ProveedorId = 7, ComponentesId = 13 },
                    new Productoproveedor { ProveedorId = 8, ComponentesId = 5 },
                    new Productoproveedor { ProveedorId = 8, ComponentesId = 9 },
                    new Productoproveedor { ProveedorId = 8, ComponentesId = 11 },
                    new Productoproveedor { ProveedorId = 8, ComponentesId = 12 },

                    new Productoproveedor { ProveedorId = 3, ComponentesId = 2 },
                    new Productoproveedor { ProveedorId = 4, ComponentesId = 2 },
                    new Productoproveedor { ProveedorId = 3, ComponentesId = 6 },
                    new Productoproveedor { ProveedorId = 6, ComponentesId = 6 }
                );
                context.SaveChanges();
            }

            // Relación productos(componentes)/proveedor(proveedor)
            if (!context.Receta.Any())
            {
                context.Receta.AddRange(
                    new Recetum { Nombrelampara = "Lámpara de mesa", Estatus = true },
                    new Recetum { Nombrelampara = "Lámpara de pie", Estatus = true },
                    new Recetum { Nombrelampara = "Lámpara de Techo", Estatus = true },
                    new Recetum { Nombrelampara = "Lámpara colgante", Estatus = true },
                    new Recetum { Nombrelampara = "Lámpara para exterior", Estatus = true }
                );
                context.SaveChanges();
            }

            // Registros/Relación Detalles de recetas
            if (!context.Componentesreceta.Any())
            {
                context.Componentesreceta.AddRange(
                    //
                    new Componentesrecetum { ComponentesId = 1, RecetaId = 1, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 2, RecetaId = 1, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 3, RecetaId = 1, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 4, RecetaId = 1, Cantidad = 2, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 8, RecetaId = 1, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 9, RecetaId = 1, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 10, RecetaId = 1, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 11, RecetaId = 1, Cantidad = 2, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 12, RecetaId = 1, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 13, RecetaId = 1, Cantidad = 1, Estatus = true, },
                    //
                    new Componentesrecetum { ComponentesId = 1, RecetaId = 2, Cantidad = 2, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 2, RecetaId = 2, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 3, RecetaId = 2, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 4, RecetaId = 2, Cantidad = 2, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 8, RecetaId = 2, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 9, RecetaId = 2, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 10, RecetaId = 2, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 11, RecetaId = 2, Cantidad = 2, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 12, RecetaId = 2, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 13, RecetaId = 2, Cantidad = 1, Estatus = true, },
                    //
                    new Componentesrecetum { ComponentesId = 1, RecetaId = 3, Cantidad = 2, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 2, RecetaId = 3, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 4, RecetaId = 3, Cantidad = 2, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 5, RecetaId = 3, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 6, RecetaId = 3, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 9, RecetaId = 3, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 10, RecetaId = 3, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 11, RecetaId = 3, Cantidad = 2, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 13, RecetaId = 3, Cantidad = 1, Estatus = true, },
                    //
                    new Componentesrecetum { ComponentesId = 1, RecetaId = 4, Cantidad = 2, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 2, RecetaId = 4, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 4, RecetaId = 4, Cantidad = 2, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 5, RecetaId = 4, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 6, RecetaId = 4, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 8, RecetaId = 4, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 9, RecetaId = 4, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 10, RecetaId = 4, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 11, RecetaId = 4, Cantidad = 2, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 13, RecetaId = 4, Cantidad = 1, Estatus = true, },
                    //
                    new Componentesrecetum { ComponentesId = 1, RecetaId = 5, Cantidad = 2, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 2, RecetaId = 5, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 3, RecetaId = 5, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 4, RecetaId = 5, Cantidad = 2, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 8, RecetaId = 5, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 9, RecetaId = 5, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 10, RecetaId = 5, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 11, RecetaId = 5, Cantidad = 2, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 12, RecetaId = 5, Cantidad = 1, Estatus = true, },
                    new Componentesrecetum { ComponentesId = 13, RecetaId = 5, Cantidad = 1, Estatus = true, }
                );
                context.SaveChanges();
            }

            // Registros de compras hasta 17 de junio del 2024 
            if (!context.Compras.Any())
            {
                context.Compras.AddRange(
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 1),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 131, Costo = 655, Lote = "PROANT-0000OST", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 131, ProveedorId = 1, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 132, Costo = 2640, Lote = "PROCAB-0000NVM", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 132, ProveedorId = 6, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 117, Costo = 3510, Lote = "PROPOR-0000LLI", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 117, ProveedorId = 5, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 119, Costo = 119, Lote = "PROTUE-0000GJG", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 119, ProveedorId = 2, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 133, Costo = 6650, Lote = "PROROS-0000CIB", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 133, ProveedorId = 4, ComponentesId = 5 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 2),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 116, Costo = 1740, Lote = "PROREG-0000WDC", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 116, ProveedorId = 3, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 133, Costo = 665, Lote = "PROPRE-0000HZG", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 133, ProveedorId = 3, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 135, Costo = 675, Lote = "PROTUE-0000QXS", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 135, ProveedorId = 2, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 126, Costo = 1890, Lote = "PROREG-0000KUG", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 126, ProveedorId = 4, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 120, Costo = 1200, Lote = "PROCAS-0000HQQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 120, ProveedorId = 7, ComponentesId = 10 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 3),
                    UsuarioId = "3",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 106, Costo = 2120, Lote = "PROFLO-0000SDR", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 106, ProveedorId = 6, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 131, Costo = 6550, Lote = "PROPAN-0000NUU", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 131, ProveedorId = 8, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 118, Costo = 1770, Lote = "PROPRE-0000DNF", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 118, ProveedorId = 3, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 115, Costo = 1150, Lote = "PROCAS-0000SRM", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 115, ProveedorId = 7, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 105, Costo = 1050, Lote = "PROANT-0000HLI", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 105, ProveedorId = 2, ComponentesId = 3 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 4),
                    UsuarioId = "3",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 122, Costo = 1830, Lote = "PROREG-0000PFC", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 122, ProveedorId = 4, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 131, Costo = 655, Lote = "PROTUE-0000OPL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 131, ProveedorId = 2, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 127, Costo = 2540, Lote = "PROFLO-0000QBS", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 127, ProveedorId = 3, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 130, Costo = 1300, Lote = "PROPOR-0000QZR", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 130, ProveedorId = 6, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 121, Costo = 1210, Lote = "PROCAS-0000KSF", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 121, ProveedorId = 5, ComponentesId = 10 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 5),
                    UsuarioId = "3",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 149, Costo = 1490, Lote = "PROPOR-0000VID", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 149, ProveedorId = 7, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 146, Costo = 730, Lote = "PROANT-0000HDP", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 146, ProveedorId = 2, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 140, Costo = 1400, Lote = "PROPOR-0000BXZ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 140, ProveedorId = 5, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 138, Costo = 2760, Lote = "PROCAB-0000AUV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 138, ProveedorId = 5, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 105, Costo = 1050, Lote = "PROPOR-0000YLT", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 105, ProveedorId = 6, ComponentesId = 9 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 6),
                    UsuarioId = "1",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 117, Costo = 5850, Lote = "PROBOM-0000BVZ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 117, ProveedorId = 2, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 129, Costo = 6450, Lote = "PROBOM-0000IXV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 129, ProveedorId = 7, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 107, Costo = 5350, Lote = "PROPAN-0000YLR", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 107, ProveedorId = 8, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 149, Costo = 745, Lote = "PROREM-0000RJB", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 149, ProveedorId = 1, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 115, Costo = 23000, Lote = "PROPAN-0000VKH", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 115, ProveedorId = 5, ComponentesId = 12 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 7),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 121, Costo = 6050, Lote = "PROBOM-0000TAD", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 121, ProveedorId = 7, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 146, Costo = 730, Lote = "PROREM-0000HXI", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 146, ProveedorId = 3, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 149, Costo = 7450, Lote = "PROROS-0000FPG", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 149, ProveedorId = 8, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 126, Costo = 1260, Lote = "PROPOR-0000XVF", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 126, ProveedorId = 8, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 133, Costo = 3990, Lote = "PROPOR-0000JUK", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 133, ProveedorId = 7, ComponentesId = 9 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 8),
                    UsuarioId = "2",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 106, Costo = 1060, Lote = "PROPOR-0000NHY", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 106, ProveedorId = 5, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 142, Costo = 710, Lote = "PROARA-0000WYZ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 142, ProveedorId = 3, ComponentesId = 11 }, } }, new Detallecompra { Cantidad = 123, Costo = 2460, Lote = "PROFLO-0000JIB", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 123, ProveedorId = 6, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 126, Costo = 630, Lote = "PROPRE-0000FKM", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 126, ProveedorId = 6, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 106, Costo = 1060, Lote = "PROCAB-0000AUV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 106, ProveedorId = 7, ComponentesId = 1 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 9),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 111, Costo = 5550, Lote = "PROROS-0000FLO", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 111, ProveedorId = 8, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 143, Costo = 7150, Lote = "PROROS-0000MVU", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 143, ProveedorId = 4, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 109, Costo = 1090, Lote = "PROCAS-0000RGC", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 109, ProveedorId = 5, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 145, Costo = 2900, Lote = "PROCAB-0000AIA", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 145, ProveedorId = 7, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 145, Costo = 7250, Lote = "PROROS-0000OLN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 145, ProveedorId = 8, ComponentesId = 5 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 10),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 146, Costo = 2920, Lote = "PROCAS-0000YTV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 146, ProveedorId = 5, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 148, Costo = 2220, Lote = "PROREG-0000QLM", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 148, ProveedorId = 4, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 128, Costo = 1280, Lote = "PROCAS-0000ING", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 128, ProveedorId = 7, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 124, Costo = 1860, Lote = "PROREM-0000BYE", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 124, ProveedorId = 2, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 125, Costo = 625, Lote = "PROPRE-0000PCD", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 125, ProveedorId = 6, ComponentesId = 8 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 11),
                    UsuarioId = "1",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 140, Costo = 4200, Lote = "PROPOR-0000FIV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 140, ProveedorId = 8, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 127, Costo = 127, Lote = "PROTUE-0000ZLI", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 127, ProveedorId = 1, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 131, Costo = 26200, Lote = "PROPAN-0000DYM", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 131, ProveedorId = 5, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 118, Costo = 1180, Lote = "PROBOM-0000NRK", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 118, ProveedorId = 7, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 109, Costo = 545, Lote = "PROPRE-0000ZPP", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 109, ProveedorId = 6, ComponentesId = 8 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 12),
                    UsuarioId = "1",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 121, Costo = 605, Lote = "PROANT-0000IYC", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 121, ProveedorId = 1, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 101, Costo = 505, Lote = "PROPRE-0000ZCJ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 101, ProveedorId = 4, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 118, Costo = 1180, Lote = "PROCAB-0000AYE", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 118, ProveedorId = 7, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 131, Costo = 2620, Lote = "PROROS-0000ASX", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 131, ProveedorId = 4, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 115, Costo = 5750, Lote = "PROPAN-0000SBY", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 115, ProveedorId = 8, ComponentesId = 12 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 13),
                    UsuarioId = "2",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 120, Costo = 1800, Lote = "PROREG-0000VJL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 120, ProveedorId = 3, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 140, Costo = 2100, Lote = "PROREM-0000WHQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 140, ProveedorId = 1, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 103, Costo = 2060, Lote = "PROCAS-0000EZL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 103, ProveedorId = 5, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 131, Costo = 6550, Lote = "PROPAN-0000RIE", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 131, ProveedorId = 8, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 134, Costo = 1340, Lote = "PROANT-0000PWE", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 134, ProveedorId = 2, ComponentesId = 3 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 14),
                    UsuarioId = "5",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 136, Costo = 6800, Lote = "PROROS-0000LTW", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 136, ProveedorId = 8, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 102, Costo = 5100, Lote = "PROPAN-0000XQU", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 102, ProveedorId = 5, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 102, Costo = 20400, Lote = "PROPAN-0000XEC", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 102, ProveedorId = 8, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 137, Costo = 137, Lote = "PROTUE-0000HUN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 137, ProveedorId = 1, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 137, Costo = 2740, Lote = "PROROS-0000KWI", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 137, ProveedorId = 8, ComponentesId = 5 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 15),
                    UsuarioId = "5",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 119, Costo = 2380, Lote = "PROCAB-0000SDG", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 119, ProveedorId = 6, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 102, Costo = 2040, Lote = "PROCAS-0000AOF", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 102, ProveedorId = 5, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 150, Costo = 7500, Lote = "PROFLO-0000QDC", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 150, ProveedorId = 3, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 150, Costo = 2250, Lote = "PROREG-0000VYD", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 150, ProveedorId = 4, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 123, Costo = 1230, Lote = "PROANT-0000AMN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 123, ProveedorId = 2, ComponentesId = 3 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 16),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 128, Costo = 1920, Lote = "PROREG-0000RTC", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 128, ProveedorId = 3, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 114, Costo = 5700, Lote = "PROROS-0000LJA", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 114, ProveedorId = 4, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 125, Costo = 1875, Lote = "PROPRE-0000MMA", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 125, ProveedorId = 5, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 103, Costo = 2060, Lote = "PROCAS-0000FBQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 103, ProveedorId = 5, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 110, Costo = 5500, Lote = "PROPAN-0000TTU", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 110, ProveedorId = 8, ComponentesId = 12 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 17),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 105, Costo = 1050, Lote = "PROANT-0000GNQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 105, ProveedorId = 1, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 100, Costo = 500, Lote = "PROPRE-0000HYR", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 100, ProveedorId = 3, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 127, Costo = 635, Lote = "PROPRE-0000JXE", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 127, ProveedorId = 4, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 114, Costo = 5700, Lote = "PROBOM-0000VOL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 114, ProveedorId = 6, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 110, Costo = 5500, Lote = "PROFLO-0000CCI", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 110, ProveedorId = 6, ComponentesId = 6 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 18),
                    UsuarioId = "3",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 120, Costo = 600, Lote = "PROARA-0000AEN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 120, ProveedorId = 7, ComponentesId = 11 }, } }, new Detallecompra { Cantidad = 148, Costo = 740, Lote = "PROTUE-0000UUG", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 148, ProveedorId = 4, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 113, Costo = 3390, Lote = "PROPOR-0000XLX", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 113, ProveedorId = 5, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 129, Costo = 1290, Lote = "PROANT-0000TUE", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 129, ProveedorId = 2, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 123, Costo = 615, Lote = "PROARA-0000SHO", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 123, ProveedorId = 7, ComponentesId = 11 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 19),
                    UsuarioId = "5",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 133, Costo = 2660, Lote = "PROFLO-0000PWV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 133, ProveedorId = 6, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 121, Costo = 3630, Lote = "PROPOR-0000WST", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 121, ProveedorId = 6, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 120, Costo = 6000, Lote = "PROPAN-0000LTT", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 120, ProveedorId = 5, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 149, Costo = 745, Lote = "PROTUE-0000HBJ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 149, ProveedorId = 4, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 129, Costo = 645, Lote = "PROANT-0000JSL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 129, ProveedorId = 2, ComponentesId = 3 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 20),
                    UsuarioId = "1",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 144, Costo = 720, Lote = "PROPRE-0000TMV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 144, ProveedorId = 6, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 127, Costo = 1270, Lote = "PROCAS-0000TSD", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 127, ProveedorId = 7, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 149, Costo = 1490, Lote = "PROANT-0000TZZ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 149, ProveedorId = 2, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 134, Costo = 2680, Lote = "PROCAS-0000SXH", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 134, ProveedorId = 7, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 111, Costo = 2220, Lote = "PROFLO-0000BWY", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 111, ProveedorId = 3, ComponentesId = 6 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 21),
                    UsuarioId = "2",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 106, Costo = 5300, Lote = "PROBOM-0000JTN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 106, ProveedorId = 2, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 137, Costo = 1370, Lote = "PROBOM-0000SLT", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 137, ProveedorId = 6, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 150, Costo = 7500, Lote = "PROPAN-0000YRI", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 150, ProveedorId = 8, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 111, Costo = 555, Lote = "PROTUE-0000IBL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 111, ProveedorId = 1, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 103, Costo = 515, Lote = "PROREM-0000WCC", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 103, ProveedorId = 3, ComponentesId = 7 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 22),
                    UsuarioId = "5",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 107, Costo = 535, Lote = "PROREM-0000QQJ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 107, ProveedorId = 1, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 128, Costo = 640, Lote = "PROPRE-0000HKN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 128, ProveedorId = 3, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 124, Costo = 1240, Lote = "PROCAS-0000MRV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 124, ProveedorId = 7, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 137, Costo = 685, Lote = "PROARA-0000JAG", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 137, ProveedorId = 8, ComponentesId = 11 }, } }, new Detallecompra { Cantidad = 117, Costo = 5850, Lote = "PROBOM-0000HLP", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 117, ProveedorId = 7, ComponentesId = 13 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 23),
                    UsuarioId = "3",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 118, Costo = 590, Lote = "PROTUE-0000WPZ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 118, ProveedorId = 2, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 104, Costo = 5200, Lote = "PROFLO-0000EEM", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 104, ProveedorId = 6, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 135, Costo = 2025, Lote = "PROREG-0000GMN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 135, ProveedorId = 3, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 134, Costo = 6700, Lote = "PROROS-0000ZNS", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 134, ProveedorId = 8, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 119, Costo = 3570, Lote = "PROPOR-0000BOR", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 119, ProveedorId = 6, ComponentesId = 9 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 24),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 135, Costo = 2700, Lote = "PROCAB-0000SIE", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 135, ProveedorId = 7, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 148, Costo = 740, Lote = "PROTUE-0000GGM", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 148, ProveedorId = 4, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 107, Costo = 1070, Lote = "PROCAS-0000NZU", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 107, ProveedorId = 5, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 101, Costo = 5050, Lote = "PROPAN-0000NST", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 101, ProveedorId = 8, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 132, Costo = 1320, Lote = "PROCAB-0000XUS", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 132, ProveedorId = 6, ComponentesId = 1 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 25),
                    UsuarioId = "5",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 148, Costo = 740, Lote = "PROTUE-0000ZPT", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 148, ProveedorId = 1, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 106, Costo = 5300, Lote = "PROROS-0000KIQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 106, ProveedorId = 8, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 101, Costo = 5050, Lote = "PROROS-0000JRP", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 101, ProveedorId = 8, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 121, Costo = 605, Lote = "PROANT-0000HOZ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 121, ProveedorId = 1, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 129, Costo = 645, Lote = "PROREG-0000IID", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 129, ProveedorId = 3, ComponentesId = 2 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 26),
                    UsuarioId = "2",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 128, Costo = 640, Lote = "PROREG-0000TJL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 128, ProveedorId = 3, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 148, Costo = 1480, Lote = "PROCAS-0000UAH", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 148, ProveedorId = 7, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 121, Costo = 3630, Lote = "PROPOR-0000DWB", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 121, ProveedorId = 8, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 127, Costo = 3810, Lote = "PROPOR-0000CJH", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 127, ProveedorId = 7, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 137, Costo = 1370, Lote = "PROANT-0000ZTN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 137, ProveedorId = 1, ComponentesId = 3 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 27),
                    UsuarioId = "1",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 106, Costo = 5300, Lote = "PROBOM-0000QXZ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 106, ProveedorId = 2, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 120, Costo = 6000, Lote = "PROROS-0000WDG", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 120, ProveedorId = 8, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 116, Costo = 1160, Lote = "PROCAS-0000YQS", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 116, ProveedorId = 7, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 139, Costo = 1390, Lote = "PROCAB-0000GSY", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 139, ProveedorId = 5, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 145, Costo = 725, Lote = "PROPRE-0000VHF", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 145, ProveedorId = 5, ComponentesId = 8 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 28),
                    UsuarioId = "1",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 115, Costo = 1150, Lote = "PROPOR-0000ZRB", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 115, ProveedorId = 6, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 109, Costo = 5450, Lote = "PROBOM-0000IIA", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 109, ProveedorId = 2, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 123, Costo = 1845, Lote = "PROREM-0000ILZ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 123, ProveedorId = 6, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 124, Costo = 6200, Lote = "PROROS-0000JNL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 124, ProveedorId = 8, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 104, Costo = 1560, Lote = "PROREM-0000ZIT", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 104, ProveedorId = 6, ComponentesId = 7 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 29),
                    UsuarioId = "3",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 129, Costo = 2580, Lote = "PROCAB-0000SDB", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 129, ProveedorId = 5, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 118, Costo = 2360, Lote = "PROFLO-0000QON", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 118, ProveedorId = 3, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 116, Costo = 1160, Lote = "PROCAS-0000IHA", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 116, ProveedorId = 7, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 123, Costo = 1230, Lote = "PROBOM-0000PQS", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 123, ProveedorId = 1, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 150, Costo = 3000, Lote = "PROFLO-0000SQC", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 150, ProveedorId = 6, ComponentesId = 6 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 30),
                    UsuarioId = "2",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 121, Costo = 1210, Lote = "PROANT-0000VUG", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 121, ProveedorId = 2, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 124, Costo = 6200, Lote = "PROROS-0000HXT", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 124, ProveedorId = 8, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 124, Costo = 1860, Lote = "PROREG-0000JKR", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 124, ProveedorId = 4, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 124, Costo = 124, Lote = "PROTUE-0000ROG", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 124, ProveedorId = 2, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 133, Costo = 665, Lote = "PROREG-0000WON", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 133, ProveedorId = 3, ComponentesId = 2 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 5, 31),
                    UsuarioId = "1",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 142, Costo = 7100, Lote = "PROPAN-0000MJK", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 142, ProveedorId = 8, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 145, Costo = 1450, Lote = "PROPOR-0000WSB", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 145, ProveedorId = 5, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 105, Costo = 525, Lote = "PROANT-0000DTI", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 105, ProveedorId = 2, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 107, Costo = 1605, Lote = "PROPRE-0000ODE", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 107, ProveedorId = 5, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 102, Costo = 510, Lote = "PROANT-0000OSM", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 102, ProveedorId = 2, ComponentesId = 3 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 1),
                    UsuarioId = "1",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 102, Costo = 1020, Lote = "PROPOR-0000DOI", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 102, ProveedorId = 5, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 107, Costo = 5350, Lote = "PROROS-0000YSC", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 107, ProveedorId = 4, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 133, Costo = 6650, Lote = "PROPAN-0000GDL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 133, ProveedorId = 5, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 108, Costo = 1080, Lote = "PROCAB-0000SOL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 108, ProveedorId = 6, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 126, Costo = 6300, Lote = "PROBOM-0000KXQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 126, ProveedorId = 1, ComponentesId = 13 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 2),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 108, Costo = 2160, Lote = "PROCAS-0000GTO", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 108, ProveedorId = 7, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 103, Costo = 5150, Lote = "PROFLO-0000DNO", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 103, ProveedorId = 3, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 102, Costo = 1020, Lote = "PROANT-0000SIH", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 102, ProveedorId = 2, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 131, Costo = 655, Lote = "PROANT-0000RPP", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 131, ProveedorId = 1, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 109, Costo = 1090, Lote = "PROCAS-0000YAB", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 109, ProveedorId = 7, ComponentesId = 10 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 3),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 146, Costo = 730, Lote = "PROARA-0000URP", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 146, ProveedorId = 8, ComponentesId = 11 }, } }, new Detallecompra { Cantidad = 122, Costo = 1220, Lote = "PROCAB-0000GDR", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 122, ProveedorId = 7, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 139, Costo = 6950, Lote = "PROFLO-0000BZM", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 139, ProveedorId = 6, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 106, Costo = 106, Lote = "PROARA-0000BBD", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 106, ProveedorId = 1, ComponentesId = 11 }, } }, new Detallecompra { Cantidad = 101, Costo = 1010, Lote = "PROPOR-0000BEV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 101, ProveedorId = 6, ComponentesId = 9 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 4),
                    UsuarioId = "3",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 129, Costo = 645, Lote = "PROPRE-0000IOU", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 129, ProveedorId = 4, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 137, Costo = 2055, Lote = "PROPRE-0000LHV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 137, ProveedorId = 5, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 150, Costo = 30000, Lote = "PROPAN-0000MSK", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 150, ProveedorId = 5, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 103, Costo = 2060, Lote = "PROCAB-0000PDV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 103, ProveedorId = 6, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 106, Costo = 530, Lote = "PROREG-0000ORS", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 106, ProveedorId = 3, ComponentesId = 2 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 5),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 124, Costo = 6200, Lote = "PROBOM-0000HZB", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 124, ProveedorId = 7, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 120, Costo = 6000, Lote = "PROFLO-0000MGL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 120, ProveedorId = 6, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 147, Costo = 2940, Lote = "PROCAB-0000NLC", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 147, ProveedorId = 5, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 105, Costo = 105, Lote = "PROTUE-0000XQQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 105, ProveedorId = 2, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 132, Costo = 660, Lote = "PROARA-0000YGD", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 132, ProveedorId = 1, ComponentesId = 11 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 6),
                    UsuarioId = "2",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 113, Costo = 5650, Lote = "PROFLO-0000QRU", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 113, ProveedorId = 3, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 118, Costo = 1770, Lote = "PROREM-0000FUB", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 118, ProveedorId = 1, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 150, Costo = 750, Lote = "PROREM-0000WJT", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 150, ProveedorId = 6, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 147, Costo = 735, Lote = "PROREM-0000PGL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 147, ProveedorId = 7, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 119, Costo = 1190, Lote = "PROPOR-0000VFN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 119, ProveedorId = 6, ComponentesId = 9 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 7),
                    UsuarioId = "2",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 107, Costo = 107, Lote = "PROARA-0000GDS", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 107, ProveedorId = 8, ComponentesId = 11 }, } }, new Detallecompra { Cantidad = 126, Costo = 2520, Lote = "PROFLO-0000EVS", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 126, ProveedorId = 3, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 144, Costo = 2160, Lote = "PROPRE-0000BKJ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 144, ProveedorId = 4, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 126, Costo = 2520, Lote = "PROCAS-0000ZNR", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 126, ProveedorId = 5, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 138, Costo = 1380, Lote = "PROCAS-0000EME", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 138, ProveedorId = 5, ComponentesId = 10 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 8),
                    UsuarioId = "2",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 105, Costo = 5250, Lote = "PROBOM-0000RCQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 105, ProveedorId = 1, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 132, Costo = 1320, Lote = "PROANT-0000FWZ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 132, ProveedorId = 1, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 108, Costo = 2160, Lote = "PROFLO-0000GOE", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 108, ProveedorId = 6, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 146, Costo = 2190, Lote = "PROREM-0000HJS", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 146, ProveedorId = 7, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 111, Costo = 1110, Lote = "PROBOM-0000ZSI", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 111, ProveedorId = 6, ComponentesId = 13 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 9),
                    UsuarioId = "5",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 102, Costo = 1020, Lote = "PROANT-0000AIU", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 102, ProveedorId = 1, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 137, Costo = 6850, Lote = "PROBOM-0000GXJ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 137, ProveedorId = 1, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 113, Costo = 5650, Lote = "PROFLO-0000SAN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 113, ProveedorId = 3, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 140, Costo = 140, Lote = "PROTUE-0000FEL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 140, ProveedorId = 1, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 100, Costo = 5000, Lote = "PROPAN-0000CVK", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 100, ProveedorId = 8, ComponentesId = 12 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 10),
                    UsuarioId = "1",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 150, Costo = 3000, Lote = "PROROS-0000WBE", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 150, ProveedorId = 8, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 106, Costo = 5300, Lote = "PROFLO-0000OZL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 106, ProveedorId = 6, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 121, Costo = 605, Lote = "PROREG-0000IFU", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 121, ProveedorId = 3, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 117, Costo = 585, Lote = "PROREM-0000DIR", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 117, ProveedorId = 7, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 122, Costo = 1220, Lote = "PROANT-0000CPG", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 122, ProveedorId = 1, ComponentesId = 3 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 11),
                    UsuarioId = "5",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 144, Costo = 2880, Lote = "PROCAS-0000XXN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 144, ProveedorId = 7, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 124, Costo = 620, Lote = "PROARA-0000WIU", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 124, ProveedorId = 6, ComponentesId = 11 }, } }, new Detallecompra { Cantidad = 143, Costo = 715, Lote = "PROTUE-0000YMN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 143, ProveedorId = 1, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 121, Costo = 605, Lote = "PROPRE-0000WUI", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 121, ProveedorId = 4, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 134, Costo = 670, Lote = "PROANT-0000SNC", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 134, ProveedorId = 1, ComponentesId = 3 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 12),
                    UsuarioId = "5",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 113, Costo = 565, Lote = "PROANT-0000FWX", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 113, ProveedorId = 1, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 106, Costo = 530, Lote = "PROANT-0000ZBR", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 106, ProveedorId = 2, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 148, Costo = 740, Lote = "PROTUE-0000XOC", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 148, ProveedorId = 4, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 105, Costo = 2100, Lote = "PROCAS-0000EYV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 105, ProveedorId = 5, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 107, Costo = 535, Lote = "PROREM-0000HNQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 107, ProveedorId = 3, ComponentesId = 7 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 13),
                    UsuarioId = "5",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 126, Costo = 630, Lote = "PROARA-0000SLQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 126, ProveedorId = 3, ComponentesId = 11 }, } }, new Detallecompra { Cantidad = 125, Costo = 125, Lote = "PROTUE-0000XTM", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 125, ProveedorId = 4, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 143, Costo = 28600, Lote = "PROPAN-0000OMM", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 143, ProveedorId = 5, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 117, Costo = 5850, Lote = "PROFLO-0000PPJ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 117, ProveedorId = 6, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 113, Costo = 1130, Lote = "PROANT-0000GWL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 113, ProveedorId = 2, ComponentesId = 3 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 14),
                    UsuarioId = "3",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 141, Costo = 705, Lote = "PROANT-0000YBD", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 141, ProveedorId = 1, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 124, Costo = 1240, Lote = "PROANT-0000ALV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 124, ProveedorId = 2, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 130, Costo = 6500, Lote = "PROFLO-0000FFX", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 130, ProveedorId = 3, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 102, Costo = 1530, Lote = "PROREG-0000QUT", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 102, ProveedorId = 4, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 112, Costo = 560, Lote = "PROARA-0000MDR", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 112, ProveedorId = 7, ComponentesId = 11 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 15),
                    UsuarioId = "5",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 116, Costo = 5800, Lote = "PROBOM-0000WVA", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 116, ProveedorId = 6, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 112, Costo = 2240, Lote = "PROFLO-0000TPV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 112, ProveedorId = 3, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 115, Costo = 2300, Lote = "PROFLO-0000UFU", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 115, ProveedorId = 6, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 132, Costo = 1980, Lote = "PROPRE-0000GYF", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 132, ProveedorId = 6, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 104, Costo = 3120, Lote = "PROPOR-0000AHJ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 104, ProveedorId = 5, ComponentesId = 9 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 16),
                    UsuarioId = "3",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 115, Costo = 1725, Lote = "PROREM-0000EDU", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 115, ProveedorId = 3, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 115, Costo = 5750, Lote = "PROPAN-0000OSR", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 115, ProveedorId = 5, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 135, Costo = 4050, Lote = "PROPOR-0000XPI", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 135, ProveedorId = 8, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 102, Costo = 5100, Lote = "PROPAN-0000FGM", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 102, ProveedorId = 5, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 150, Costo = 3000, Lote = "PROFLO-0000IOE", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 150, ProveedorId = 3, ComponentesId = 6 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 17),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 140, Costo = 28000, Lote = "PROPAN-0000IUV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 140, ProveedorId = 8, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 106, Costo = 1060, Lote = "PROBOM-0000JNY", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 106, ProveedorId = 2, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 127, Costo = 127, Lote = "PROARA-0000XSI", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 127, ProveedorId = 6, ComponentesId = 11 }, } }, new Detallecompra { Cantidad = 139, Costo = 6950, Lote = "PROBOM-0000DLH", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 139, ProveedorId = 2, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 147, Costo = 2940, Lote = "PROROS-0000GUE", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 147, ProveedorId = 4, ComponentesId = 5 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 18),
                    UsuarioId = "2",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 139, Costo = 695, Lote = "PROREG-0000KHG", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 139, ProveedorId = 4, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 145, Costo = 725, Lote = "PROARA-0000LFJ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 145, ProveedorId = 6, ComponentesId = 11 }, } }, new Detallecompra { Cantidad = 150, Costo = 1500, Lote = "PROCAB-0000OJB", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 150, ProveedorId = 5, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 128, Costo = 640, Lote = "PROANT-0000PPL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 128, ProveedorId = 2, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 119, Costo = 1190, Lote = "PROANT-0000WYS", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 119, ProveedorId = 2, ComponentesId = 3 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 19),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 147, Costo = 735, Lote = "PROREM-0000BGY", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 147, ProveedorId = 2, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 100, Costo = 500, Lote = "PROPRE-0000XAZ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 100, ProveedorId = 3, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 100, Costo = 5000, Lote = "PROROS-0000VFV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 100, ProveedorId = 8, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 120, Costo = 3600, Lote = "PROPOR-0000EYB", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 120, ProveedorId = 8, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 144, Costo = 720, Lote = "PROREM-0000RHN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 144, ProveedorId = 6, ComponentesId = 7 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 20),
                    UsuarioId = "1",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 131, Costo = 1965, Lote = "PROREG-0000YTK", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 131, ProveedorId = 4, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 135, Costo = 2700, Lote = "PROROS-0000ZQD", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 135, ProveedorId = 8, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 106, Costo = 2120, Lote = "PROFLO-0000VKE", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 106, ProveedorId = 3, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 131, Costo = 131, Lote = "PROARA-0000WPC", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 131, ProveedorId = 7, ComponentesId = 11 }, } }, new Detallecompra { Cantidad = 142, Costo = 1420, Lote = "PROANT-0000KCE", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 142, ProveedorId = 1, ComponentesId = 3 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 21),
                    UsuarioId = "5",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 149, Costo = 2980, Lote = "PROCAB-0000GFY", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 149, ProveedorId = 6, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 120, Costo = 120, Lote = "PROTUE-0000APO", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 120, ProveedorId = 1, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 150, Costo = 1500, Lote = "PROPOR-0000FLO", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 150, ProveedorId = 8, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 127, Costo = 25400, Lote = "PROPAN-0000ZIT", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 127, ProveedorId = 5, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 112, Costo = 560, Lote = "PROREG-0000NEN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 112, ProveedorId = 4, ComponentesId = 2 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 22),
                    UsuarioId = "5",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 108, Costo = 108, Lote = "PROARA-0000QYF", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 108, ProveedorId = 1, ComponentesId = 11 }, } }, new Detallecompra { Cantidad = 142, Costo = 2840, Lote = "PROCAB-0000RZO", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 142, ProveedorId = 7, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 105, Costo = 1050, Lote = "PROANT-0000LPQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 105, ProveedorId = 1, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 107, Costo = 2140, Lote = "PROCAB-0000BDN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 107, ProveedorId = 5, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 103, Costo = 2060, Lote = "PROCAB-0000FFO", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 103, ProveedorId = 6, ComponentesId = 1 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 23),
                    UsuarioId = "2",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 105, Costo = 525, Lote = "PROREG-0000OHF", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 105, ProveedorId = 3, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 119, Costo = 1785, Lote = "PROPRE-0000SYE", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 119, ProveedorId = 5, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 117, Costo = 1170, Lote = "PROCAB-0000MII", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 117, ProveedorId = 5, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 101, Costo = 505, Lote = "PROREG-0000VFQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 101, ProveedorId = 3, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 133, Costo = 3990, Lote = "PROPOR-0000TYA", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 133, ProveedorId = 5, ComponentesId = 9 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 24),
                    UsuarioId = "3",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 119, Costo = 5950, Lote = "PROROS-0000LLB", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 119, ProveedorId = 4, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 147, Costo = 2940, Lote = "PROFLO-0000CEZ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 147, ProveedorId = 6, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 114, Costo = 2280, Lote = "PROFLO-0000XZX", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 114, ProveedorId = 6, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 135, Costo = 2025, Lote = "PROREM-0000GBK", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 135, ProveedorId = 2, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 109, Costo = 109, Lote = "PROARA-0000API", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 109, ProveedorId = 3, ComponentesId = 11 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 25),
                    UsuarioId = "1",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 122, Costo = 1220, Lote = "PROCAB-0000PIF", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 122, ProveedorId = 7, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 146, Costo = 146, Lote = "PROTUE-0000LGQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 146, ProveedorId = 4, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 107, Costo = 1070, Lote = "PROPOR-0000OED", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 107, ProveedorId = 7, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 116, Costo = 1160, Lote = "PROCAS-0000JUV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 116, ProveedorId = 5, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 139, Costo = 695, Lote = "PROANT-0000AQU", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 139, ProveedorId = 1, ComponentesId = 3 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 26),
                    UsuarioId = "5",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 127, Costo = 635, Lote = "PROANT-0000UAX", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 127, ProveedorId = 2, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 147, Costo = 7350, Lote = "PROBOM-0000LCI", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 147, ProveedorId = 7, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 136, Costo = 2720, Lote = "PROROS-0000OVQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 136, ProveedorId = 4, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 120, Costo = 600, Lote = "PROREM-0000EVD", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 120, ProveedorId = 2, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 150, Costo = 7500, Lote = "PROPAN-0000EOT", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 150, ProveedorId = 5, ComponentesId = 12 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 27),
                    UsuarioId = "3",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 104, Costo = 2080, Lote = "PROCAB-0000TFN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 104, ProveedorId = 5, ComponentesId = 1 }, } }, new Detallecompra { Cantidad = 132, Costo = 1320, Lote = "PROPOR-0000TEJ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 132, ProveedorId = 6, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 110, Costo = 550, Lote = "PROREM-0000ZYW", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 110, ProveedorId = 1, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 133, Costo = 2660, Lote = "PROROS-0000QKN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 133, ProveedorId = 8, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 145, Costo = 145, Lote = "PROARA-0000RUD", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 145, ProveedorId = 6, ComponentesId = 11 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 28),
                    UsuarioId = "5",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 140, Costo = 28000, Lote = "PROPAN-0000MCT", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 140, ProveedorId = 5, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 102, Costo = 510, Lote = "PROTUE-0000VPM", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 102, ProveedorId = 2, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 126, Costo = 1260, Lote = "PROCAS-0000UJV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 126, ProveedorId = 5, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 104, Costo = 1040, Lote = "PROBOM-0000LFV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 104, ProveedorId = 1, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 128, Costo = 1280, Lote = "PROBOM-0000WBX", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 128, ProveedorId = 6, ComponentesId = 13 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 29),
                    UsuarioId = "3",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 131, Costo = 6550, Lote = "PROBOM-0000TSN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 131, ProveedorId = 1, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 125, Costo = 1875, Lote = "PROPRE-0000FNR", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 125, ProveedorId = 5, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 137, Costo = 27400, Lote = "PROPAN-0000LON", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 137, ProveedorId = 5, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 132, Costo = 132, Lote = "PROTUE-0000CGB", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 132, ProveedorId = 1, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 130, Costo = 6500, Lote = "PROFLO-0000CSD", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 130, ProveedorId = 6, ComponentesId = 6 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 6, 30),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 109, Costo = 1090, Lote = "PROBOM-0000BKN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 109, ProveedorId = 2, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 121, Costo = 1815, Lote = "PROREM-0000NKC", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 121, ProveedorId = 1, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 117, Costo = 1755, Lote = "PROREM-0000GNL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 117, ProveedorId = 2, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 108, Costo = 3240, Lote = "PROPOR-0000UCD", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 108, ProveedorId = 8, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 119, Costo = 23800, Lote = "PROPAN-0000ZBR", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 119, ProveedorId = 8, ComponentesId = 12 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 1),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 103, Costo = 515, Lote = "PROREG-0000LQA", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 103, ProveedorId = 3, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 123, Costo = 6150, Lote = "PROBOM-0000DVO", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 123, ProveedorId = 6, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 111, Costo = 555, Lote = "PROREG-0000OZF", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 111, ProveedorId = 4, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 112, Costo = 2240, Lote = "PROROS-0000ESC", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 112, ProveedorId = 4, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 118, Costo = 1770, Lote = "PROPRE-0000CHI", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 118, ProveedorId = 3, ComponentesId = 8 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 2),
                    UsuarioId = "5",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 116, Costo = 3480, Lote = "PROPOR-0000SPS", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 116, ProveedorId = 7, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 149, Costo = 7450, Lote = "PROFLO-0000GRX", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 149, ProveedorId = 3, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 144, Costo = 720, Lote = "PROREG-0000ALL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 144, ProveedorId = 3, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 114, Costo = 570, Lote = "PROTUE-0000OMH", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 114, ProveedorId = 2, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 109, Costo = 545, Lote = "PROARA-0000IGY", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 109, ProveedorId = 7, ComponentesId = 11 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 3),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 134, Costo = 670, Lote = "PROANT-0000OHQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 134, ProveedorId = 2, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 144, Costo = 2160, Lote = "PROREG-0000WZA", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 144, ProveedorId = 3, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 140, Costo = 7000, Lote = "PROBOM-0000OVQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 140, ProveedorId = 6, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 143, Costo = 715, Lote = "PROTUE-0000QVN", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 143, ProveedorId = 1, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 117, Costo = 585, Lote = "PROTUE-0000SCV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 117, ProveedorId = 4, ComponentesId = 4 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 4),
                    UsuarioId = "3",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 147, Costo = 735, Lote = "PROPRE-0000HMT", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 147, ProveedorId = 6, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 118, Costo = 3540, Lote = "PROPOR-0000QPV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 118, ProveedorId = 7, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 142, Costo = 710, Lote = "PROTUE-0000QNV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 142, ProveedorId = 2, ComponentesId = 4 }, } }, new Detallecompra { Cantidad = 124, Costo = 620, Lote = "PROPRE-0000NKX", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 124, ProveedorId = 4, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 132, Costo = 2640, Lote = "PROCAB-0000IBQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 132, ProveedorId = 7, ComponentesId = 1 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 5),
                    UsuarioId = "5",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 136, Costo = 680, Lote = "PROARA-0000JSU", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 136, ProveedorId = 7, ComponentesId = 11 }, } }, new Detallecompra { Cantidad = 121, Costo = 121, Lote = "PROARA-0000HDJ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 121, ProveedorId = 1, ComponentesId = 11 }, } }, new Detallecompra { Cantidad = 103, Costo = 2060, Lote = "PROFLO-0000LGS", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 103, ProveedorId = 3, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 103, Costo = 1545, Lote = "PROREM-0000ERW", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 103, ProveedorId = 7, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 146, Costo = 2920, Lote = "PROROS-0000SGD", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 146, ProveedorId = 4, ComponentesId = 5 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 6),
                    UsuarioId = "1",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 111, Costo = 555, Lote = "PROREG-0000MGU", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 111, ProveedorId = 4, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 110, Costo = 550, Lote = "PROREG-0000KAV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 110, ProveedorId = 4, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 118, Costo = 1770, Lote = "PROREG-0000MGL", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 118, ProveedorId = 4, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 122, Costo = 610, Lote = "PROANT-0000ERV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 122, ProveedorId = 1, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 116, Costo = 1160, Lote = "PROANT-0000UJI", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 116, ProveedorId = 2, ComponentesId = 3 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 7),
                    UsuarioId = "5",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 101, Costo = 5050, Lote = "PROFLO-0000YSG", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 101, ProveedorId = 3, ComponentesId = 6 }, } }, new Detallecompra { Cantidad = 122, Costo = 610, Lote = "PROPRE-0000IRS", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 122, ProveedorId = 4, ComponentesId = 8 }, } }, new Detallecompra { Cantidad = 134, Costo = 6700, Lote = "PROPAN-0000DWO", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 134, ProveedorId = 8, ComponentesId = 12 }, } }, new Detallecompra { Cantidad = 128, Costo = 640, Lote = "PROANT-0000BKF", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 128, ProveedorId = 1, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 115, Costo = 2300, Lote = "PROROS-0000KID", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 115, ProveedorId = 4, ComponentesId = 5 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 8),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 101, Costo = 5050, Lote = "PROROS-0000DPK", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 101, ProveedorId = 4, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 112, Costo = 5600, Lote = "PROBOM-0000DEM", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 112, ProveedorId = 1, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 125, Costo = 625, Lote = "PROREM-0000NMX", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 125, ProveedorId = 6, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 144, Costo = 7200, Lote = "PROROS-0000JZY", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 144, ProveedorId = 4, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 121, Costo = 1210, Lote = "PROCAB-0000JFP", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 121, ProveedorId = 6, ComponentesId = 1 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 9),
                    UsuarioId = "1",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 133, Costo = 1330, Lote = "PROANT-0000HNG", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 133, ProveedorId = 1, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 148, Costo = 740, Lote = "PROANT-0000YBX", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 148, ProveedorId = 1, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 141, Costo = 705, Lote = "PROARA-0000KOG", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 141, ProveedorId = 8, ComponentesId = 11 }, } }, new Detallecompra { Cantidad = 102, Costo = 1020, Lote = "PROBOM-0000MCP", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 102, ProveedorId = 7, ComponentesId = 13 }, } }, new Detallecompra { Cantidad = 138, Costo = 6900, Lote = "PROROS-0000QYH", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 138, ProveedorId = 4, ComponentesId = 5 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 10),
                    UsuarioId = "2",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 140, Costo = 1400, Lote = "PROCAS-0000VPU", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 140, ProveedorId = 5, ComponentesId = 10 }, } }, new Detallecompra { Cantidad = 117, Costo = 1755, Lote = "PROREG-0000EDS", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 117, ProveedorId = 3, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 137, Costo = 6850, Lote = "PROROS-0000SVK", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 137, ProveedorId = 8, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 146, Costo = 1460, Lote = "PROPOR-0000AOM", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 146, ProveedorId = 5, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 135, Costo = 6750, Lote = "PROFLO-0000BTC", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 135, ProveedorId = 3, ComponentesId = 6 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 11),
                    UsuarioId = "3",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 118, Costo = 590, Lote = "PROANT-0000VDM", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 118, ProveedorId = 1, ComponentesId = 3 }, } }, new Detallecompra { Cantidad = 138, Costo = 2070, Lote = "PROREM-0000KWO", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 138, ProveedorId = 2, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 104, Costo = 5200, Lote = "PROROS-0000AFX", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 104, ProveedorId = 4, ComponentesId = 5 }, } }, new Detallecompra { Cantidad = 105, Costo = 525, Lote = "PROARA-0000OOP", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 105, ProveedorId = 3, ComponentesId = 11 }, } }, new Detallecompra { Cantidad = 102, Costo = 3060, Lote = "PROPOR-0000XAM", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 102, ProveedorId = 7, ComponentesId = 9 }, } }, }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 12),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> { new Detallecompra { Cantidad = 134, Costo = 2010, Lote = "PROREG-0000OID", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 134, ProveedorId = 3, ComponentesId = 2 }, } }, new Detallecompra { Cantidad = 115, Costo = 575, Lote = "PROREM-0000JWS", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 115, ProveedorId = 7, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 147, Costo = 1470, Lote = "PROPOR-0000KCX", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 147, ProveedorId = 8, ComponentesId = 9 }, } }, new Detallecompra { Cantidad = 112, Costo = 1680, Lote = "PROREM-0000JIV", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 112, ProveedorId = 3, ComponentesId = 7 }, } }, new Detallecompra { Cantidad = 112, Costo = 112, Lote = "PROTUE-0000MHF", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 112, ProveedorId = 4, ComponentesId = 4 }, } }, }
                },

                // Semana 10 produccion
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 15),
                    UsuarioId = "13",
                    Detallecompras = new List<Detallecompra> {
                        new Detallecompra {Cantidad = 50, Costo = 550, Lote = "PROBOM-000TOPE", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 50, ProveedorId = 5, ComponentesId = 1 } }},
                        new Detallecompra {Cantidad = 50, Costo = 500, Lote = "PROBOM-0001TAD", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 50, ProveedorId = 3, ComponentesId = 2 }, } },
                        new Detallecompra {Cantidad = 50, Costo = 250, Lote = "PROBOM-0001KXQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 50, ProveedorId = 1, ComponentesId = 3 }, }},
                        new Detallecompra {Cantidad = 50, Costo = 50, Lote = "PROBOM-0001JNY", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 50, ProveedorId = 1, ComponentesId = 4 }, }},
                        new Detallecompra {Cantidad = 50, Costo = 1000, Lote = "PROBOM-0001OVQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 50, ProveedorId = 4, ComponentesId = 5 }, }},
                        new Detallecompra {Cantidad = 50, Costo = 1000, Lote = "PROBOM-0001HZB", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 50, ProveedorId = 3, ComponentesId = 6 }, }}
                    }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 16),
                    UsuarioId = "15",
                    Detallecompras = new List<Detallecompra> {
                        new Detallecompra {Cantidad = 50, Costo = 250, Lote = "PROBOM-0002OPE", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 50, ProveedorId = 1, ComponentesId = 7 }, }},
                        new Detallecompra {Cantidad = 50, Costo = 250, Lote = "PROBOM-0002TAD", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 50, ProveedorId = 3, ComponentesId = 8 }, }},
                        new Detallecompra {Cantidad = 50, Costo = 500, Lote = "PROBOM-0002KXQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 50, ProveedorId = 5, ComponentesId = 9 }, }},
                        new Detallecompra {Cantidad = 50, Costo = 100, Lote = "PROBOM-0002JNY", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 50, ProveedorId = 5, ComponentesId = 1 }, }},
                        new Detallecompra {Cantidad = 50, Costo = 50, Lote = "PROBOM-0002OVQ", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 50, ProveedorId = 1, ComponentesId = 11 }, }},
                        new Detallecompra {Cantidad = 50, Costo = 2500, Lote = "PROBOM-0002HZB", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 50, ProveedorId = 5, ComponentesId = 12 }, }},
                        new Detallecompra {Cantidad = 50, Costo = 500, Lote = "PROBOM-0002HAB", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 50, ProveedorId = 1, ComponentesId = 13 } }}
                    }
                },
                //Semana anterior
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 15),
                    UsuarioId = "1",
                    Detallecompras = new List<Detallecompra> {
                        new Detallecompra { Cantidad = 20, Costo = 200, Lote = "PROCAB-1000OID", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 20, ProveedorId = 3, ComponentesId = 1 }, } },
                        new Detallecompra { Cantidad = 20, Costo = 100, Lote = "PROREG-1000OID", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 20, ProveedorId = 3, ComponentesId = 2 }, } },
                        new Detallecompra { Cantidad = 20, Costo = 100, Lote = "PROANT-1000OID", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 20, ProveedorId = 3, ComponentesId = 3 }, } },
                    }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 16),
                    UsuarioId = "2",
                    Detallecompras = new List<Detallecompra> {
                        new Detallecompra { Cantidad = 20, Costo = 20, Lote = "PROTUE-1000OID", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 20, ProveedorId = 3, ComponentesId = 4 }, } },
                        new Detallecompra { Cantidad = 20, Costo = 400, Lote = "PROROS-1000OID", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 20, ProveedorId = 3, ComponentesId = 5 }, } },
                        new Detallecompra { Cantidad = 20, Costo = 400, Lote = "PROFLO-1000OID", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 20, ProveedorId = 3, ComponentesId = 6 }, } },                    }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 17),
                    UsuarioId = "3",
                    Detallecompras = new List<Detallecompra> {
                        new Detallecompra { Cantidad = 20, Costo = 200, Lote = "PROCAS-1000OID", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 20, ProveedorId = 3, ComponentesId = 10 }, } },
                        new Detallecompra { Cantidad = 20, Costo = 20, Lote = "PROARA-1000OID", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 20, ProveedorId = 3, ComponentesId = 11 }, } },
                    }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 18),
                    UsuarioId = "4",
                    Detallecompras = new List<Detallecompra> {
                        new Detallecompra { Cantidad = 20, Costo = 1000, Lote = "PROPAN-1000OID", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 20, ProveedorId = 3, ComponentesId = 12 }, } },
                        new Detallecompra { Cantidad = 20, Costo = 200, Lote = "PROBOM-1000OID", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 20, ProveedorId = 3, ComponentesId = 13 }, } },
                    }
                },
                new Compra
                {
                    Fecha = new DateOnly(2024, 7, 19),
                    UsuarioId = "5",
                    Detallecompras = new List<Detallecompra> {
                        new Detallecompra { Cantidad = 20, Costo = 2010, Lote = "PROREG-1000OID", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 20, ProveedorId = 3, ComponentesId = 2 }, } },
                        new Detallecompra { Cantidad = 20, Costo = 575, Lote = "PROREM-1000JWS", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 20, ProveedorId = 5, ComponentesId = 1 }, } },
                        new Detallecompra { Cantidad = 20, Costo = 1470, Lote = "PROPOR-1000KCX", Inventariocomponentes = new List<Inventariocomponente> { new Inventariocomponente { Cantidad = 20, ProveedorId = 8, ComponentesId = 9 }, } }
                    }
                }
                );

                context.SaveChanges();
            }

            // Registros de producciones para inventarios de lámparas
            if (!context.Inventariolamparas.Any())
            {
                context.Inventariolamparas.AddRange(
                    new Inventariolampara
                    {
                        Lote = "1",
                        Cantidad = 50,
                        Precio = 0,
                        FechaCreacion = new DateOnly(2024, 5, 10),
                        RecetaId = 1,
                        Produccion = new Produccion
                        {
                            Fecha = new DateOnly(2024, 5, 10),
                            UsuarioId = "1",
                            Costo = 0,
                            Solicitudproduccion = new Solicitudproduccion { Descripcion = "Lamparas insuficientes", Cantidad = 50, RecetaId = 1, UsuarioId = "2", Estatus = 1 },
                            Detalleproduccions = new List<Detalleproduccion> {
                                new Detalleproduccion { InventariocomponentesId = 2 },
                                new Detalleproduccion { InventariocomponentesId = 6 },
                                new Detalleproduccion { InventariocomponentesId = 1 },
                                new Detalleproduccion { InventariocomponentesId = 4 },
                                new Detalleproduccion { InventariocomponentesId = 7 },
                                new Detalleproduccion { InventariocomponentesId = 3 },
                                new Detalleproduccion { InventariocomponentesId = 10 },
                                new Detalleproduccion { InventariocomponentesId = 37 },
                                new Detalleproduccion { InventariocomponentesId = 12 },
                                new Detalleproduccion { InventariocomponentesId = 26 },
                            }
                        }
                    },
                    new Inventariolampara
                    {
                        Lote = "2",
                        Cantidad = 50,
                        Precio = 0,
                        FechaCreacion = new DateOnly(2024, 5, 14),
                        RecetaId = 2,
                        Produccion = new Produccion
                        {
                            Fecha = new DateOnly(2024, 5, 14),
                            UsuarioId = "1",
                            Costo = 0,
                            Solicitudproduccion = new Solicitudproduccion { Descripcion = "Lamparas insuficientes", Cantidad = 50, RecetaId = 2, UsuarioId = "2", Estatus = 1 },
                            Detalleproduccions = new List<Detalleproduccion> {
                                new Detalleproduccion { InventariocomponentesId = 2 },
                                new Detalleproduccion { InventariocomponentesId = 24 },
                                new Detalleproduccion { InventariocomponentesId = 6 },
                                new Detalleproduccion { InventariocomponentesId = 1 },
                                new Detalleproduccion { InventariocomponentesId = 4 },
                                new Detalleproduccion { InventariocomponentesId = 8 },
                                new Detalleproduccion { InventariocomponentesId = 7 },
                                new Detalleproduccion { InventariocomponentesId = 3 },
                                new Detalleproduccion { InventariocomponentesId = 10 },
                                new Detalleproduccion { InventariocomponentesId = 37 },
                                new Detalleproduccion { InventariocomponentesId = 90 },
                                new Detalleproduccion { InventariocomponentesId = 12 },
                                new Detalleproduccion { InventariocomponentesId = 26 },
                            }
                        }
                    },
                    new Inventariolampara
                    {
                        Lote = "3",
                        Cantidad = 50,
                        Precio = 0,
                        FechaCreacion = new DateOnly(2024, 5, 15),
                        RecetaId = 3,
                        Produccion = new Produccion
                        {
                            Fecha = new DateOnly(2024, 5, 15),
                            UsuarioId = "1",
                            Costo = 0,
                            Solicitudproduccion = new Solicitudproduccion { Descripcion = "Lamparas insuficientes", Cantidad = 50, RecetaId = 3, UsuarioId = "2", Estatus = 1 },
                            Detalleproduccions = new List<Detalleproduccion> {
                                new Detalleproduccion { InventariocomponentesId = 24 },
                                new Detalleproduccion { InventariocomponentesId = 6 },
                                new Detalleproduccion { InventariocomponentesId = 9 },
                                new Detalleproduccion { InventariocomponentesId = 8 },
                                new Detalleproduccion { InventariocomponentesId = 17 },
                                new Detalleproduccion { InventariocomponentesId = 5 },
                                new Detalleproduccion { InventariocomponentesId = 11 },
                                new Detalleproduccion { InventariocomponentesId = 3 },
                                new Detalleproduccion { InventariocomponentesId = 19 },
                                new Detalleproduccion { InventariocomponentesId = 10 },
                                new Detalleproduccion { InventariocomponentesId = 14 },
                                new Detalleproduccion { InventariocomponentesId = 90 },
                                new Detalleproduccion { InventariocomponentesId = 26 },
                                new Detalleproduccion { InventariocomponentesId = 27 },
                            }
                        }
                    },
                    new Inventariolampara
                    {
                        Lote = "4",
                        Cantidad = 50,
                        Precio = 0,
                        FechaCreacion = new DateOnly(2024, 5, 16),
                        RecetaId = 4,
                        Produccion = new Produccion
                        {
                            Fecha = new DateOnly(2024, 5, 16),
                            UsuarioId = "1",
                            Costo = 0,
                            Solicitudproduccion = new Solicitudproduccion { Descripcion = "Lamparas insuficientes", Cantidad = 50, RecetaId = 4, UsuarioId = "2", Estatus = 1 },
                            Detalleproduccions = new List<Detalleproduccion> {
                                new Detalleproduccion { InventariocomponentesId = 24 },
                                new Detalleproduccion { InventariocomponentesId = 40 },
                                new Detalleproduccion { InventariocomponentesId = 9 },
                                new Detalleproduccion { InventariocomponentesId = 17 },
                                new Detalleproduccion { InventariocomponentesId = 52 },
                                new Detalleproduccion { InventariocomponentesId = 5 },
                                new Detalleproduccion { InventariocomponentesId = 11 },
                                new Detalleproduccion { InventariocomponentesId = 7 },
                                new Detalleproduccion { InventariocomponentesId = 13 },
                                new Detalleproduccion { InventariocomponentesId = 19 },
                                new Detalleproduccion { InventariocomponentesId = 14 },
                                new Detalleproduccion { InventariocomponentesId = 90 },
                                new Detalleproduccion { InventariocomponentesId = 86 },
                                new Detalleproduccion { InventariocomponentesId = 27 },
                            }
                        }
                    },
                    new Inventariolampara
                    {
                        Lote = "5",
                        Cantidad = 50,
                        Precio = 0,
                        FechaCreacion = new DateOnly(2024, 5, 17),
                        RecetaId = 5,
                        Produccion = new Produccion
                        {
                            Fecha = new DateOnly(2024, 5, 17),
                            UsuarioId = "1",
                            Costo = 0,
                            Solicitudproduccion = new Solicitudproduccion { Descripcion = "Lamparas insuficientes", Cantidad = 50, RecetaId = 5, UsuarioId = "2", Estatus = 1 },
                            Detalleproduccions = new List<Detalleproduccion> {
                                new Detalleproduccion { InventariocomponentesId = 40 },
                                new Detalleproduccion { InventariocomponentesId = 9 },
                                new Detalleproduccion { InventariocomponentesId = 1 },
                                new Detalleproduccion { InventariocomponentesId = 15 },
                                new Detalleproduccion { InventariocomponentesId = 52 },
                                new Detalleproduccion { InventariocomponentesId = 13 },
                                new Detalleproduccion { InventariocomponentesId = 19 },
                                new Detalleproduccion { InventariocomponentesId = 14 },
                                new Detalleproduccion { InventariocomponentesId = 86 },
                                new Detalleproduccion { InventariocomponentesId = 109 },
                                new Detalleproduccion { InventariocomponentesId = 12 },
                                new Detalleproduccion { InventariocomponentesId = 30 },
                                new Detalleproduccion { InventariocomponentesId = 27 },
                                new Detalleproduccion { InventariocomponentesId = 31 },
                            }
                        }
                    },
                    //
                    new Inventariolampara
                    {
                        Lote = "B1",
                        Cantidad = 50,
                        Precio = 0,
                        FechaCreacion = new DateOnly(2024, 6, 3),
                        RecetaId = 1,
                        Produccion = new Produccion
                        {
                            Fecha = new DateOnly(2024, 6, 3),
                            UsuarioId = "5",
                            Costo = 0,
                            Solicitudproduccion = new Solicitudproduccion { Descripcion = "Lamparas insuficientes", Cantidad = 50, RecetaId = 1, UsuarioId = "2", Estatus = 1 },
                            Detalleproduccions = new List<Detalleproduccion> {
                                new Detalleproduccion { InventariocomponentesId = 40 },
                                new Detalleproduccion { InventariocomponentesId = 44 },
                                new Detalleproduccion { InventariocomponentesId = 9 },
                                new Detalleproduccion { InventariocomponentesId = 16 },
                                new Detalleproduccion { InventariocomponentesId = 15 },
                                new Detalleproduccion { InventariocomponentesId = 52 },
                                new Detalleproduccion { InventariocomponentesId = 69 },
                                new Detalleproduccion { InventariocomponentesId = 13 },
                                new Detalleproduccion { InventariocomponentesId = 39 },
                                new Detalleproduccion { InventariocomponentesId = 19 },
                                new Detalleproduccion { InventariocomponentesId = 21 },
                                new Detalleproduccion { InventariocomponentesId = 14 },
                                new Detalleproduccion { InventariocomponentesId = 20 },
                                new Detalleproduccion { InventariocomponentesId = 109 },
                                new Detalleproduccion { InventariocomponentesId = 30 },
                                new Detalleproduccion { InventariocomponentesId = 31 },
                            }
                        }
                    },
                    new Inventariolampara
                    {
                        Lote = "B2",
                        Cantidad = 50,
                        Precio = 0,
                        FechaCreacion = new DateOnly(2024, 6, 4),
                        RecetaId = 2,
                        Produccion = new Produccion
                        {
                            Fecha = new DateOnly(2024, 6, 4),
                            UsuarioId = "1",
                            Costo = 0,
                            Solicitudproduccion = new Solicitudproduccion { Descripcion = "Lamparas insuficientes", Cantidad = 50, RecetaId = 2, UsuarioId = "2", Estatus = 1 },
                            Detalleproduccions = new List<Detalleproduccion>
                            {
                                new Detalleproduccion { InventariocomponentesId = 44 },
                                new Detalleproduccion { InventariocomponentesId = 58 },
                                new Detalleproduccion { InventariocomponentesId = 16 },
                                new Detalleproduccion { InventariocomponentesId = 15 },
                                new Detalleproduccion { InventariocomponentesId = 22 },
                                new Detalleproduccion { InventariocomponentesId = 69 },
                                new Detalleproduccion { InventariocomponentesId = 87 },
                                new Detalleproduccion { InventariocomponentesId = 39 },
                                new Detalleproduccion { InventariocomponentesId = 21 },
                                new Detalleproduccion { InventariocomponentesId = 20 },
                                new Detalleproduccion { InventariocomponentesId = 109 },
                                new Detalleproduccion { InventariocomponentesId = 166 },
                                new Detalleproduccion { InventariocomponentesId = 30 },
                                new Detalleproduccion { InventariocomponentesId = 31 },
                            }
                        }
                    },
                    new Inventariolampara
                    {
                        Lote = "B3",
                        Cantidad = 50,
                        Precio = 0,
                        FechaCreacion = new DateOnly(2024, 6, 5),
                        RecetaId = 3,
                        Produccion = new Produccion
                        {
                            Fecha = new DateOnly(2024, 6, 5),
                            UsuarioId = "1",
                            Costo = 0,
                            Solicitudproduccion = new Solicitudproduccion { Descripcion = "Lamparas insuficientes", Cantidad = 50, RecetaId = 3, UsuarioId = "2", Estatus = 1 },
                            Detalleproduccions = new List<Detalleproduccion>
                            {
                                new Detalleproduccion { InventariocomponentesId = 58 },
                                new Detalleproduccion { InventariocomponentesId = 71 },
                                new Detalleproduccion { InventariocomponentesId = 16 },
                                new Detalleproduccion { InventariocomponentesId = 87 },
                                new Detalleproduccion { InventariocomponentesId = 94 },
                                new Detalleproduccion { InventariocomponentesId = 5 },
                                new Detalleproduccion { InventariocomponentesId = 33 },
                                new Detalleproduccion { InventariocomponentesId = 11 },
                                new Detalleproduccion { InventariocomponentesId = 18 },
                                new Detalleproduccion { InventariocomponentesId = 21 },
                                new Detalleproduccion { InventariocomponentesId = 20 },
                                new Detalleproduccion { InventariocomponentesId = 43 },
                                new Detalleproduccion { InventariocomponentesId = 166 },
                                new Detalleproduccion { InventariocomponentesId = 169 },
                                new Detalleproduccion { InventariocomponentesId = 31 },
                                new Detalleproduccion { InventariocomponentesId = 54 },
                            }
                        }
                    },
                    new Inventariolampara
                    {
                        Lote = "B4",
                        Cantidad = 50,
                        Precio = 0,
                        FechaCreacion = new DateOnly(2024, 6, 6),
                        RecetaId = 4,
                        Produccion = new Produccion
                        {
                            Fecha = new DateOnly(2024, 6, 6),
                            UsuarioId = "1",
                            Costo = 0,
                            Solicitudproduccion = new Solicitudproduccion { Descripcion = "Lamparas insuficientes", Cantidad = 50, RecetaId = 4, UsuarioId = "2", Estatus = 1 },
                            Detalleproduccions = new List<Detalleproduccion> {
                                new Detalleproduccion { InventariocomponentesId = 71 },
                                new Detalleproduccion { InventariocomponentesId = 116 },
                                new Detalleproduccion { InventariocomponentesId = 16 },
                                new Detalleproduccion { InventariocomponentesId = 47 },
                                new Detalleproduccion { InventariocomponentesId = 8 },
                                new Detalleproduccion { InventariocomponentesId = 94 },
                                new Detalleproduccion { InventariocomponentesId = 104 },
                                new Detalleproduccion { InventariocomponentesId = 33 },
                                new Detalleproduccion { InventariocomponentesId = 18 },
                                new Detalleproduccion { InventariocomponentesId = 39 },
                                new Detalleproduccion { InventariocomponentesId = 21 },
                                new Detalleproduccion { InventariocomponentesId = 25 },
                                new Detalleproduccion { InventariocomponentesId = 43 },
                                new Detalleproduccion { InventariocomponentesId = 169 },
                                new Detalleproduccion { InventariocomponentesId = 180 },
                                new Detalleproduccion { InventariocomponentesId = 54 },
                            }
                        }
                    },
                    new Inventariolampara
                    {
                        Lote = "B5",
                        Cantidad = 50,
                        Precio = 0,
                        FechaCreacion = new DateOnly(2024, 6, 7),
                        RecetaId = 5,
                        Produccion = new Produccion
                        {
                            Fecha = new DateOnly(2024, 6, 7),
                            UsuarioId = "3",
                            Costo = 0,
                            Solicitudproduccion = new Solicitudproduccion { Descripcion = "Lamparas insuficientes", Cantidad = 50, RecetaId = 5, UsuarioId = "4", Estatus = 1 },
                            Detalleproduccions = new List<Detalleproduccion>
                            {
                                new Detalleproduccion { InventariocomponentesId = 116 },
                                new Detalleproduccion { InventariocomponentesId = 120 },
                                new Detalleproduccion { InventariocomponentesId = 47 },
                                new Detalleproduccion { InventariocomponentesId = 22 },
                                new Detalleproduccion { InventariocomponentesId = 104 },
                                new Detalleproduccion { InventariocomponentesId = 39 },
                                new Detalleproduccion { InventariocomponentesId = 50 },
                                new Detalleproduccion { InventariocomponentesId = 25 },
                                new Detalleproduccion { InventariocomponentesId = 43 },
                                new Detalleproduccion { InventariocomponentesId = 46 },
                                new Detalleproduccion { InventariocomponentesId = 180 },
                                new Detalleproduccion { InventariocomponentesId = 186 },
                                new Detalleproduccion { InventariocomponentesId = 30 },
                                new Detalleproduccion { InventariocomponentesId = 28 },
                                new Detalleproduccion { InventariocomponentesId = 54 },
                                new Detalleproduccion { InventariocomponentesId = 84 },
                            }
                        }
                    },
                    //
                    new Inventariolampara
                    {
                        Lote = "C1",
                        Cantidad = 50,
                        Precio = 0,
                        FechaCreacion = new DateOnly(2024, 6, 24),
                        RecetaId = 1,
                        Produccion = new Produccion
                        {
                            Fecha = new DateOnly(2024, 6, 24),
                            UsuarioId = "2",
                            Costo = 0,
                            Solicitudproduccion = new Solicitudproduccion { Descripcion = "Lamparas insuficientes", Cantidad = 50, RecetaId = 1, UsuarioId = "1", Estatus = 1 },
                            Detalleproduccions = new List<Detalleproduccion>
                            {
                                new Detalleproduccion { InventariocomponentesId = 120 },
                                new Detalleproduccion { InventariocomponentesId = 47 },
                                new Detalleproduccion { InventariocomponentesId = 61 },
                                new Detalleproduccion { InventariocomponentesId = 22 },
                                new Detalleproduccion { InventariocomponentesId = 56 },
                                new Detalleproduccion { InventariocomponentesId = 104 },
                                new Detalleproduccion { InventariocomponentesId = 111 },
                                new Detalleproduccion { InventariocomponentesId = 50 },
                                new Detalleproduccion { InventariocomponentesId = 25 },
                                new Detalleproduccion { InventariocomponentesId = 23 },
                                new Detalleproduccion { InventariocomponentesId = 46 },
                                new Detalleproduccion { InventariocomponentesId = 186 },
                                new Detalleproduccion { InventariocomponentesId = 207 },
                                new Detalleproduccion { InventariocomponentesId = 28 },
                                new Detalleproduccion { InventariocomponentesId = 53 },
                                new Detalleproduccion { InventariocomponentesId = 84 },
                                new Detalleproduccion { InventariocomponentesId = 101 },
                            }
                        }
                    },
                    new Inventariolampara
                    {
                        Lote = "C2",
                        Cantidad = 50,
                        Precio = 0,
                        FechaCreacion = new DateOnly(2024, 6, 25),
                        RecetaId = 2,
                        Produccion = new Produccion
                        {
                            Fecha = new DateOnly(2024, 6, 25),
                            UsuarioId = "4",
                            Costo = 0,
                            Solicitudproduccion = new Solicitudproduccion { Descripcion = "Lamparas insuficientes", Cantidad = 50, RecetaId = 2, UsuarioId = "5", Estatus = 1 },
                            Detalleproduccions = new List<Detalleproduccion>
                            {
                                new Detalleproduccion { InventariocomponentesId = 120 },
                                new Detalleproduccion { InventariocomponentesId = 61 },
                                new Detalleproduccion { InventariocomponentesId = 61 },
                                new Detalleproduccion { InventariocomponentesId = 56 },
                                new Detalleproduccion { InventariocomponentesId = 111 },
                                new Detalleproduccion { InventariocomponentesId = 117 },
                                new Detalleproduccion { InventariocomponentesId = 50 },
                                new Detalleproduccion { InventariocomponentesId = 23 },
                                new Detalleproduccion { InventariocomponentesId = 46 },
                                new Detalleproduccion { InventariocomponentesId = 207 },
                                new Detalleproduccion { InventariocomponentesId = 216 },
                                new Detalleproduccion { InventariocomponentesId = 53 },
                                new Detalleproduccion { InventariocomponentesId = 101 },
                            }
                        }
                    }
                );
                context.SaveChanges();

                
            }

            if (context.Inventariolamparas.Any())
            {// Registros de costos de producción y precios de ventas para lámparas
                var inventariosLampara = context.Inventariolamparas.Include(il => il.Produccion).Include(il => il.Produccion.Solicitudproduccion).Include(il => il.Produccion.Detalleproduccions).Include(il => il.Receta).Include(il => il.Receta.Componentesreceta).ToList();
                int[] idsDes = [1, 2, 3, 4, 5, 6, 7, 8, 134, 9, 10, 11, 12, 61, 13, 14, 15, 56, 16, 17, 19, 20, 21, 22, 24, 25, 26, 117, 27, 33, 28, 18, 30, 31, 37, 50, 39, 40, 43, 44, 23, 47, 52, 54, 58, 46, 69, 71, 84, 86, 87, 90, 94, 104, 109, 216, 111, 116, 120, 53, 166, 169, 180, 186, 207, 101,];

                inventariosLampara.ForEach(il => {
                    double? costoProduccion = 0;
                    double? cantidadProduccion = il.Produccion.Solicitudproduccion.Cantidad;
                    var n = il.Produccion.Detalleproduccions.ToList();

                    n.ForEach(dp => {
                        var inventario = context.Inventariocomponentes.Include(ic => ic.Detallecompra).Where(ic => ic.Id == dp.InventariocomponentesId).First();
                        double? costoComponente = inventario.Detallecompra.Costo / inventario.Detallecompra.Cantidad;
                        double? cantidadComponente = il.Receta.Componentesreceta.Where(cr => cr.ComponentesId == dp.Inventariocomponentes.ComponentesId).First().Cantidad;

                        costoProduccion = costoProduccion + (cantidadProduccion * (costoComponente * cantidadComponente));
                    });

                    costoProduccion = costoProduccion / cantidadProduccion;

                    context.Produccions.Where(p => p.Id == il.ProduccionId).First().Costo = costoProduccion;

                    var costosProduccionObj = context.Produccions.Include(p => p.Solicitudproduccion).Include(p => p.Solicitudproduccion).Where(p => p.Solicitudproduccion.RecetaId == il.RecetaId).Where(p => p.Id <= il.ProduccionId).ToList();
                    double? costosProduccion = 0;

                    costosProduccionObj.ForEach(prod => costosProduccion += prod.Costo);
                    double? precioVentaPrev = costosProduccion / costosProduccionObj.Count();
                    double? precioVenta = precioVentaPrev + (precioVentaPrev * 0.2);

                    context.Inventariolamparas.Where(i => i.Id == il.Id).First().Precio = precioVenta;

                    context.SaveChanges();
                });

                for (int i = 0; i < idsDes.Length; i++)
                {
                    context.Inventariocomponentes.Where(ic => ic.Id == idsDes[i]).First().Cantidad = 0;
                };

                context.SaveChanges();

            }

            if (!context.Solicitudproduccions.Any())
            {
                context.Solicitudproduccions.AddRange(
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 30,
                        Estatus = 0,
                        RecetaId = 2,
                        UsuarioId = "10"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 10,
                        Estatus = 0,
                        RecetaId = 3,
                        UsuarioId = "18"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 10,
                        Estatus = 0,
                        RecetaId = 2,
                        UsuarioId = "19"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 30,
                        Estatus = 0,
                        RecetaId = 3,
                        UsuarioId = "21"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 20,
                        Estatus = 0,
                        RecetaId = 3,
                        UsuarioId = "22"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 30,
                        Estatus = 0,
                        RecetaId = 4,
                        UsuarioId = "25"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 20,
                        Estatus = 0,
                        RecetaId = 5,
                        UsuarioId = "26"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 40,
                        Estatus = 0,
                        RecetaId = 1,
                        UsuarioId = "27"
                    },

                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 40,
                        Estatus = 0,
                        RecetaId = 3,
                        UsuarioId = "10"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 10,
                        Estatus = 0,
                        RecetaId = 4,
                        UsuarioId = "18"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 30,
                        Estatus = 0,
                        RecetaId = 4,
                        UsuarioId = "19"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 10,
                        Estatus = 0,
                        RecetaId = 1,
                        UsuarioId = "21"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 20,
                        Estatus = 0,
                        RecetaId = 1,
                        UsuarioId = "22"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 30,
                        Estatus = 0,
                        RecetaId = 5,
                        UsuarioId = "25"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 30,
                        Estatus = 0,
                        RecetaId = 5,
                        UsuarioId = "26"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 20,
                        Estatus = 0,
                        RecetaId = 2,
                        UsuarioId = "27"
                    },

                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 40,
                        Estatus = 0,
                        RecetaId = 5,
                        UsuarioId = "10"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 30,
                        Estatus = 0,
                        RecetaId = 3,
                        UsuarioId = "18"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 40,
                        Estatus = 0,
                        RecetaId = 2,
                        UsuarioId = "19"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 40,
                        Estatus = 0,
                        RecetaId = 1,
                        UsuarioId = "21"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 10,
                        Estatus = 0,
                        RecetaId = 5,
                        UsuarioId = "22"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 40,
                        Estatus = 0,
                        RecetaId = 5,
                        UsuarioId = "25"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 40,
                        Estatus = 0,
                        RecetaId = 3,
                        UsuarioId = "26"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 40,
                        Estatus = 0,
                        RecetaId = 3,
                        UsuarioId = "27"
                    },


                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 40,
                        Estatus = 0,
                        RecetaId = 3,
                        UsuarioId = "10"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 30,
                        Estatus = 0,
                        RecetaId = 2,
                        UsuarioId = "18"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 40,
                        Estatus = 0,
                        RecetaId = 1,
                        UsuarioId = "19"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 10,
                        Estatus = 0,
                        RecetaId = 4,
                        UsuarioId = "21"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 30,
                        Estatus = 0,
                        RecetaId = 1,
                        UsuarioId = "22"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 40,
                        Estatus = 0,
                        RecetaId = 4,
                        UsuarioId = "25"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 40,
                        Estatus = 0,
                        RecetaId = 5,
                        UsuarioId = "26"
                    },
                    new Solicitudproduccion
                    {
                        Descripcion = "Quiero constuir",
                        Cantidad = 40,
                        Estatus = 0,
                        RecetaId = 4,
                        UsuarioId = "27"
                    }
                );

                context.SaveChanges();
            }

            if (!context.Carritos.Any())
            {
                context.Carritos.AddRange(
                    new Carrito { Fecha = new DateOnly(2024, 05, 10), Cantidad = 1, RecetaId = 1, UsuarioId = "28" },
                    new Carrito { Fecha = new DateOnly(2024, 05, 11), Cantidad = 8, RecetaId = 2, UsuarioId = "29" },
                    new Carrito { Fecha = new DateOnly(2024, 05, 12), Cantidad = 10, RecetaId = 3, UsuarioId = "30" },
                    new Carrito { Fecha = new DateOnly(2024, 05, 13), Cantidad = 1, RecetaId = 4, UsuarioId = "31" },
                    new Carrito { Fecha = new DateOnly(2024, 05, 14), Cantidad = 8, RecetaId = 5, UsuarioId = "33" },
                    new Carrito { Fecha = new DateOnly(2024, 05, 15), Cantidad = 8, RecetaId = 1, UsuarioId = "34" },
                    new Carrito { Fecha = new DateOnly(2024, 05, 16), Cantidad = 3, RecetaId = 2, UsuarioId = "35" },
                    new Carrito { Fecha = new DateOnly(2024, 05, 17), Cantidad = 9, RecetaId = 3, UsuarioId = "36" },
                    new Carrito { Fecha = new DateOnly(2024, 05, 18), Cantidad = 3, RecetaId = 4, UsuarioId = "37" },
                    new Carrito { Fecha = new DateOnly(2024, 05, 19), Cantidad = 8, RecetaId = 5, UsuarioId = "6" },
                    new Carrito { Fecha = new DateOnly(2024, 05, 20), Cantidad = 4, RecetaId = 1, UsuarioId = "8" },
                    new Carrito { Fecha = new DateOnly(2024, 05, 21), Cantidad = 5, RecetaId = 2, UsuarioId = "9" },

                    new Carrito { Fecha = new DateOnly(2024, 05, 21), Cantidad = 3, RecetaId = 1, UsuarioId = "28" },
                    new Carrito { Fecha = new DateOnly(2024, 05, 22), Cantidad = 2, RecetaId = 2, UsuarioId = "29" },
                    new Carrito { Fecha = new DateOnly(2024, 05, 23), Cantidad = 2, RecetaId = 3, UsuarioId = "30" },
                    new Carrito { Fecha = new DateOnly(2024, 05, 24), Cantidad = 8, RecetaId = 4, UsuarioId = "31" },
                    new Carrito { Fecha = new DateOnly(2024, 05, 25), Cantidad = 2, RecetaId = 5, UsuarioId = "33" },
                    new Carrito { Fecha = new DateOnly(2024, 05, 26), Cantidad = 2, RecetaId = 1, UsuarioId = "34" },
                    new Carrito { Fecha = new DateOnly(2024, 06, 10), Cantidad = 8, RecetaId = 2, UsuarioId = "35" },
                    new Carrito { Fecha = new DateOnly(2024, 06, 11), Cantidad = 6, RecetaId = 3, UsuarioId = "36" },
                    new Carrito { Fecha = new DateOnly(2024, 06, 12), Cantidad = 10, RecetaId = 4, UsuarioId = "37" },
                    new Carrito { Fecha = new DateOnly(2024, 06, 13), Cantidad = 6, RecetaId = 5, UsuarioId = "6" },
                    new Carrito { Fecha = new DateOnly(2024, 06, 14), Cantidad = 5, RecetaId = 1, UsuarioId = "8" },
                    new Carrito { Fecha = new DateOnly(2024, 06, 15), Cantidad = 9, RecetaId = 2, UsuarioId = "9" },

                    new Carrito { Fecha = new DateOnly(2024, 06, 16), Cantidad = 6, RecetaId = 3, UsuarioId = "28" },
                    new Carrito { Fecha = new DateOnly(2024, 06, 17), Cantidad = 10, RecetaId = 4, UsuarioId = "29" },
                    new Carrito { Fecha = new DateOnly(2024, 06, 18), Cantidad = 8, RecetaId = 5, UsuarioId = "30" },
                    new Carrito { Fecha = new DateOnly(2024, 06, 19), Cantidad = 4, RecetaId = 1, UsuarioId = "31" },
                    new Carrito { Fecha = new DateOnly(2024, 06, 20), Cantidad = 10, RecetaId = 2, UsuarioId = "33" },
                    new Carrito { Fecha = new DateOnly(2024, 06, 21), Cantidad = 6, RecetaId = 3, UsuarioId = "34" },
                    new Carrito { Fecha = new DateOnly(2024, 06, 22), Cantidad = 10, RecetaId = 4, UsuarioId = "35" },
                    new Carrito { Fecha = new DateOnly(2024, 06, 23), Cantidad = 5, RecetaId = 5, UsuarioId = "36" },
                    new Carrito { Fecha = new DateOnly(2024, 06, 24), Cantidad = 10, RecetaId = 1, UsuarioId = "37" },
                    new Carrito { Fecha = new DateOnly(2024, 06, 25), Cantidad = 8, RecetaId = 2, UsuarioId = "6" },
                    new Carrito { Fecha = new DateOnly(2024, 06, 26), Cantidad = 8, RecetaId = 3, UsuarioId = "8" },
                    new Carrito { Fecha = new DateOnly(2024, 06, 27), Cantidad = 9, RecetaId = 4, UsuarioId = "9" },

                    new Carrito { Fecha = new DateOnly(2024, 07, 8), Cantidad = 3, RecetaId = 5, UsuarioId = "28" },
                    new Carrito { Fecha = new DateOnly(2024, 07, 9), Cantidad = 8, RecetaId = 1, UsuarioId = "29" },
                    new Carrito { Fecha = new DateOnly(2024, 07, 10), Cantidad = 2, RecetaId = 2, UsuarioId = "30" },
                    new Carrito { Fecha = new DateOnly(2024, 07, 12), Cantidad = 10, RecetaId = 3, UsuarioId = "31" },
                    new Carrito { Fecha = new DateOnly(2024, 07, 14), Cantidad = 6, RecetaId = 4, UsuarioId = "33" },
                    new Carrito { Fecha = new DateOnly(2024, 07, 15), Cantidad = 2, RecetaId = 5, UsuarioId = "34" },
                    new Carrito { Fecha = new DateOnly(2024, 07, 16), Cantidad = 2, RecetaId = 1, UsuarioId = "35" },
                    new Carrito { Fecha = new DateOnly(2024, 07, 17), Cantidad = 6, RecetaId = 2, UsuarioId = "36" },
                    new Carrito { Fecha = new DateOnly(2024, 07, 18), Cantidad = 6, RecetaId = 3, UsuarioId = "37" },
                    new Carrito { Fecha = new DateOnly(2024, 07, 19), Cantidad = 6, RecetaId = 4, UsuarioId = "6" },
                    new Carrito { Fecha = new DateOnly(2024, 07, 20), Cantidad = 7, RecetaId = 5, UsuarioId = "8" },
                    new Carrito { Fecha = new DateOnly(2024, 07, 21), Cantidad = 7, RecetaId = 1, UsuarioId = "9" }
                );

                context.SaveChanges();
            }

            if (!context.Venta.Any())
            {
                context.Venta.AddRange(
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 11),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "2",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 4, InventariolamparaId = 1, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 12),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "1",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 5, InventariolamparaId = 2, PrecioUnitario = 1 },
                            new Detalleventum { Cantidad = 5, InventariolamparaId = 4, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 13),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "2",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 4, InventariolamparaId = 3, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 14),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "5",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 5, PrecioUnitario = 1 },
                            new Detalleventum { Cantidad = 1, InventariolamparaId = 2, PrecioUnitario = 1 },
                            new Detalleventum { Cantidad = 5, InventariolamparaId = 5, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 15),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "1",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 1, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 16),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "1",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 1, InventariolamparaId = 5, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 17),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "5",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 4, InventariolamparaId = 3, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 18),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "1",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 4, InventariolamparaId = 3, PrecioUnitario = 1 },
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 4, PrecioUnitario = 1 },
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 2, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 19),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "1",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 4, InventariolamparaId = 3, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 20),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "5",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 3, InventariolamparaId = 4, PrecioUnitario = 1 },
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 4, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 21),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "4",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 4, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 22),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "5",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 1, InventariolamparaId = 1, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 23),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "3",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 3, InventariolamparaId = 3, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 24),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "1",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 3, InventariolamparaId = 3, PrecioUnitario = 1 },
                            new Detalleventum { Cantidad = 1, InventariolamparaId = 2, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 25),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "3",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 3, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 26),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "4",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 3, InventariolamparaId = 1, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 27),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "5",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 3, InventariolamparaId = 4, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 28),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "4",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 2, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 29),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "3",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 3, PrecioUnitario = 1 },
                            new Detalleventum { Cantidad = 1, InventariolamparaId = 3, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 30),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "1",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 3, InventariolamparaId = 3, PrecioUnitario = 1 },
                        }
                    },


                    new Ventum
                    {
                        Fecha = new DateTime(2024, 5, 31),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "5",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 4, InventariolamparaId = 1, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 1),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "3",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 1, InventariolamparaId = 3, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 2),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "2",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 4, InventariolamparaId = 4, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 3),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "2",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 3, InventariolamparaId = 1, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 4),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "1",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 1, InventariolamparaId = 2, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 5),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "4",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 3, InventariolamparaId = 5, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 6),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "5",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 3, InventariolamparaId = 3, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 7),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "3",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 5, InventariolamparaId = 2, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 8),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "5",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 5, InventariolamparaId = 4, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 9),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "2",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 3, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 10),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "4",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 5, InventariolamparaId = 1, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 11),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "3",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 1, InventariolamparaId = 4, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 12),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "2",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 3, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 13),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "3",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 4, InventariolamparaId = 2, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 14),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "4",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 4, InventariolamparaId = 4, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 15),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "2",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 4, InventariolamparaId = 4, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 16),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "5",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 2, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 17),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "5",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 4, InventariolamparaId = 5, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 18),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "1",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 5, InventariolamparaId = 2, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 19),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "2",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 3, InventariolamparaId = 3, PrecioUnitario = 1 },
                        }
                    },



                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 20),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "4",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 4, InventariolamparaId = 2, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 21),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "5",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 3, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 22),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "3",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 4, InventariolamparaId = 5, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 23),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "2",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 3, InventariolamparaId = 2, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 24),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "4",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 1, InventariolamparaId = 2, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 25),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "3",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 1, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 26),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "4",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 1, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 27),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "3",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 5, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 28),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "3",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 4, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 29),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "3",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 4, InventariolamparaId = 1, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 6, 30),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "3",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 2, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 7, 1),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "5",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 5, InventariolamparaId = 2, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 7, 2),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "1",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 3, InventariolamparaId = 4, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 7, 3),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "4",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 4, InventariolamparaId = 1, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 7, 4),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "4",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 4, InventariolamparaId = 5, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 7, 5),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "1",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 5, InventariolamparaId = 2, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 7, 6),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "3",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 5, InventariolamparaId = 4, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 7, 7),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "3",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 2, PrecioUnitario = 1 },
                            new Detalleventum { Cantidad = 5, InventariolamparaId = 7, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 7, 8),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "1",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 5, InventariolamparaId = 4, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 7, 9),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "5",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 3, InventariolamparaId = 1, PrecioUnitario = 1 },
                        }
                    },



                    new Ventum
                    {
                        Fecha = new DateTime(2024, 7, 10),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "4",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 5, InventariolamparaId = 7, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 7, 11),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "5",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 5, InventariolamparaId = 3, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 7, 12),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "1",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 1, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 7, 15),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "3",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 7, PrecioUnitario = 1 },
                        }
                    },
                    new Ventum
                    {
                        Fecha = new DateTime(2024, 7, 16),
                        Descuento = 0,
                        Folio = "V",
                        UsuarioId = "4",
                        Detalleventa = new List<Detalleventum> {
                            new Detalleventum { Cantidad = 2, InventariolamparaId = 1, PrecioUnitario = 1 },
                        }
                    }
                );

                context.SaveChanges();
            }

            if (context.Venta.Any())
            {
                var detallesVenta = context.Detalleventa.Include(d => d.Inventariolampara).ToList();
                detallesVenta.ForEach(dv =>
                {
                    context.Detalleventa.Where(d => d.Id == dv.Id).First().PrecioUnitario = dv.Inventariolampara.Precio * dv.Cantidad;
                    context.Inventariolamparas.Where(il => il.Id == dv.InventariolamparaId).First().Cantidad -= dv.Cantidad;
                });
                context.SaveChanges();
            }

            // Mermas de inventarios
            if (!context.Mermacomponentes.Any())
            {
                context.Mermacomponentes.AddRange(
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 5), UsuarioId = "4", InventariocomponentesId = 1 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 5), UsuarioId = "4", InventariocomponentesId = 2 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 5), UsuarioId = "3", InventariocomponentesId = 3 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 5), UsuarioId = "2", InventariocomponentesId = 4 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 5), UsuarioId = "4", InventariocomponentesId = 5 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 6), UsuarioId = "1", InventariocomponentesId = 6 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 6), UsuarioId = "5", InventariocomponentesId = 7 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 6), UsuarioId = "3", InventariocomponentesId = 8 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 6), UsuarioId = "4", InventariocomponentesId = 9 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 6), UsuarioId = "2", InventariocomponentesId = 10 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 7), UsuarioId = "1", InventariocomponentesId = 11 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 7), UsuarioId = "2", InventariocomponentesId = 12 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 7), UsuarioId = "3", InventariocomponentesId = 13 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 7), UsuarioId = "2", InventariocomponentesId = 14 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 7), UsuarioId = "5", InventariocomponentesId = 15 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 8), UsuarioId = "4", InventariocomponentesId = 16 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 8), UsuarioId = "1", InventariocomponentesId = 17 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 8), UsuarioId = "4", InventariocomponentesId = 18 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 8), UsuarioId = "5", InventariocomponentesId = 19 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 8), UsuarioId = "1", InventariocomponentesId = 20 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 9), UsuarioId = "1", InventariocomponentesId = 21 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 9), UsuarioId = "3", InventariocomponentesId = 22 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 9), UsuarioId = "2", InventariocomponentesId = 23 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 9), UsuarioId = "2", InventariocomponentesId = 24 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 9), UsuarioId = "3", InventariocomponentesId = 25 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 10), UsuarioId = "5", InventariocomponentesId = 26 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 10), UsuarioId = "1", InventariocomponentesId = 27 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 10), UsuarioId = "5", InventariocomponentesId = 28 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 10), UsuarioId = "3", InventariocomponentesId = 30 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 11), UsuarioId = "2", InventariocomponentesId = 31 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 11), UsuarioId = "3", InventariocomponentesId = 33 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 12), UsuarioId = "2", InventariocomponentesId = 37 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 12), UsuarioId = "3", InventariocomponentesId = 39 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 12), UsuarioId = "5", InventariocomponentesId = 40 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 13), UsuarioId = "5", InventariocomponentesId = 43 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 13), UsuarioId = "2", InventariocomponentesId = 44 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 14), UsuarioId = "2", InventariocomponentesId = 46 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 14), UsuarioId = "3", InventariocomponentesId = 47 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 14), UsuarioId = "3", InventariocomponentesId = 50 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 15), UsuarioId = "2", InventariocomponentesId = 52 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 15), UsuarioId = "2", InventariocomponentesId = 53 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 15), UsuarioId = "2", InventariocomponentesId = 54 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 16), UsuarioId = "2", InventariocomponentesId = 56 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 16), UsuarioId = "5", InventariocomponentesId = 58 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 17), UsuarioId = "4", InventariocomponentesId = 61 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 18), UsuarioId = "3", InventariocomponentesId = 69 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 19), UsuarioId = "1", InventariocomponentesId = 71 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 21), UsuarioId = "4", InventariocomponentesId = 84 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 22), UsuarioId = "4", InventariocomponentesId = 86 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 22), UsuarioId = "2", InventariocomponentesId = 87 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 22), UsuarioId = "4", InventariocomponentesId = 90 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 23), UsuarioId = "4", InventariocomponentesId = 94 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 25), UsuarioId = "4", InventariocomponentesId = 101 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 25), UsuarioId = "3", InventariocomponentesId = 104 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 26), UsuarioId = "5", InventariocomponentesId = 109 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 27), UsuarioId = "4", InventariocomponentesId = 111 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 28), UsuarioId = "1", InventariocomponentesId = 116 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 28), UsuarioId = "3", InventariocomponentesId = 117 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 28), UsuarioId = "1", InventariocomponentesId = 120 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 5, 31), UsuarioId = "2", InventariocomponentesId = 134 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 6, 7), UsuarioId = "5", InventariocomponentesId = 166 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 6, 7), UsuarioId = "5", InventariocomponentesId = 169 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 6, 9), UsuarioId = "1", InventariocomponentesId = 180 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 6, 11), UsuarioId = "4", InventariocomponentesId = 186 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 6, 15), UsuarioId = "3", InventariocomponentesId = 207 },
                    new Mermacomponente { Cantidad = 2, Descripcion = "Componente descompuesto", Fecha = new DateOnly(2024, 6, 17), UsuarioId = "2", InventariocomponentesId = 216 }
                );

                context.SaveChanges();
            }
            
            if (!context.Mermalamparas.Any())
            {
                context.Mermalamparas.AddRange(
                    new Mermalampara { Cantidad = 2, Descripcion = "No prende", Fecha = new DateOnly(2024, 5, 14), UsuarioId = "5", InventariolamparaId = 1 },
                    new Mermalampara { Cantidad = 1, Descripcion = "Quema los componentes", Fecha = new DateOnly(2024, 5, 15), UsuarioId = "2", InventariolamparaId = 3 },
                    new Mermalampara { Cantidad = 3, Descripcion = "Prende mucho", Fecha = new DateOnly(2024, 5, 22), UsuarioId = "2", InventariolamparaId = 5 },
                    new Mermalampara { Cantidad = 4, Descripcion = "hace ruido", Fecha = new DateOnly(2024, 6, 7), UsuarioId = "1", InventariolamparaId = 7 }
                );

                context.SaveChanges();
            }
        }
    }
}