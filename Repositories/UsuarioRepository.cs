using Exo.WebApi.Context;
using Exo.WebApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace Exo.WebApi.Repositories{
    public class UsuarioRepository{
        private readonly ExoContext _context;
        public UsuarioRepository(ExoContext context)
        {
            _context = context;
        }
        public Usuario Login(string Email, string Senha)
        {
            return _context.Usuarios.FirstOrDefault
            (u => u.Email == Email && u.Senha == Senha);
        }

        public List<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }

        public void Cadastrar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

        }

        public Usuario BuscarPorId(int id)
        {
            return _context.Usuarios.Find(id);
        }

        public void Atualizar(int id, Usuario usuario)
        {
            Usuario usuariobuscado = _context.Usuarios.Find(id);

            if(usuariobuscado != null){
                usuariobuscado.Email = usuario.Email;
                usuariobuscado.Senha = usuario.Senha;
            }
            _context.Usuarios.Update(usuariobuscado);
            _context.SaveChanges();
        }
        public void Deletar(int id)
        {
            Usuario usuariobuscado = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(usuariobuscado);
            _context.SaveChanges();
        }


    }
}