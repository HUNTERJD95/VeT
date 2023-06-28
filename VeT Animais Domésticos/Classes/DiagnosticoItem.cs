namespace VeT_Animais_Domésticos.Classes
{
    internal class DiagnosticoItem
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public DiagnosticoItem(int Id, string Nome)
        {
            this.Id = Id;
            this.Nome = Nome;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}