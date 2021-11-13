using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Curso.Models
{
    public class ValidaViewModelOutput
    {
        public IEnumerable<string> Erros { get; set; }

        public ValidaViewModelOutput(IEnumerable<string> erros)
        {
            Erros = erros;
        }
    }
}
