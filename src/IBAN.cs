namespace underware.Edi.Common;

public class IBAN
{
    public string Value { get; set; }
    public string BankCode { get; set; }
    public string AccountNumber { get; set; }
    public string CountryCode { get; set; }
    public string CheckDigits { get; set; }
    public string BIC { get; set; }

    public static bool TryParse(string iban, out IBAN result)
    {
        result = null;
        try
        {
            result = Parse(iban);
            return true;
        }
        catch
        {
            return false;
        }
    }
    
    public static IBAN Parse(string iban)
    {
        if(iban is null)
            throw new ArgumentNullException(nameof(iban));

        if (string.IsNullOrEmpty(iban) || iban.Length != 24)
            throw new ArgumentException($"Invalid IBAN. [{iban}]");
        
        if(iban.Substring(0,2) != "CZ")
            throw new NotSupportedException("Only Czech IBANs are supported.");
    
        var bankCode = iban.Substring(4, 4);
        var prefix = iban.Substring(8, 6).TrimStart('0');
        var accountNumber = iban.Substring(14, 10).TrimStart('0');

        return new IBAN()
        {
            Value = iban,
            CountryCode = iban.Substring(0, 2),
            CheckDigits = iban.Substring(2, 2),
            BankCode = bankCode,
            AccountNumber = string.IsNullOrEmpty(prefix) ? accountNumber : $"{prefix}-{accountNumber}",
            BIC = Bank.AllBanks.FirstOrDefault(b => b.Code == bankCode)?.BIC
        };
    }

    private class Bank
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string BIC { get; set; }

        public static Bank[] AllBanks =>
        [
            new Bank { Code = "100", Name = "Komerční banka, a.s.", BIC = "KOMBCZPP" },
            new Bank { Code = "300", Name = "Československá obchodní banka, a.s.", BIC = "CEKOCZPP" },
            new Bank { Code = "600", Name = "MONETA Money Bank, a.s.", BIC = "AGBACZPP" },
            new Bank { Code = "710", Name = "Česká národní banka", BIC = "CNBACZPP" },
            new Bank { Code = "800", Name = "Česká spořitelna, a.s.", BIC = "GIBACZPX" },
            new Bank { Code = "2010", Name = "Fio banka, a.s.", BIC = "FIOBCZPP" },
            new Bank { Code = "2020", Name = "MUFG Bank (Europe) N.V. Prague Branch", BIC = "BOTKCZPP" },
            new Bank { Code = "2060", Name = "Citfin, spořitelní družstvo", BIC = "CITFCZPP" },
            new Bank { Code = "2070", Name = "TRINITY BANK a.s.", BIC = "MPUBCZPP" },
            new Bank { Code = "2220", Name = "Artesa, spořitelní družstvo", BIC = "ARTTCZPP" },
            new Bank { Code = "2250", Name = "Banka CREDITAS a.s.", BIC = "CTASCZ22" },
            new Bank { Code = "2600", Name = "Citibank Europe plc, organizační složka", BIC = "CITICZPX" },
            new Bank { Code = "2700", Name = "UniCredit Bank Czech Republic and Slovakia, a.s.", BIC = "BACXCZPP" },
            new Bank { Code = "3030", Name = "Air Bank a.s.", BIC = "AIRACZPP" },
            new Bank { Code = "3050", Name = "BNP Paribas Personal Finance SA, odštěpný závod", BIC = "BPPF CZ P1" },
            new Bank { Code = "3060", Name = "PKO BP S.A., Czech Branch", BIC = "BPKO CZ PP" },
            new Bank { Code = "3500", Name = "ING Bank N.V.", BIC = "INGBCZPP" },
            new Bank { Code = "4000", Name = "Max banka a.s. (dříve Expobank CZ a.s.)", BIC = "EXPNCZPP" },
            new Bank { Code = "4300", Name = "Národní rozvojová banka, a.s.", BIC = "CMZRCZP1" },
            new Bank { Code = "5500", Name = "Raiffeisenbank a.s.", BIC = "RZBCCZPP" },
            new Bank { Code = "5800", Name = "J & T Banka, a.s.", BIC = "JTBPCZPP" },
            new Bank { Code = "6000", Name = "PPF banka a.s.", BIC = "PMBPCZPP" },
            new Bank { Code = "6100", Name = "Raiffeisenbank a.s. (do 31. 12. 2021 Equa bank a.s.)", BIC = "EQBKCZPP" },
            new Bank { Code = "6200", Name = "COMMERZBANK Aktiengesellschaft, pobočka Praha", BIC = "COBACZPX" },
            new Bank { Code = "6210", Name = "mBank S.A., organizační složka", BIC = "BREXCZPP" },
            new Bank { Code = "6300", Name = "BNP Paribas S.A., pobočka Česká republika", BIC = "GEBACZPP" },
            new Bank { Code = "6700", Name = "Všeobecná úverová banka a.s., pobočka Praha", BIC = "SUBACZPP" },
            new Bank
            {
                Code = "7910", Name = "Deutsche Bank Aktiengesellschaft Filiale Prag, organizační složka",
                BIC = "DEUTCZPX"
            },
            new Bank
            {
                Code = "8030", Name = "Volksbank Raiffeisenbank Nordoberpfalz eG pobočka Cheb", BIC = "GENOCZ21"
            },
            new Bank { Code = "8040", Name = "Oberbank AG pobočka Česká republika", BIC = "OBKLCZ2X" },
            new Bank { Code = "8090", Name = "Česká exportní banka, a.s.", BIC = "CZEECZPP" },
            new Bank { Code = "8150", Name = "HSBC Bank plc - pobočka Praha", BIC = "MIDLCZPP" },
            new Bank { Code = "8198", Name = "FAS finance company s.r.o.", BIC = "FFCSCZP1" },
            new Bank { Code = "8199", Name = "MoneyPolo Europe s.r.o.", BIC = "MOUSCZP2" },
            new Bank { Code = "8220", Name = "Payment Execution s.r.o.", BIC = "PAERCZP1" },
            new Bank { Code = "8250", Name = "Bank of China (CEE) Ltd. Prague Branch", BIC = "BKCHCZPP" },
            new Bank
            {
                Code = "8255", Name = "Bank of Communications Co., Ltd., Prague Branch odštěpný závod", BIC = "COMMCZPP"
            },
            new Bank
            {
                Code = "8265", Name = "Industrial and Commercial Bank of China Limited, Prague Branch, odštěpný závod",
                BIC = "ICBKCZPP"
            },
            new Bank { Code = "8270", Name = "Fairplay Pay s.r.o.", BIC = "FAPOCZP1" },
            new Bank { Code = "8280", Name = "B-Efekt a.s.", BIC = "BEFKCZP1" },
            new Bank { Code = "8293", Name = "Mercurius partners s.r.o.", BIC = "MRPSCZPP" },
            new Bank { Code = "8250", Name = "BESTPAY s.r.o.", BIC = "BEORCZP2" }

        ];
    }
}