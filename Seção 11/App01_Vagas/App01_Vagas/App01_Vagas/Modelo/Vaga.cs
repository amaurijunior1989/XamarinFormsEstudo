using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App01_Vagas.Modelo
{
    [Table("Vaga")]
    public class Vaga
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string NomeVaga { get; set; }
        public string Empresa { get; set; }
        public short QuantidadeVaga { get; set; }
        public string Cidade { get; set; }
        public double Salario { get; set; }
        public string Descricao { get; set; }
        public string TipoContratacao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
