namespace CustomReSharperMacro
{
    public class LSClassName : IClassName
    {
        private readonly ClassName _repo = new ClassName();
        private readonly ClassNameConverter _converter = new ClassNameConverter();
    }

    
}