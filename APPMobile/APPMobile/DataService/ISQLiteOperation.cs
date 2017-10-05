using AppTesteMVVM1.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTesteMVVM1.DataService
{
    public interface ISQLiteOperation
    {
        void Salvar(Pessoa pessoa);
        void Excluir(Pessoa pessoa);
        void Atualizar(Pessoa pessoa);
        IList<Pessoa> Select();
    }
}
