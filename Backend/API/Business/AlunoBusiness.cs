using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;

namespace API.Business
{
    public class AlunoBusiness
    {
        public void Inserir(Models.TbAluno aluno)
        {
            if(aluno.NmAluno.Trim() == null)
                throw new ArgumentException("O campo nome é obrigatório");
            if(aluno.DsEmail.Contains("@")|| aluno.DsEmail.Trim()== null )
                throw new ArgumentException("Email inválido");
        }
    }
}