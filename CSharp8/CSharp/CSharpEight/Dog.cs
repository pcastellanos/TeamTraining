namespace CSharpEight
{
    internal class Dog : IAnimal
    {
        public string EmitSound()
        {
            return "Bark";
        }

        public string Wee()
        {
            return "I don't want to do it";
        }
    }
}