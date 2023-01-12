using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;

namespace PruebaTecnica.Controllers
{
    [ApiController]
    [Route("usuario")]
    public class UsuarioControllers : ControllerBase
    {
        [HttpGet]
        [Route("credenciales")]
        public dynamic ValidarCredenciales(string user, string password)
        {
            List<Usuario> usuarios = new List<Usuario>();
            List<Usuario> User = new List<Usuario>();

            if (user != string.Empty && password != string.Empty)
            {
                usuarios = new List<Usuario>
                {
                    new Usuario
                    {
                        Id = 1,
                        usuario = "User1",
                        password = "Clave1"
                    },
                    new Usuario
                    {
                        Id = 2,
                        usuario = "User2",
                        password = "Clave2"
                    }
                };

                User = usuarios.Where(x => x.usuario == user && x.password == password).ToList();
            }

            return User;
        }

        [HttpGet]
        [Route("roles")]
        public dynamic ObtenerRolesUsuario(string user)
        {
            List<RolesUser> rolesUsers = new List<RolesUser>
            {
                new RolesUser
                {
                    Id = 1,
                    usuario = "User1",
                    rol = "Principal"
                },
                new RolesUser
                {
                    Id = 2,
                    usuario = "User2",
                    rol = "Delegado"
                }
            };

            return rolesUsers.Where(x => x.usuario == user).ToList();
        }

        //[HttpPost]
        //[Route("guardar")]
        //public dynamic guardar(Usuario user)
        //{
        //    string token = Request.Headers.Where(x => x.Key == "Authorization").FirstOrDefault().Value;
        //}
    }
}
