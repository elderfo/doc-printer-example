namespace CPrint.Logic.Documents
{
    public interface IDocument
    {
        DocumentType DocumentType { get; set; }
        string Path { get; set; }
    }
}