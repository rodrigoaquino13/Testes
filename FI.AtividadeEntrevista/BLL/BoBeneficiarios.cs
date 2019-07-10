using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.BLL
{
    public class BoBeneficarios
    {
        /// <summary>
        /// Inclui um novo cliente
        /// </summary>
        /// <param name="cliente">Objeto de cliente</param>
        public long Incluir(DML.Beneficiarios beneficiarios)
        {
            DAL.DaoBeneficiarios cli = new DAL.DaoBeneficiarios();
           
            return cli.Incluir(beneficiarios);

        }

        /// <summary>
        /// Altera um beneficiario
        /// </summary>
        /// <param name="beneficiarios">Objeto de beneficiarios</param>
        public void Alterar(DML.Beneficiarios beneficiarios)
        {
            DAL.DaoBeneficiarios cli = new DAL.DaoBeneficiarios();
            cli.Alterar(beneficiarios);
        }

        /// <summary>
        /// Consulta o beneficiario pelo id
        /// </summary>
        /// <param name="id">id do cliente</param>
        /// <returns></returns>
        public DML.Beneficiarios Consultar(long id)
        {
            DAL.DaoBeneficiarios cli = new DAL.DaoBeneficiarios();
            return cli.Consultar(id);
        }

        /// <summary>
        /// Excluir o beneficiario pelo id
        /// </summary>
        /// <param name="id">id do beneficiario</param>
        /// <returns></returns>
        public void Excluir(long id)
        {
            DAL.DaoBeneficiarios cli = new DAL.DaoBeneficiarios();
            cli.Excluir(id);
        }

        /// <summary>
        /// Lista os beneficiarios
        /// </summary>
        public List<DML.Beneficiarios> Listar()
        {
            DAL.DaoBeneficiarios cli = new DAL.DaoBeneficiarios();
            return cli.Listar();
        }

        /// <summary>
        /// Lista os beneficiarios
        /// </summary>
        public List<DML.Beneficiarios> Pesquisa(int iniciarEm, int quantidade, string campoOrdenacao, bool crescente, out int qtd)
        {
            DAL.DaoBeneficiarios cli = new DAL.DaoBeneficiarios();
            return cli.Pesquisa(iniciarEm,  quantidade, campoOrdenacao, crescente, out qtd);
        }
    }
}
