namespace VeT_Animais_Domésticos.Forms.Colaboradores
{
    internal class ColaboradorItem
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ColaboradorItem(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}