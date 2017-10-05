using AppTesteMVVM1.Entidade;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTesteMVVM1.DataService
{
    public class PessoaDataService : ISQLiteOperation 
    {
        private SQLiteConnection _connection;

        public PessoaDataService()
        {
            _connection = DependencyService.Get<ISQLite>().GetConnection();
            _connection.CreateTable<Pessoa>();
        }

        public void Atualizar(Pessoa pessoa)
        {
            _connection.Update(pessoa);
        }

        public void Excluir(Pessoa pessoa)
        {
            _connection.Delete(pessoa);
        }

        public void Salvar(Pessoa pessoa)
        {
            _connection.Insert(pessoa);
        }

        public IList<Pessoa> Select()
        {
           return _connection.Table<Pessoa>().ToList();
        }
    }
}
