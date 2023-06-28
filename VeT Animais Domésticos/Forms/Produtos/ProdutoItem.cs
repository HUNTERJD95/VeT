namespace VeT_Animais_Domésticos.Forms.Produtos
{
    internal class ProdutoItem
    {
        public int codigoProduto { get; set; }
        public string descricaoProduto { get; set; }
        public int quantidadeArmazem { get; set; }


        public ProdutoItem(int codigoProduto, string descricaoProduto, int quantidadeArmazem)
        {
            this.codigoProduto = codigoProduto;
            this.descricaoProduto = descricaoProduto;
            this.quantidadeArmazem = quantidadeArmazem;
        }

        public override string ToString()
        {
            return descricaoProduto;
        }
    }
}