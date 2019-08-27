using System;
using System.Globalization;

namespace exemplos_produto
{
    class Produto
    {
        private string _nome;
        public double Preco { get;private set; }
        public int Quantidade { get;private set; }
        public Fornecedor _fornecedor { get; private set; }

        public Produto(string nome, double preco, int quantidadeEmEstoque, Fornecedor fornecedor)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidadeEmEstoque;
            _fornecedor = fornecedor;
        }
        
        public Produto(string nome, double preco,Fornecedor fornecedor)
        {
            this._nome = nome;
            this.Preco = preco;
            this.Quantidade = 0;
            this._fornecedor = fornecedor;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


        public double valorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void realizarEntrada(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void realizarSaida(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + Quantidade + ",\n Fornecedor: " + _fornecedor;
        }
    }
}
