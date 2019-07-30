using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Linq;
using App01_Vagas.Modelo;
using Xamarin.Forms;

namespace App01_Vagas.Banco
{
    public class DataBase
    {
        private SQLiteConnection _conexao;
        
        public DataBase()
        {
            var Dep = DependencyService.Get<ICaminho>();
            string caminho = Dep.GetCaminho("database.sqlite");

            _conexao = new SQLiteConnection(caminho);
            _conexao.CreateTable<Vaga>();

        }

        public List<Vaga> Consultar()
        {
            return _conexao.Table<Vaga>().ToList();
        }

        public List<Vaga> Consultar(string palavra)
        {
            return _conexao.Table<Vaga>().Where(a => a.NomeVaga.ToLower().Contains(palavra.ToLower())).ToList();
        }

        public Vaga ConsultarID(int id)
        {
           return _conexao.Table<Vaga>().Where(a => a.ID == id).FirstOrDefault(); ;
        }

        public void Cadastro(Vaga vaga)
        {
            _conexao.Insert(vaga);
        }

        public void Atualizacao (Vaga vaga)
        {
            _conexao.Update(vaga);
        }
        public void Exclusao(Vaga vaga)
        {
            _conexao.Delete(vaga);
        }


    }
}
