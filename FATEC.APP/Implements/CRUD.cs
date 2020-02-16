using FATEC.APP.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FATEC.APP.Implements
{
    public class CRUD
    {
        public bool Cadastrar(Pessoa pessoa)
        {
            //Variavel de retorno
            bool insert = false;

            //Se tiver erro retorno false
            return insert;

            //Sem erro retorno true
            insert = true;
            return insert;
        }

        public Pessoa Pesquisar(int id)
        {

        }

        public List<Pessoa> Listar()
        {

        }

        public bool Atualizar(Pessoa pessoa)
        {
            //Variavel de retorno
            bool insert = false;

            //Se tiver erro retorno false
            return false;

            //Sem erro retorno true
            insert = true;
            return insert;
        }

        public bool Excluir(int id)
        {
            // Variavel de retorno
            bool insert = false;
            // Se tiver erro retorno false
            return false;
            //Sem erro retorno true
            insert = true;
            return true;
        }
    }
}
