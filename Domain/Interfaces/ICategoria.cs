using Domain.Entites;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public  interface ICategoria
    {
        public Task<bool> CriarCategoria(Categoria dto);
    }
}
