namespace underware.Edi.Common.DocumentModel;

public class Party
{
     public string GLN { get; set; }
     public string RegNo { get; set; }
     public string VATNo { get; set; }
     public string Name { get; set; }
     public string Name2 { get; set; }
     public string Street { get; set; }
     public string City { get; set; }
     public string ZIPCode { get; set; }
     public string Description { get; set; }
     public string InternalCode { get; set; }
     public string Country { get; set; }
     public string ExternalCode { get; set; }
     public string Box { get; set; }
     public string ExtendCode1 { get; set; }
     public string ExtendCode2 { get; set; }
     public string Phone1 { get; set; }
     public string Phone2 { get; set; }
     public string Fax { get; set; }
     public string Email { get; set; }
     public string Qualifier { get; set; }
     public string Contact { get; set; }

     public override string ToString()
     {
          return string.IsNullOrEmpty(Name) ? GLN : $"{Name}<{GLN}>";
     }
}