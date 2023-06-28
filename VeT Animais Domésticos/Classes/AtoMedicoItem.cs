namespace VeT_Animais_Domésticos.Classes
{
    internal class AtoMedicoItem : AtoItem
    {
        public AtoMedicoItem(int id, string nome) : base(id, nome)
        {
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}