namespace VeT_Animais_Domésticos.Classes
{
    internal class AtoItem
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public AtoItem(int id, string nome)
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
