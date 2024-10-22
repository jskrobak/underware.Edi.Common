namespace underware.Edi.Common.DocumentModel;

public class DocumentReference
{
    public string Qualifier { get; set; }
    public string BillNo { get; set; }
    public DateTime? RefDate { get; set; }
}