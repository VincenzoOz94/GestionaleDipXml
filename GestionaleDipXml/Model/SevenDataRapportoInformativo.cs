using System;
using System.Collections.Generic;

namespace GestionaleDipXml.Model;

public partial class SevenDataRapportoInformativo
{
    public int Oid { get; set; }

    public int OidProdotto { get; set; }

    public int OidCliente { get; set; }

    public DateTime DataRichiesta { get; set; }

    public DateTime? DataRisposta { get; set; }

    public DateOnly? DataRispostaShort { get; set; }

    public bool Elaborato { get; set; }

    public string? Xml { get; set; }

    public int? Rating { get; set; }

    public string? StatoAttivita { get; set; }

    public int? Fido { get; set; }

    public int? ScoreBilancio { get; set; }

    public string? Negativita { get; set; }

    public int? AnnoBilancio { get; set; }

    public int? IdrichiestaJson { get; set; }

    public int? IdrichiestaPdf { get; set; }
}

// NOTA: con il codice generato potrebbe essere richiesto almeno .NET Framework 4.5 o .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class Root
{

    private RootDocument documentField;

    private RootInput inputField;

    private object exceptionField;

    private RootAccount_information account_informationField;

    private object account_informationsField;

    /// <remarks/>
    public RootDocument Document
    {
        get
        {
            return this.documentField;
        }
        set
        {
            this.documentField = value;
        }
    }

    /// <remarks/>
    public RootInput Input
    {
        get
        {
            return this.inputField;
        }
        set
        {
            this.inputField = value;
        }
    }

    /// <remarks/>
    public object Exception
    {
        get
        {
            return this.exceptionField;
        }
        set
        {
            this.exceptionField = value;
        }
    }

    /// <remarks/>
    public RootAccount_information Account_information
    {
        get
        {
            return this.account_informationField;
        }
        set
        {
            this.account_informationField = value;
        }
    }

    /// <remarks/>
    public object Account_informations
    {
        get
        {
            return this.account_informationsField;
        }
        set
        {
            this.account_informationsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootDocument
{

    private object document_typeField;

    private object binaryDocumentField;

    private object xmlDocumentField;

    private object jsonDocumentField;

    private RootDocumentJsonOutput jsonOutputField;

    private object htmlDocumentField;

    private object linkField;

    /// <remarks/>
    public object Document_type
    {
        get
        {
            return this.document_typeField;
        }
        set
        {
            this.document_typeField = value;
        }
    }

    /// <remarks/>
    public object BinaryDocument
    {
        get
        {
            return this.binaryDocumentField;
        }
        set
        {
            this.binaryDocumentField = value;
        }
    }

    /// <remarks/>
    public object XmlDocument
    {
        get
        {
            return this.xmlDocumentField;
        }
        set
        {
            this.xmlDocumentField = value;
        }
    }

    /// <remarks/>
    public object JsonDocument
    {
        get
        {
            return this.jsonDocumentField;
        }
        set
        {
            this.jsonDocumentField = value;
        }
    }

    /// <remarks/>
    public RootDocumentJsonOutput JsonOutput
    {
        get
        {
            return this.jsonOutputField;
        }
        set
        {
            this.jsonOutputField = value;
        }
    }

    /// <remarks/>
    public object HtmlDocument
    {
        get
        {
            return this.htmlDocumentField;
        }
        set
        {
            this.htmlDocumentField = value;
        }
    }

    /// <remarks/>
    public object Link
    {
        get
        {
            return this.linkField;
        }
        set
        {
            this.linkField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootDocumentJsonOutput
{

    private RootDocumentJsonOutputAnagrafica_base anagrafica_baseField;

    private RootDocumentJsonOutputAltre_sedi altre_sediField;

    private RootDocumentJsonOutputEsponenti_premium esponenti_premiumField;

    private RootDocumentJsonOutputIndiciTerritoriali indiciTerritorialiField;

    private object[] categorieKompassField;

    private RootDocumentJsonOutputNegativita negativitaField;

    private object principali_operazioni_straordinarieField;

    private RootDocumentJsonOutputOutputRatingFido outputRatingFidoField;

    private RootDocumentJsonOutputOggetto_sociale oggetto_socialeField;

    /// <remarks/>
    public RootDocumentJsonOutputAnagrafica_base Anagrafica_base
    {
        get
        {
            return this.anagrafica_baseField;
        }
        set
        {
            this.anagrafica_baseField = value;
        }
    }

    /// <remarks/>
    public RootDocumentJsonOutputAltre_sedi Altre_sedi
    {
        get
        {
            return this.altre_sediField;
        }
        set
        {
            this.altre_sediField = value;
        }
    }

    /// <remarks/>
    public RootDocumentJsonOutputEsponenti_premium Esponenti_premium
    {
        get
        {
            return this.esponenti_premiumField;
        }
        set
        {
            this.esponenti_premiumField = value;
        }
    }

    /// <remarks/>
    public RootDocumentJsonOutputIndiciTerritoriali IndiciTerritoriali
    {
        get
        {
            return this.indiciTerritorialiField;
        }
        set
        {
            this.indiciTerritorialiField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("CategorieKompass")]
    public object[] CategorieKompass
    {
        get
        {
            return this.categorieKompassField;
        }
        set
        {
            this.categorieKompassField = value;
        }
    }

    /// <remarks/>
    public RootDocumentJsonOutputNegativita Negativita
    {
        get
        {
            return this.negativitaField;
        }
        set
        {
            this.negativitaField = value;
        }
    }

    /// <remarks/>
    public object Principali_operazioni_straordinarie
    {
        get
        {
            return this.principali_operazioni_straordinarieField;
        }
        set
        {
            this.principali_operazioni_straordinarieField = value;
        }
    }

    /// <remarks/>
    public RootDocumentJsonOutputOutputRatingFido OutputRatingFido
    {
        get
        {
            return this.outputRatingFidoField;
        }
        set
        {
            this.outputRatingFidoField = value;
        }
    }

    /// <remarks/>
    public RootDocumentJsonOutputOggetto_sociale Oggetto_sociale
    {
        get
        {
            return this.oggetto_socialeField;
        }
        set
        {
            this.oggetto_socialeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootDocumentJsonOutputAnagrafica_base
{

    private string cciaaField;

    private uint reaField;

    private uint idAzienda7dField;

    private byte progressivoulField;

    private string codeStatoAttivitaInfocamereField;

    private string descStatoAttivitaInfocamereField;

    private ulong codicefiscaleField;

    private ulong partitaivaField;

    private string codeTipoSedeField;

    private string descTipoSedeField;

    private string denominazioneField;

    private string denominazioneNormField;

    private string codeDescrizionesedeField;

    private string descDescrizionesedeField;

    private string descSezioneAtecoField;

    private System.DateTime dataProtocolloField;

    private System.DateTime dataProtocolloEvasoField;

    private System.DateTime datainizioattivitaField;

    private System.DateTime dataiscrizioneField;

    private string codeClasseGiuridicaField;

    private string descClasseGiuridicaField;

    private string codeFormaGiuridicaField;

    private string descFormagiuridicaField;

    private string pecField;

    private byte codeClasseFatturatoField;

    private string descClasseFatturatoField;

    private ushort capsocDeliberatoField;

    private ushort capsocSottoscrittoField;

    private ushort capsocVersatoField;

    private uint fatturatoField;

    private string codeAtecoField;

    private string descAtecoField;

    private ushort codeSicField;

    private string descSicField;

    private byte codeFasciaDipendentiField;

    private byte descFasciaDipendentiField;

    private ushort codSaeField;

    private string descSaeField;

    private ushort codRaeField;

    private string descRaeField;

    private string ioToponimoField;

    private string ioViaField;

    private byte ioCivicoField;

    private ushort ioCapField;

    private string ioComuneField;

    private string ioProvinciaField;

    private byte ioCodComuneField;

    private byte codIstatRegioneField;

    private string descIstatRegioneField;

    private byte idAreaNielsenRegioneField;

    private string descAreaNielsenRegioneField;

    private byte codeIstatProvinciaField;

    private string descIstatProvinciaField;

    private ushort codeIstatComuneField;

    private string descIstatComuneField;

    private string codeCatastaleField;

    private uint popolazioneComuneField;

    private string dugField;

    private string dufField;

    private byte civicoField;

    private string indirizzoField;

    private ushort capField;

    private string localitaField;

    private string codProvinciaField;

    private string indirizzoAbbreviatoField;

    private string comuneField;

    private string flagPostalizzazioneField;

    private string flagNoCivicoField;

    private byte livelloGeocodificaField;

    private decimal lonXField;

    private decimal latYField;

    private ulong sezioneField;

    private byte dbuPrefissoField;

    private uint dbuNumeroField;

    private uint dbuTelefonoCompletoField;

    private byte numeroSediField;

    private byte addettiDipendentiField;

    private byte addettiIndipendentiField;

    private byte addettiTotaleField;

    private ushort annoField;

    private byte trimestreField;

    private string flagIndCommercialistaField;

    private string codeSezAtecoField;

    /// <remarks/>
    public string Cciaa
    {
        get
        {
            return this.cciaaField;
        }
        set
        {
            this.cciaaField = value;
        }
    }

    /// <remarks/>
    public uint Rea
    {
        get
        {
            return this.reaField;
        }
        set
        {
            this.reaField = value;
        }
    }

    /// <remarks/>
    public uint IdAzienda7d
    {
        get
        {
            return this.idAzienda7dField;
        }
        set
        {
            this.idAzienda7dField = value;
        }
    }

    /// <remarks/>
    public byte Progressivoul
    {
        get
        {
            return this.progressivoulField;
        }
        set
        {
            this.progressivoulField = value;
        }
    }

    /// <remarks/>
    public string CodeStatoAttivitaInfocamere
    {
        get
        {
            return this.codeStatoAttivitaInfocamereField;
        }
        set
        {
            this.codeStatoAttivitaInfocamereField = value;
        }
    }

    /// <remarks/>
    public string DescStatoAttivitaInfocamere
    {
        get
        {
            return this.descStatoAttivitaInfocamereField;
        }
        set
        {
            this.descStatoAttivitaInfocamereField = value;
        }
    }

    /// <remarks/>
    public ulong Codicefiscale
    {
        get
        {
            return this.codicefiscaleField;
        }
        set
        {
            this.codicefiscaleField = value;
        }
    }

    /// <remarks/>
    public ulong Partitaiva
    {
        get
        {
            return this.partitaivaField;
        }
        set
        {
            this.partitaivaField = value;
        }
    }

    /// <remarks/>
    public string CodeTipoSede
    {
        get
        {
            return this.codeTipoSedeField;
        }
        set
        {
            this.codeTipoSedeField = value;
        }
    }

    /// <remarks/>
    public string DescTipoSede
    {
        get
        {
            return this.descTipoSedeField;
        }
        set
        {
            this.descTipoSedeField = value;
        }
    }

    /// <remarks/>
    public string Denominazione
    {
        get
        {
            return this.denominazioneField;
        }
        set
        {
            this.denominazioneField = value;
        }
    }

    /// <remarks/>
    public string DenominazioneNorm
    {
        get
        {
            return this.denominazioneNormField;
        }
        set
        {
            this.denominazioneNormField = value;
        }
    }

    /// <remarks/>
    public string CodeDescrizionesede
    {
        get
        {
            return this.codeDescrizionesedeField;
        }
        set
        {
            this.codeDescrizionesedeField = value;
        }
    }

    /// <remarks/>
    public string DescDescrizionesede
    {
        get
        {
            return this.descDescrizionesedeField;
        }
        set
        {
            this.descDescrizionesedeField = value;
        }
    }

    /// <remarks/>
    public string DescSezioneAteco
    {
        get
        {
            return this.descSezioneAtecoField;
        }
        set
        {
            this.descSezioneAtecoField = value;
        }
    }

    /// <remarks/>
    public System.DateTime DataProtocollo
    {
        get
        {
            return this.dataProtocolloField;
        }
        set
        {
            this.dataProtocolloField = value;
        }
    }

    /// <remarks/>
    public System.DateTime DataProtocolloEvaso
    {
        get
        {
            return this.dataProtocolloEvasoField;
        }
        set
        {
            this.dataProtocolloEvasoField = value;
        }
    }

    /// <remarks/>
    public System.DateTime Datainizioattivita
    {
        get
        {
            return this.datainizioattivitaField;
        }
        set
        {
            this.datainizioattivitaField = value;
        }
    }

    /// <remarks/>
    public System.DateTime Dataiscrizione
    {
        get
        {
            return this.dataiscrizioneField;
        }
        set
        {
            this.dataiscrizioneField = value;
        }
    }

    /// <remarks/>
    public string CodeClasseGiuridica
    {
        get
        {
            return this.codeClasseGiuridicaField;
        }
        set
        {
            this.codeClasseGiuridicaField = value;
        }
    }

    /// <remarks/>
    public string DescClasseGiuridica
    {
        get
        {
            return this.descClasseGiuridicaField;
        }
        set
        {
            this.descClasseGiuridicaField = value;
        }
    }

    /// <remarks/>
    public string CodeFormaGiuridica
    {
        get
        {
            return this.codeFormaGiuridicaField;
        }
        set
        {
            this.codeFormaGiuridicaField = value;
        }
    }

    /// <remarks/>
    public string DescFormagiuridica
    {
        get
        {
            return this.descFormagiuridicaField;
        }
        set
        {
            this.descFormagiuridicaField = value;
        }
    }

    /// <remarks/>
    public string Pec
    {
        get
        {
            return this.pecField;
        }
        set
        {
            this.pecField = value;
        }
    }

    /// <remarks/>
    public byte CodeClasseFatturato
    {
        get
        {
            return this.codeClasseFatturatoField;
        }
        set
        {
            this.codeClasseFatturatoField = value;
        }
    }

    /// <remarks/>
    public string DescClasseFatturato
    {
        get
        {
            return this.descClasseFatturatoField;
        }
        set
        {
            this.descClasseFatturatoField = value;
        }
    }

    /// <remarks/>
    public ushort CapsocDeliberato
    {
        get
        {
            return this.capsocDeliberatoField;
        }
        set
        {
            this.capsocDeliberatoField = value;
        }
    }

    /// <remarks/>
    public ushort CapsocSottoscritto
    {
        get
        {
            return this.capsocSottoscrittoField;
        }
        set
        {
            this.capsocSottoscrittoField = value;
        }
    }

    /// <remarks/>
    public ushort CapsocVersato
    {
        get
        {
            return this.capsocVersatoField;
        }
        set
        {
            this.capsocVersatoField = value;
        }
    }

    /// <remarks/>
    public uint Fatturato
    {
        get
        {
            return this.fatturatoField;
        }
        set
        {
            this.fatturatoField = value;
        }
    }

    /// <remarks/>
    public string CodeAteco
    {
        get
        {
            return this.codeAtecoField;
        }
        set
        {
            this.codeAtecoField = value;
        }
    }

    /// <remarks/>
    public string DescAteco
    {
        get
        {
            return this.descAtecoField;
        }
        set
        {
            this.descAtecoField = value;
        }
    }

    /// <remarks/>
    public ushort CodeSic
    {
        get
        {
            return this.codeSicField;
        }
        set
        {
            this.codeSicField = value;
        }
    }

    /// <remarks/>
    public string DescSic
    {
        get
        {
            return this.descSicField;
        }
        set
        {
            this.descSicField = value;
        }
    }

    /// <remarks/>
    public byte CodeFasciaDipendenti
    {
        get
        {
            return this.codeFasciaDipendentiField;
        }
        set
        {
            this.codeFasciaDipendentiField = value;
        }
    }

    /// <remarks/>
    public byte DescFasciaDipendenti
    {
        get
        {
            return this.descFasciaDipendentiField;
        }
        set
        {
            this.descFasciaDipendentiField = value;
        }
    }

    /// <remarks/>
    public ushort CodSae
    {
        get
        {
            return this.codSaeField;
        }
        set
        {
            this.codSaeField = value;
        }
    }

    /// <remarks/>
    public string DescSae
    {
        get
        {
            return this.descSaeField;
        }
        set
        {
            this.descSaeField = value;
        }
    }

    /// <remarks/>
    public ushort CodRae
    {
        get
        {
            return this.codRaeField;
        }
        set
        {
            this.codRaeField = value;
        }
    }

    /// <remarks/>
    public string DescRae
    {
        get
        {
            return this.descRaeField;
        }
        set
        {
            this.descRaeField = value;
        }
    }

    /// <remarks/>
    public string IoToponimo
    {
        get
        {
            return this.ioToponimoField;
        }
        set
        {
            this.ioToponimoField = value;
        }
    }

    /// <remarks/>
    public string IoVia
    {
        get
        {
            return this.ioViaField;
        }
        set
        {
            this.ioViaField = value;
        }
    }

    /// <remarks/>
    public byte IoCivico
    {
        get
        {
            return this.ioCivicoField;
        }
        set
        {
            this.ioCivicoField = value;
        }
    }

    /// <remarks/>
    public ushort IoCap
    {
        get
        {
            return this.ioCapField;
        }
        set
        {
            this.ioCapField = value;
        }
    }

    /// <remarks/>
    public string IoComune
    {
        get
        {
            return this.ioComuneField;
        }
        set
        {
            this.ioComuneField = value;
        }
    }

    /// <remarks/>
    public string IoProvincia
    {
        get
        {
            return this.ioProvinciaField;
        }
        set
        {
            this.ioProvinciaField = value;
        }
    }

    /// <remarks/>
    public byte IoCodComune
    {
        get
        {
            return this.ioCodComuneField;
        }
        set
        {
            this.ioCodComuneField = value;
        }
    }

    /// <remarks/>
    public byte CodIstatRegione
    {
        get
        {
            return this.codIstatRegioneField;
        }
        set
        {
            this.codIstatRegioneField = value;
        }
    }

    /// <remarks/>
    public string DescIstatRegione
    {
        get
        {
            return this.descIstatRegioneField;
        }
        set
        {
            this.descIstatRegioneField = value;
        }
    }

    /// <remarks/>
    public byte IdAreaNielsenRegione
    {
        get
        {
            return this.idAreaNielsenRegioneField;
        }
        set
        {
            this.idAreaNielsenRegioneField = value;
        }
    }

    /// <remarks/>
    public string DescAreaNielsenRegione
    {
        get
        {
            return this.descAreaNielsenRegioneField;
        }
        set
        {
            this.descAreaNielsenRegioneField = value;
        }
    }

    /// <remarks/>
    public byte CodeIstatProvincia
    {
        get
        {
            return this.codeIstatProvinciaField;
        }
        set
        {
            this.codeIstatProvinciaField = value;
        }
    }

    /// <remarks/>
    public string DescIstatProvincia
    {
        get
        {
            return this.descIstatProvinciaField;
        }
        set
        {
            this.descIstatProvinciaField = value;
        }
    }

    /// <remarks/>
    public ushort CodeIstatComune
    {
        get
        {
            return this.codeIstatComuneField;
        }
        set
        {
            this.codeIstatComuneField = value;
        }
    }

    /// <remarks/>
    public string DescIstatComune
    {
        get
        {
            return this.descIstatComuneField;
        }
        set
        {
            this.descIstatComuneField = value;
        }
    }

    /// <remarks/>
    public string CodeCatastale
    {
        get
        {
            return this.codeCatastaleField;
        }
        set
        {
            this.codeCatastaleField = value;
        }
    }

    /// <remarks/>
    public uint PopolazioneComune
    {
        get
        {
            return this.popolazioneComuneField;
        }
        set
        {
            this.popolazioneComuneField = value;
        }
    }

    /// <remarks/>
    public string Dug
    {
        get
        {
            return this.dugField;
        }
        set
        {
            this.dugField = value;
        }
    }

    /// <remarks/>
    public string Duf
    {
        get
        {
            return this.dufField;
        }
        set
        {
            this.dufField = value;
        }
    }

    /// <remarks/>
    public byte Civico
    {
        get
        {
            return this.civicoField;
        }
        set
        {
            this.civicoField = value;
        }
    }

    /// <remarks/>
    public string Indirizzo
    {
        get
        {
            return this.indirizzoField;
        }
        set
        {
            this.indirizzoField = value;
        }
    }

    /// <remarks/>
    public ushort Cap
    {
        get
        {
            return this.capField;
        }
        set
        {
            this.capField = value;
        }
    }

    /// <remarks/>
    public string Localita
    {
        get
        {
            return this.localitaField;
        }
        set
        {
            this.localitaField = value;
        }
    }

    /// <remarks/>
    public string CodProvincia
    {
        get
        {
            return this.codProvinciaField;
        }
        set
        {
            this.codProvinciaField = value;
        }
    }

    /// <remarks/>
    public string IndirizzoAbbreviato
    {
        get
        {
            return this.indirizzoAbbreviatoField;
        }
        set
        {
            this.indirizzoAbbreviatoField = value;
        }
    }

    /// <remarks/>
    public string Comune
    {
        get
        {
            return this.comuneField;
        }
        set
        {
            this.comuneField = value;
        }
    }

    /// <remarks/>
    public string FlagPostalizzazione
    {
        get
        {
            return this.flagPostalizzazioneField;
        }
        set
        {
            this.flagPostalizzazioneField = value;
        }
    }

    /// <remarks/>
    public string FlagNoCivico
    {
        get
        {
            return this.flagNoCivicoField;
        }
        set
        {
            this.flagNoCivicoField = value;
        }
    }

    /// <remarks/>
    public byte LivelloGeocodifica
    {
        get
        {
            return this.livelloGeocodificaField;
        }
        set
        {
            this.livelloGeocodificaField = value;
        }
    }

    /// <remarks/>
    public decimal LonX
    {
        get
        {
            return this.lonXField;
        }
        set
        {
            this.lonXField = value;
        }
    }

    /// <remarks/>
    public decimal LatY
    {
        get
        {
            return this.latYField;
        }
        set
        {
            this.latYField = value;
        }
    }

    /// <remarks/>
    public ulong Sezione
    {
        get
        {
            return this.sezioneField;
        }
        set
        {
            this.sezioneField = value;
        }
    }

    /// <remarks/>
    public byte DbuPrefisso
    {
        get
        {
            return this.dbuPrefissoField;
        }
        set
        {
            this.dbuPrefissoField = value;
        }
    }

    /// <remarks/>
    public uint DbuNumero
    {
        get
        {
            return this.dbuNumeroField;
        }
        set
        {
            this.dbuNumeroField = value;
        }
    }

    /// <remarks/>
    public uint DbuTelefonoCompleto
    {
        get
        {
            return this.dbuTelefonoCompletoField;
        }
        set
        {
            this.dbuTelefonoCompletoField = value;
        }
    }

    /// <remarks/>
    public byte NumeroSedi
    {
        get
        {
            return this.numeroSediField;
        }
        set
        {
            this.numeroSediField = value;
        }
    }

    /// <remarks/>
    public byte AddettiDipendenti
    {
        get
        {
            return this.addettiDipendentiField;
        }
        set
        {
            this.addettiDipendentiField = value;
        }
    }

    /// <remarks/>
    public byte AddettiIndipendenti
    {
        get
        {
            return this.addettiIndipendentiField;
        }
        set
        {
            this.addettiIndipendentiField = value;
        }
    }

    /// <remarks/>
    public byte AddettiTotale
    {
        get
        {
            return this.addettiTotaleField;
        }
        set
        {
            this.addettiTotaleField = value;
        }
    }

    /// <remarks/>
    public ushort Anno
    {
        get
        {
            return this.annoField;
        }
        set
        {
            this.annoField = value;
        }
    }

    /// <remarks/>
    public byte Trimestre
    {
        get
        {
            return this.trimestreField;
        }
        set
        {
            this.trimestreField = value;
        }
    }

    /// <remarks/>
    public string FlagIndCommercialista
    {
        get
        {
            return this.flagIndCommercialistaField;
        }
        set
        {
            this.flagIndCommercialistaField = value;
        }
    }

    /// <remarks/>
    public string CodeSezAteco
    {
        get
        {
            return this.codeSezAtecoField;
        }
        set
        {
            this.codeSezAtecoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootDocumentJsonOutputAltre_sedi
{

    private string cciaaField;

    private uint reaField;

    private byte progressivoulField;

    private uint idAzienda7dField;

    private string codeStatoAttivitaInfocamereField;

    private string descStatoAttivitaInfocamereField;

    private ulong codicefiscaleField;

    private ulong partitaivaField;

    private string codeTipoSedeField;

    private string descTipoSedeField;

    private string denominazioneField;

    private string denominazioneNormField;

    private string codeDescrizionesedeField;

    private string descDescrizionesedeField;

    private string descSezioneAtecoField;

    private System.DateTime dataProtocolloField;

    private System.DateTime dataProtocolloEvasoField;

    private System.DateTime datainizioattivitaField;

    private System.DateTime dataiscrizioneField;

    private System.DateTime datacessazioneField;

    private string codeClasseGiuridicaField;

    private string descClasseGiuridicaField;

    private string codeFormaGiuridicaField;

    private string descFormagiuridicaField;

    private string pecField;

    private byte codeClasseFatturatoField;

    private string descClasseFatturatoField;

    private ushort capsocDeliberatoField;

    private ushort capsocSottoscrittoField;

    private ushort capsocVersatoField;

    private uint fatturatoField;

    private string codeAtecoField;

    private string descAtecoField;

    private ushort codeSicField;

    private string descSicField;

    private byte codeFasciaDipendentiField;

    private byte descFasciaDipendentiField;

    private ushort codSaeField;

    private string descSaeField;

    private ushort codRaeField;

    private string descRaeField;

    private string ioToponimoField;

    private string ioViaField;

    private string ioCivicoField;

    private object ioFrazioneField;

    private ushort ioCapField;

    private string ioComuneField;

    private string ioProvinciaField;

    private byte ioCodComuneField;

    private byte codIstatRegioneField;

    private string descIstatRegioneField;

    private byte idAreaNielsenRegioneField;

    private string descAreaNielsenRegioneField;

    private byte codeIstatProvinciaField;

    private string descIstatProvinciaField;

    private ushort codeIstatComuneField;

    private string descIstatComuneField;

    private string codeCatastaleField;

    private uint popolazioneComuneField;

    private string dugField;

    private string dufField;

    private string civicoField;

    private string indirizzoField;

    private ushort capField;

    private string localitaField;

    private string codProvinciaField;

    private string indirizzoAbbreviatoField;

    private string comuneField;

    private string flagPostalizzazioneField;

    private string flagNoCivicoField;

    private byte livelloGeocodificaField;

    private decimal lonXField;

    private decimal latYField;

    private ulong sezioneField;

    private object numeroSediField;

    private byte addettiDipendentiField;

    private byte addettiIndipendentiField;

    private byte addettiTotaleField;

    private ushort annoField;

    private byte trimestreField;

    private string flagIndCommercialistaField;

    private string codeSezAtecoField;

    /// <remarks/>
    public string Cciaa
    {
        get
        {
            return this.cciaaField;
        }
        set
        {
            this.cciaaField = value;
        }
    }

    /// <remarks/>
    public uint Rea
    {
        get
        {
            return this.reaField;
        }
        set
        {
            this.reaField = value;
        }
    }

    /// <remarks/>
    public byte Progressivoul
    {
        get
        {
            return this.progressivoulField;
        }
        set
        {
            this.progressivoulField = value;
        }
    }

    /// <remarks/>
    public uint IdAzienda7d
    {
        get
        {
            return this.idAzienda7dField;
        }
        set
        {
            this.idAzienda7dField = value;
        }
    }

    /// <remarks/>
    public string CodeStatoAttivitaInfocamere
    {
        get
        {
            return this.codeStatoAttivitaInfocamereField;
        }
        set
        {
            this.codeStatoAttivitaInfocamereField = value;
        }
    }

    /// <remarks/>
    public string DescStatoAttivitaInfocamere
    {
        get
        {
            return this.descStatoAttivitaInfocamereField;
        }
        set
        {
            this.descStatoAttivitaInfocamereField = value;
        }
    }

    /// <remarks/>
    public ulong Codicefiscale
    {
        get
        {
            return this.codicefiscaleField;
        }
        set
        {
            this.codicefiscaleField = value;
        }
    }

    /// <remarks/>
    public ulong Partitaiva
    {
        get
        {
            return this.partitaivaField;
        }
        set
        {
            this.partitaivaField = value;
        }
    }

    /// <remarks/>
    public string CodeTipoSede
    {
        get
        {
            return this.codeTipoSedeField;
        }
        set
        {
            this.codeTipoSedeField = value;
        }
    }

    /// <remarks/>
    public string DescTipoSede
    {
        get
        {
            return this.descTipoSedeField;
        }
        set
        {
            this.descTipoSedeField = value;
        }
    }

    /// <remarks/>
    public string Denominazione
    {
        get
        {
            return this.denominazioneField;
        }
        set
        {
            this.denominazioneField = value;
        }
    }

    /// <remarks/>
    public string DenominazioneNorm
    {
        get
        {
            return this.denominazioneNormField;
        }
        set
        {
            this.denominazioneNormField = value;
        }
    }

    /// <remarks/>
    public string CodeDescrizionesede
    {
        get
        {
            return this.codeDescrizionesedeField;
        }
        set
        {
            this.codeDescrizionesedeField = value;
        }
    }

    /// <remarks/>
    public string DescDescrizionesede
    {
        get
        {
            return this.descDescrizionesedeField;
        }
        set
        {
            this.descDescrizionesedeField = value;
        }
    }

    /// <remarks/>
    public string DescSezioneAteco
    {
        get
        {
            return this.descSezioneAtecoField;
        }
        set
        {
            this.descSezioneAtecoField = value;
        }
    }

    /// <remarks/>
    public System.DateTime DataProtocollo
    {
        get
        {
            return this.dataProtocolloField;
        }
        set
        {
            this.dataProtocolloField = value;
        }
    }

    /// <remarks/>
    public System.DateTime DataProtocolloEvaso
    {
        get
        {
            return this.dataProtocolloEvasoField;
        }
        set
        {
            this.dataProtocolloEvasoField = value;
        }
    }

    /// <remarks/>
    public System.DateTime Datainizioattivita
    {
        get
        {
            return this.datainizioattivitaField;
        }
        set
        {
            this.datainizioattivitaField = value;
        }
    }

    /// <remarks/>
    public System.DateTime Dataiscrizione
    {
        get
        {
            return this.dataiscrizioneField;
        }
        set
        {
            this.dataiscrizioneField = value;
        }
    }

    /// <remarks/>
    public System.DateTime Datacessazione
    {
        get
        {
            return this.datacessazioneField;
        }
        set
        {
            this.datacessazioneField = value;
        }
    }

    /// <remarks/>
    public string CodeClasseGiuridica
    {
        get
        {
            return this.codeClasseGiuridicaField;
        }
        set
        {
            this.codeClasseGiuridicaField = value;
        }
    }

    /// <remarks/>
    public string DescClasseGiuridica
    {
        get
        {
            return this.descClasseGiuridicaField;
        }
        set
        {
            this.descClasseGiuridicaField = value;
        }
    }

    /// <remarks/>
    public string CodeFormaGiuridica
    {
        get
        {
            return this.codeFormaGiuridicaField;
        }
        set
        {
            this.codeFormaGiuridicaField = value;
        }
    }

    /// <remarks/>
    public string DescFormagiuridica
    {
        get
        {
            return this.descFormagiuridicaField;
        }
        set
        {
            this.descFormagiuridicaField = value;
        }
    }

    /// <remarks/>
    public string Pec
    {
        get
        {
            return this.pecField;
        }
        set
        {
            this.pecField = value;
        }
    }

    /// <remarks/>
    public byte CodeClasseFatturato
    {
        get
        {
            return this.codeClasseFatturatoField;
        }
        set
        {
            this.codeClasseFatturatoField = value;
        }
    }

    /// <remarks/>
    public string DescClasseFatturato
    {
        get
        {
            return this.descClasseFatturatoField;
        }
        set
        {
            this.descClasseFatturatoField = value;
        }
    }

    /// <remarks/>
    public ushort CapsocDeliberato
    {
        get
        {
            return this.capsocDeliberatoField;
        }
        set
        {
            this.capsocDeliberatoField = value;
        }
    }

    /// <remarks/>
    public ushort CapsocSottoscritto
    {
        get
        {
            return this.capsocSottoscrittoField;
        }
        set
        {
            this.capsocSottoscrittoField = value;
        }
    }

    /// <remarks/>
    public ushort CapsocVersato
    {
        get
        {
            return this.capsocVersatoField;
        }
        set
        {
            this.capsocVersatoField = value;
        }
    }

    /// <remarks/>
    public uint Fatturato
    {
        get
        {
            return this.fatturatoField;
        }
        set
        {
            this.fatturatoField = value;
        }
    }

    /// <remarks/>
    public string CodeAteco
    {
        get
        {
            return this.codeAtecoField;
        }
        set
        {
            this.codeAtecoField = value;
        }
    }

    /// <remarks/>
    public string DescAteco
    {
        get
        {
            return this.descAtecoField;
        }
        set
        {
            this.descAtecoField = value;
        }
    }

    /// <remarks/>
    public ushort CodeSic
    {
        get
        {
            return this.codeSicField;
        }
        set
        {
            this.codeSicField = value;
        }
    }

    /// <remarks/>
    public string DescSic
    {
        get
        {
            return this.descSicField;
        }
        set
        {
            this.descSicField = value;
        }
    }

    /// <remarks/>
    public byte CodeFasciaDipendenti
    {
        get
        {
            return this.codeFasciaDipendentiField;
        }
        set
        {
            this.codeFasciaDipendentiField = value;
        }
    }

    /// <remarks/>
    public byte DescFasciaDipendenti
    {
        get
        {
            return this.descFasciaDipendentiField;
        }
        set
        {
            this.descFasciaDipendentiField = value;
        }
    }

    /// <remarks/>
    public ushort CodSae
    {
        get
        {
            return this.codSaeField;
        }
        set
        {
            this.codSaeField = value;
        }
    }

    /// <remarks/>
    public string DescSae
    {
        get
        {
            return this.descSaeField;
        }
        set
        {
            this.descSaeField = value;
        }
    }

    /// <remarks/>
    public ushort CodRae
    {
        get
        {
            return this.codRaeField;
        }
        set
        {
            this.codRaeField = value;
        }
    }

    /// <remarks/>
    public string DescRae
    {
        get
        {
            return this.descRaeField;
        }
        set
        {
            this.descRaeField = value;
        }
    }

    /// <remarks/>
    public string IoToponimo
    {
        get
        {
            return this.ioToponimoField;
        }
        set
        {
            this.ioToponimoField = value;
        }
    }

    /// <remarks/>
    public string IoVia
    {
        get
        {
            return this.ioViaField;
        }
        set
        {
            this.ioViaField = value;
        }
    }

    /// <remarks/>
    public string IoCivico
    {
        get
        {
            return this.ioCivicoField;
        }
        set
        {
            this.ioCivicoField = value;
        }
    }

    /// <remarks/>
    public object IoFrazione
    {
        get
        {
            return this.ioFrazioneField;
        }
        set
        {
            this.ioFrazioneField = value;
        }
    }

    /// <remarks/>
    public ushort IoCap
    {
        get
        {
            return this.ioCapField;
        }
        set
        {
            this.ioCapField = value;
        }
    }

    /// <remarks/>
    public string IoComune
    {
        get
        {
            return this.ioComuneField;
        }
        set
        {
            this.ioComuneField = value;
        }
    }

    /// <remarks/>
    public string IoProvincia
    {
        get
        {
            return this.ioProvinciaField;
        }
        set
        {
            this.ioProvinciaField = value;
        }
    }

    /// <remarks/>
    public byte IoCodComune
    {
        get
        {
            return this.ioCodComuneField;
        }
        set
        {
            this.ioCodComuneField = value;
        }
    }

    /// <remarks/>
    public byte CodIstatRegione
    {
        get
        {
            return this.codIstatRegioneField;
        }
        set
        {
            this.codIstatRegioneField = value;
        }
    }

    /// <remarks/>
    public string DescIstatRegione
    {
        get
        {
            return this.descIstatRegioneField;
        }
        set
        {
            this.descIstatRegioneField = value;
        }
    }

    /// <remarks/>
    public byte IdAreaNielsenRegione
    {
        get
        {
            return this.idAreaNielsenRegioneField;
        }
        set
        {
            this.idAreaNielsenRegioneField = value;
        }
    }

    /// <remarks/>
    public string DescAreaNielsenRegione
    {
        get
        {
            return this.descAreaNielsenRegioneField;
        }
        set
        {
            this.descAreaNielsenRegioneField = value;
        }
    }

    /// <remarks/>
    public byte CodeIstatProvincia
    {
        get
        {
            return this.codeIstatProvinciaField;
        }
        set
        {
            this.codeIstatProvinciaField = value;
        }
    }

    /// <remarks/>
    public string DescIstatProvincia
    {
        get
        {
            return this.descIstatProvinciaField;
        }
        set
        {
            this.descIstatProvinciaField = value;
        }
    }

    /// <remarks/>
    public ushort CodeIstatComune
    {
        get
        {
            return this.codeIstatComuneField;
        }
        set
        {
            this.codeIstatComuneField = value;
        }
    }

    /// <remarks/>
    public string DescIstatComune
    {
        get
        {
            return this.descIstatComuneField;
        }
        set
        {
            this.descIstatComuneField = value;
        }
    }

    /// <remarks/>
    public string CodeCatastale
    {
        get
        {
            return this.codeCatastaleField;
        }
        set
        {
            this.codeCatastaleField = value;
        }
    }

    /// <remarks/>
    public uint PopolazioneComune
    {
        get
        {
            return this.popolazioneComuneField;
        }
        set
        {
            this.popolazioneComuneField = value;
        }
    }

    /// <remarks/>
    public string Dug
    {
        get
        {
            return this.dugField;
        }
        set
        {
            this.dugField = value;
        }
    }

    /// <remarks/>
    public string Duf
    {
        get
        {
            return this.dufField;
        }
        set
        {
            this.dufField = value;
        }
    }

    /// <remarks/>
    public string Civico
    {
        get
        {
            return this.civicoField;
        }
        set
        {
            this.civicoField = value;
        }
    }

    /// <remarks/>
    public string Indirizzo
    {
        get
        {
            return this.indirizzoField;
        }
        set
        {
            this.indirizzoField = value;
        }
    }

    /// <remarks/>
    public ushort Cap
    {
        get
        {
            return this.capField;
        }
        set
        {
            this.capField = value;
        }
    }

    /// <remarks/>
    public string Localita
    {
        get
        {
            return this.localitaField;
        }
        set
        {
            this.localitaField = value;
        }
    }

    /// <remarks/>
    public string CodProvincia
    {
        get
        {
            return this.codProvinciaField;
        }
        set
        {
            this.codProvinciaField = value;
        }
    }

    /// <remarks/>
    public string IndirizzoAbbreviato
    {
        get
        {
            return this.indirizzoAbbreviatoField;
        }
        set
        {
            this.indirizzoAbbreviatoField = value;
        }
    }

    /// <remarks/>
    public string Comune
    {
        get
        {
            return this.comuneField;
        }
        set
        {
            this.comuneField = value;
        }
    }

    /// <remarks/>
    public string FlagPostalizzazione
    {
        get
        {
            return this.flagPostalizzazioneField;
        }
        set
        {
            this.flagPostalizzazioneField = value;
        }
    }

    /// <remarks/>
    public string FlagNoCivico
    {
        get
        {
            return this.flagNoCivicoField;
        }
        set
        {
            this.flagNoCivicoField = value;
        }
    }

    /// <remarks/>
    public byte LivelloGeocodifica
    {
        get
        {
            return this.livelloGeocodificaField;
        }
        set
        {
            this.livelloGeocodificaField = value;
        }
    }

    /// <remarks/>
    public decimal LonX
    {
        get
        {
            return this.lonXField;
        }
        set
        {
            this.lonXField = value;
        }
    }

    /// <remarks/>
    public decimal LatY
    {
        get
        {
            return this.latYField;
        }
        set
        {
            this.latYField = value;
        }
    }

    /// <remarks/>
    public ulong Sezione
    {
        get
        {
            return this.sezioneField;
        }
        set
        {
            this.sezioneField = value;
        }
    }

    /// <remarks/>
    public object NumeroSedi
    {
        get
        {
            return this.numeroSediField;
        }
        set
        {
            this.numeroSediField = value;
        }
    }

    /// <remarks/>
    public byte AddettiDipendenti
    {
        get
        {
            return this.addettiDipendentiField;
        }
        set
        {
            this.addettiDipendentiField = value;
        }
    }

    /// <remarks/>
    public byte AddettiIndipendenti
    {
        get
        {
            return this.addettiIndipendentiField;
        }
        set
        {
            this.addettiIndipendentiField = value;
        }
    }

    /// <remarks/>
    public byte AddettiTotale
    {
        get
        {
            return this.addettiTotaleField;
        }
        set
        {
            this.addettiTotaleField = value;
        }
    }

    /// <remarks/>
    public ushort Anno
    {
        get
        {
            return this.annoField;
        }
        set
        {
            this.annoField = value;
        }
    }

    /// <remarks/>
    public byte Trimestre
    {
        get
        {
            return this.trimestreField;
        }
        set
        {
            this.trimestreField = value;
        }
    }

    /// <remarks/>
    public string FlagIndCommercialista
    {
        get
        {
            return this.flagIndCommercialistaField;
        }
        set
        {
            this.flagIndCommercialistaField = value;
        }
    }

    /// <remarks/>
    public string CodeSezAteco
    {
        get
        {
            return this.codeSezAtecoField;
        }
        set
        {
            this.codeSezAtecoField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootDocumentJsonOutputEsponenti_premium
{

    private RootDocumentJsonOutputEsponenti_premiumListaEsponentiPremium listaEsponentiPremiumField;

    /// <remarks/>
    public RootDocumentJsonOutputEsponenti_premiumListaEsponentiPremium ListaEsponentiPremium
    {
        get
        {
            return this.listaEsponentiPremiumField;
        }
        set
        {
            this.listaEsponentiPremiumField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootDocumentJsonOutputEsponenti_premiumListaEsponentiPremium
{

    private RootDocumentJsonOutputEsponenti_premiumListaEsponentiPremiumEsponentiRaggruppati esponentiRaggruppatiField;

    /// <remarks/>
    public RootDocumentJsonOutputEsponenti_premiumListaEsponentiPremiumEsponentiRaggruppati EsponentiRaggruppati
    {
        get
        {
            return this.esponentiRaggruppatiField;
        }
        set
        {
            this.esponentiRaggruppatiField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootDocumentJsonOutputEsponenti_premiumListaEsponentiPremiumEsponentiRaggruppati
{

    private RootDocumentJsonOutputEsponenti_premiumListaEsponentiPremiumEsponentiRaggruppatiCariche caricheField;

    private byte progressivi_recordField;

    private byte idSoggettoField;

    private string nomeField;

    private string cognomeField;

    private string denominazioneField;

    private string codfiscaleEsponenteField;

    private string flagLegaleRappField;

    private string sessoField;

    private System.DateTime dataNascitaField;

    private string comuneNascitaField;

    private object indirizzoNormField;

    private RootDocumentJsonOutputEsponenti_premiumListaEsponentiPremiumEsponentiRaggruppatiNegativita negativitaField;

    /// <remarks/>
    public RootDocumentJsonOutputEsponenti_premiumListaEsponentiPremiumEsponentiRaggruppatiCariche Cariche
    {
        get
        {
            return this.caricheField;
        }
        set
        {
            this.caricheField = value;
        }
    }

    /// <remarks/>
    public byte Progressivi_record
    {
        get
        {
            return this.progressivi_recordField;
        }
        set
        {
            this.progressivi_recordField = value;
        }
    }

    /// <remarks/>
    public byte IdSoggetto
    {
        get
        {
            return this.idSoggettoField;
        }
        set
        {
            this.idSoggettoField = value;
        }
    }

    /// <remarks/>
    public string Nome
    {
        get
        {
            return this.nomeField;
        }
        set
        {
            this.nomeField = value;
        }
    }

    /// <remarks/>
    public string Cognome
    {
        get
        {
            return this.cognomeField;
        }
        set
        {
            this.cognomeField = value;
        }
    }

    /// <remarks/>
    public string Denominazione
    {
        get
        {
            return this.denominazioneField;
        }
        set
        {
            this.denominazioneField = value;
        }
    }

    /// <remarks/>
    public string CodfiscaleEsponente
    {
        get
        {
            return this.codfiscaleEsponenteField;
        }
        set
        {
            this.codfiscaleEsponenteField = value;
        }
    }

    /// <remarks/>
    public string FlagLegaleRapp
    {
        get
        {
            return this.flagLegaleRappField;
        }
        set
        {
            this.flagLegaleRappField = value;
        }
    }

    /// <remarks/>
    public string Sesso
    {
        get
        {
            return this.sessoField;
        }
        set
        {
            this.sessoField = value;
        }
    }

    /// <remarks/>
    public System.DateTime DataNascita
    {
        get
        {
            return this.dataNascitaField;
        }
        set
        {
            this.dataNascitaField = value;
        }
    }

    /// <remarks/>
    public string ComuneNascita
    {
        get
        {
            return this.comuneNascitaField;
        }
        set
        {
            this.comuneNascitaField = value;
        }
    }

    /// <remarks/>
    public object IndirizzoNorm
    {
        get
        {
            return this.indirizzoNormField;
        }
        set
        {
            this.indirizzoNormField = value;
        }
    }

    /// <remarks/>
    public RootDocumentJsonOutputEsponenti_premiumListaEsponentiPremiumEsponentiRaggruppatiNegativita Negativita
    {
        get
        {
            return this.negativitaField;
        }
        set
        {
            this.negativitaField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootDocumentJsonOutputEsponenti_premiumListaEsponentiPremiumEsponentiRaggruppatiCariche
{

    private byte progRecordField;

    private string codeCaricaField;

    private string descCaricaField;

    private System.DateTime dataInizioCaricaField;

    private System.DateTime dataAttoNominaField;

    private string durataField;

    private System.DateTime dataPresentazioneField;

    private System.DateTime dataIscrizioneField;

    /// <remarks/>
    public byte ProgRecord
    {
        get
        {
            return this.progRecordField;
        }
        set
        {
            this.progRecordField = value;
        }
    }

    /// <remarks/>
    public string CodeCarica
    {
        get
        {
            return this.codeCaricaField;
        }
        set
        {
            this.codeCaricaField = value;
        }
    }

    /// <remarks/>
    public string DescCarica
    {
        get
        {
            return this.descCaricaField;
        }
        set
        {
            this.descCaricaField = value;
        }
    }

    /// <remarks/>
    public System.DateTime DataInizioCarica
    {
        get
        {
            return this.dataInizioCaricaField;
        }
        set
        {
            this.dataInizioCaricaField = value;
        }
    }

    /// <remarks/>
    public System.DateTime DataAttoNomina
    {
        get
        {
            return this.dataAttoNominaField;
        }
        set
        {
            this.dataAttoNominaField = value;
        }
    }

    /// <remarks/>
    public string Durata
    {
        get
        {
            return this.durataField;
        }
        set
        {
            this.durataField = value;
        }
    }

    /// <remarks/>
    public System.DateTime DataPresentazione
    {
        get
        {
            return this.dataPresentazioneField;
        }
        set
        {
            this.dataPresentazioneField = value;
        }
    }

    /// <remarks/>
    public System.DateTime DataIscrizione
    {
        get
        {
            return this.dataIscrizioneField;
        }
        set
        {
            this.dataIscrizioneField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootDocumentJsonOutputEsponenti_premiumListaEsponentiPremiumEsponentiRaggruppatiNegativita
{

    private string negativitaField;

    private string codicefiscaleField;

    private byte numProtestiField;

    private byte numPregTotaleField;

    private byte numPcorField;

    private string flagDomConcordatoField;

    private string fasciaEstesoField;

    private string fasciaField;

    private string flagPregiudizievoliField;

    private string flagProtestiField;

    private string flagProcedureField;

    /// <remarks/>
    public string Negativita
    {
        get
        {
            return this.negativitaField;
        }
        set
        {
            this.negativitaField = value;
        }
    }

    /// <remarks/>
    public string Codicefiscale
    {
        get
        {
            return this.codicefiscaleField;
        }
        set
        {
            this.codicefiscaleField = value;
        }
    }

    /// <remarks/>
    public byte NumProtesti
    {
        get
        {
            return this.numProtestiField;
        }
        set
        {
            this.numProtestiField = value;
        }
    }

    /// <remarks/>
    public byte NumPregTotale
    {
        get
        {
            return this.numPregTotaleField;
        }
        set
        {
            this.numPregTotaleField = value;
        }
    }

    /// <remarks/>
    public byte NumPcor
    {
        get
        {
            return this.numPcorField;
        }
        set
        {
            this.numPcorField = value;
        }
    }

    /// <remarks/>
    public string FlagDomConcordato
    {
        get
        {
            return this.flagDomConcordatoField;
        }
        set
        {
            this.flagDomConcordatoField = value;
        }
    }

    /// <remarks/>
    public string FasciaEsteso
    {
        get
        {
            return this.fasciaEstesoField;
        }
        set
        {
            this.fasciaEstesoField = value;
        }
    }

    /// <remarks/>
    public string Fascia
    {
        get
        {
            return this.fasciaField;
        }
        set
        {
            this.fasciaField = value;
        }
    }

    /// <remarks/>
    public string FlagPregiudizievoli
    {
        get
        {
            return this.flagPregiudizievoliField;
        }
        set
        {
            this.flagPregiudizievoliField = value;
        }
    }

    /// <remarks/>
    public string FlagProtesti
    {
        get
        {
            return this.flagProtestiField;
        }
        set
        {
            this.flagProtestiField = value;
        }
    }

    /// <remarks/>
    public string FlagProcedure
    {
        get
        {
            return this.flagProcedureField;
        }
        set
        {
            this.flagProcedureField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootDocumentJsonOutputIndiciTerritoriali
{

    private RootDocumentJsonOutputIndiciTerritorialiIndiciTerritoriali indiciTerritorialiField;

    private object idAzienda7dField;

    private object codeIstatComuneField;

    private object pPctField;

    private object cPctField;

    private object sPctField;

    private object pItaliaPctField;

    private object cItaliaPctField;

    private object sItaliaPctField;

    private object distrettoSpecField;

    private object codeDistrettoSpecField;

    private object atecoDistrettoCompField;

    private object idxProtestiNormField;

    private object idxProcedureNormField;

    private object idxPregiudizievoliNormField;

    private object idxProtestiItaNormField;

    private object idxProcedureItaNormField;

    private object idxPregiudizievoliItaNormField;

    private object idxProtestiComField;

    private object idxProcedureComField;

    private object idxPregiudizievoliComField;

    private object idxProtestiItaField;

    private object idxProcedureItaField;

    private object idxPregiudizievoliItaField;

    private object idxTurismoNormField;

    private object idxTurismoMediaitaliaNormField;

    private object sez2011Field;

    private object descrTipPrevField;

    private object redPcNormField;

    private object redPcNazNormField;

    private object codeAtecoDivisioneField;

    private object idxProtestiNormdivField;

    private object idxProcedureNormdivField;

    private object idxPregiudizievoliNormdivField;

    private object idxProtestiItaNormdivField;

    private object idxProcedureItaNormdivField;

    private object idxPregiudizievoliItaNormdivField;

    private object idxProtestiDivField;

    private object idxProcedureDivField;

    private object idxPregiudizievoliDivField;

    /// <remarks/>
    public RootDocumentJsonOutputIndiciTerritorialiIndiciTerritoriali IndiciTerritoriali
    {
        get
        {
            return this.indiciTerritorialiField;
        }
        set
        {
            this.indiciTerritorialiField = value;
        }
    }

    /// <remarks/>
    public object IdAzienda7d
    {
        get
        {
            return this.idAzienda7dField;
        }
        set
        {
            this.idAzienda7dField = value;
        }
    }

    /// <remarks/>
    public object CodeIstatComune
    {
        get
        {
            return this.codeIstatComuneField;
        }
        set
        {
            this.codeIstatComuneField = value;
        }
    }

    /// <remarks/>
    public object PPct
    {
        get
        {
            return this.pPctField;
        }
        set
        {
            this.pPctField = value;
        }
    }

    /// <remarks/>
    public object CPct
    {
        get
        {
            return this.cPctField;
        }
        set
        {
            this.cPctField = value;
        }
    }

    /// <remarks/>
    public object SPct
    {
        get
        {
            return this.sPctField;
        }
        set
        {
            this.sPctField = value;
        }
    }

    /// <remarks/>
    public object PItaliaPct
    {
        get
        {
            return this.pItaliaPctField;
        }
        set
        {
            this.pItaliaPctField = value;
        }
    }

    /// <remarks/>
    public object CItaliaPct
    {
        get
        {
            return this.cItaliaPctField;
        }
        set
        {
            this.cItaliaPctField = value;
        }
    }

    /// <remarks/>
    public object SItaliaPct
    {
        get
        {
            return this.sItaliaPctField;
        }
        set
        {
            this.sItaliaPctField = value;
        }
    }

    /// <remarks/>
    public object DistrettoSpec
    {
        get
        {
            return this.distrettoSpecField;
        }
        set
        {
            this.distrettoSpecField = value;
        }
    }

    /// <remarks/>
    public object CodeDistrettoSpec
    {
        get
        {
            return this.codeDistrettoSpecField;
        }
        set
        {
            this.codeDistrettoSpecField = value;
        }
    }

    /// <remarks/>
    public object AtecoDistrettoComp
    {
        get
        {
            return this.atecoDistrettoCompField;
        }
        set
        {
            this.atecoDistrettoCompField = value;
        }
    }

    /// <remarks/>
    public object IdxProtestiNorm
    {
        get
        {
            return this.idxProtestiNormField;
        }
        set
        {
            this.idxProtestiNormField = value;
        }
    }

    /// <remarks/>
    public object IdxProcedureNorm
    {
        get
        {
            return this.idxProcedureNormField;
        }
        set
        {
            this.idxProcedureNormField = value;
        }
    }

    /// <remarks/>
    public object IdxPregiudizievoliNorm
    {
        get
        {
            return this.idxPregiudizievoliNormField;
        }
        set
        {
            this.idxPregiudizievoliNormField = value;
        }
    }

    /// <remarks/>
    public object IdxProtestiItaNorm
    {
        get
        {
            return this.idxProtestiItaNormField;
        }
        set
        {
            this.idxProtestiItaNormField = value;
        }
    }

    /// <remarks/>
    public object IdxProcedureItaNorm
    {
        get
        {
            return this.idxProcedureItaNormField;
        }
        set
        {
            this.idxProcedureItaNormField = value;
        }
    }

    /// <remarks/>
    public object IdxPregiudizievoliItaNorm
    {
        get
        {
            return this.idxPregiudizievoliItaNormField;
        }
        set
        {
            this.idxPregiudizievoliItaNormField = value;
        }
    }

    /// <remarks/>
    public object IdxProtestiCom
    {
        get
        {
            return this.idxProtestiComField;
        }
        set
        {
            this.idxProtestiComField = value;
        }
    }

    /// <remarks/>
    public object IdxProcedureCom
    {
        get
        {
            return this.idxProcedureComField;
        }
        set
        {
            this.idxProcedureComField = value;
        }
    }

    /// <remarks/>
    public object IdxPregiudizievoliCom
    {
        get
        {
            return this.idxPregiudizievoliComField;
        }
        set
        {
            this.idxPregiudizievoliComField = value;
        }
    }

    /// <remarks/>
    public object IdxProtestiIta
    {
        get
        {
            return this.idxProtestiItaField;
        }
        set
        {
            this.idxProtestiItaField = value;
        }
    }

    /// <remarks/>
    public object IdxProcedureIta
    {
        get
        {
            return this.idxProcedureItaField;
        }
        set
        {
            this.idxProcedureItaField = value;
        }
    }

    /// <remarks/>
    public object IdxPregiudizievoliIta
    {
        get
        {
            return this.idxPregiudizievoliItaField;
        }
        set
        {
            this.idxPregiudizievoliItaField = value;
        }
    }

    /// <remarks/>
    public object IdxTurismoNorm
    {
        get
        {
            return this.idxTurismoNormField;
        }
        set
        {
            this.idxTurismoNormField = value;
        }
    }

    /// <remarks/>
    public object IdxTurismoMediaitaliaNorm
    {
        get
        {
            return this.idxTurismoMediaitaliaNormField;
        }
        set
        {
            this.idxTurismoMediaitaliaNormField = value;
        }
    }

    /// <remarks/>
    public object Sez2011
    {
        get
        {
            return this.sez2011Field;
        }
        set
        {
            this.sez2011Field = value;
        }
    }

    /// <remarks/>
    public object DescrTipPrev
    {
        get
        {
            return this.descrTipPrevField;
        }
        set
        {
            this.descrTipPrevField = value;
        }
    }

    /// <remarks/>
    public object RedPcNorm
    {
        get
        {
            return this.redPcNormField;
        }
        set
        {
            this.redPcNormField = value;
        }
    }

    /// <remarks/>
    public object RedPcNazNorm
    {
        get
        {
            return this.redPcNazNormField;
        }
        set
        {
            this.redPcNazNormField = value;
        }
    }

    /// <remarks/>
    public object CodeAtecoDivisione
    {
        get
        {
            return this.codeAtecoDivisioneField;
        }
        set
        {
            this.codeAtecoDivisioneField = value;
        }
    }

    /// <remarks/>
    public object IdxProtestiNormdiv
    {
        get
        {
            return this.idxProtestiNormdivField;
        }
        set
        {
            this.idxProtestiNormdivField = value;
        }
    }

    /// <remarks/>
    public object IdxProcedureNormdiv
    {
        get
        {
            return this.idxProcedureNormdivField;
        }
        set
        {
            this.idxProcedureNormdivField = value;
        }
    }

    /// <remarks/>
    public object IdxPregiudizievoliNormdiv
    {
        get
        {
            return this.idxPregiudizievoliNormdivField;
        }
        set
        {
            this.idxPregiudizievoliNormdivField = value;
        }
    }

    /// <remarks/>
    public object IdxProtestiItaNormdiv
    {
        get
        {
            return this.idxProtestiItaNormdivField;
        }
        set
        {
            this.idxProtestiItaNormdivField = value;
        }
    }

    /// <remarks/>
    public object IdxProcedureItaNormdiv
    {
        get
        {
            return this.idxProcedureItaNormdivField;
        }
        set
        {
            this.idxProcedureItaNormdivField = value;
        }
    }

    /// <remarks/>
    public object IdxPregiudizievoliItaNormdiv
    {
        get
        {
            return this.idxPregiudizievoliItaNormdivField;
        }
        set
        {
            this.idxPregiudizievoliItaNormdivField = value;
        }
    }

    /// <remarks/>
    public object IdxProtestiDiv
    {
        get
        {
            return this.idxProtestiDivField;
        }
        set
        {
            this.idxProtestiDivField = value;
        }
    }

    /// <remarks/>
    public object IdxProcedureDiv
    {
        get
        {
            return this.idxProcedureDivField;
        }
        set
        {
            this.idxProcedureDivField = value;
        }
    }

    /// <remarks/>
    public object IdxPregiudizievoliDiv
    {
        get
        {
            return this.idxPregiudizievoliDivField;
        }
        set
        {
            this.idxPregiudizievoliDivField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootDocumentJsonOutputIndiciTerritorialiIndiciTerritoriali
{

    private object indiciTerritorialiField;

    private uint idAzienda7dField;

    private ushort codeIstatComuneField;

    private decimal pPctField;

    private decimal cPctField;

    private decimal sPctField;

    private decimal pItaliaPctField;

    private decimal cItaliaPctField;

    private decimal sItaliaPctField;

    private string distrettoSpecField;

    private byte codeDistrettoSpecField;

    private string atecoDistrettoCompField;

    private decimal idxProtestiNormField;

    private decimal idxProcedureNormField;

    private decimal idxPregiudizievoliNormField;

    private decimal idxProtestiItaNormField;

    private decimal idxProcedureItaNormField;

    private decimal idxPregiudizievoliItaNormField;

    private decimal idxProtestiComField;

    private decimal idxProcedureComField;

    private decimal idxPregiudizievoliComField;

    private decimal idxProtestiItaField;

    private decimal idxProcedureItaField;

    private decimal idxPregiudizievoliItaField;

    private decimal idxTurismoNormField;

    private decimal idxTurismoMediaitaliaNormField;

    private ulong sez2011Field;

    private string descrTipPrevField;

    private decimal redPcNormField;

    private decimal redPcNazNormField;

    private byte codeAtecoDivisioneField;

    private decimal idxProtestiNormdivField;

    private decimal idxProcedureNormdivField;

    private decimal idxPregiudizievoliNormdivField;

    private decimal idxProtestiItaNormdivField;

    private decimal idxProcedureItaNormdivField;

    private decimal idxPregiudizievoliItaNormdivField;

    private decimal idxProtestiDivField;

    private decimal idxProcedureDivField;

    private decimal idxPregiudizievoliDivField;

    /// <remarks/>
    public object IndiciTerritoriali
    {
        get
        {
            return this.indiciTerritorialiField;
        }
        set
        {
            this.indiciTerritorialiField = value;
        }
    }

    /// <remarks/>
    public uint IdAzienda7d
    {
        get
        {
            return this.idAzienda7dField;
        }
        set
        {
            this.idAzienda7dField = value;
        }
    }

    /// <remarks/>
    public ushort CodeIstatComune
    {
        get
        {
            return this.codeIstatComuneField;
        }
        set
        {
            this.codeIstatComuneField = value;
        }
    }

    /// <remarks/>
    public decimal PPct
    {
        get
        {
            return this.pPctField;
        }
        set
        {
            this.pPctField = value;
        }
    }

    /// <remarks/>
    public decimal CPct
    {
        get
        {
            return this.cPctField;
        }
        set
        {
            this.cPctField = value;
        }
    }

    /// <remarks/>
    public decimal SPct
    {
        get
        {
            return this.sPctField;
        }
        set
        {
            this.sPctField = value;
        }
    }

    /// <remarks/>
    public decimal PItaliaPct
    {
        get
        {
            return this.pItaliaPctField;
        }
        set
        {
            this.pItaliaPctField = value;
        }
    }

    /// <remarks/>
    public decimal CItaliaPct
    {
        get
        {
            return this.cItaliaPctField;
        }
        set
        {
            this.cItaliaPctField = value;
        }
    }

    /// <remarks/>
    public decimal SItaliaPct
    {
        get
        {
            return this.sItaliaPctField;
        }
        set
        {
            this.sItaliaPctField = value;
        }
    }

    /// <remarks/>
    public string DistrettoSpec
    {
        get
        {
            return this.distrettoSpecField;
        }
        set
        {
            this.distrettoSpecField = value;
        }
    }

    /// <remarks/>
    public byte CodeDistrettoSpec
    {
        get
        {
            return this.codeDistrettoSpecField;
        }
        set
        {
            this.codeDistrettoSpecField = value;
        }
    }

    /// <remarks/>
    public string AtecoDistrettoComp
    {
        get
        {
            return this.atecoDistrettoCompField;
        }
        set
        {
            this.atecoDistrettoCompField = value;
        }
    }

    /// <remarks/>
    public decimal IdxProtestiNorm
    {
        get
        {
            return this.idxProtestiNormField;
        }
        set
        {
            this.idxProtestiNormField = value;
        }
    }

    /// <remarks/>
    public decimal IdxProcedureNorm
    {
        get
        {
            return this.idxProcedureNormField;
        }
        set
        {
            this.idxProcedureNormField = value;
        }
    }

    /// <remarks/>
    public decimal IdxPregiudizievoliNorm
    {
        get
        {
            return this.idxPregiudizievoliNormField;
        }
        set
        {
            this.idxPregiudizievoliNormField = value;
        }
    }

    /// <remarks/>
    public decimal IdxProtestiItaNorm
    {
        get
        {
            return this.idxProtestiItaNormField;
        }
        set
        {
            this.idxProtestiItaNormField = value;
        }
    }

    /// <remarks/>
    public decimal IdxProcedureItaNorm
    {
        get
        {
            return this.idxProcedureItaNormField;
        }
        set
        {
            this.idxProcedureItaNormField = value;
        }
    }

    /// <remarks/>
    public decimal IdxPregiudizievoliItaNorm
    {
        get
        {
            return this.idxPregiudizievoliItaNormField;
        }
        set
        {
            this.idxPregiudizievoliItaNormField = value;
        }
    }

    /// <remarks/>
    public decimal IdxProtestiCom
    {
        get
        {
            return this.idxProtestiComField;
        }
        set
        {
            this.idxProtestiComField = value;
        }
    }

    /// <remarks/>
    public decimal IdxProcedureCom
    {
        get
        {
            return this.idxProcedureComField;
        }
        set
        {
            this.idxProcedureComField = value;
        }
    }

    /// <remarks/>
    public decimal IdxPregiudizievoliCom
    {
        get
        {
            return this.idxPregiudizievoliComField;
        }
        set
        {
            this.idxPregiudizievoliComField = value;
        }
    }

    /// <remarks/>
    public decimal IdxProtestiIta
    {
        get
        {
            return this.idxProtestiItaField;
        }
        set
        {
            this.idxProtestiItaField = value;
        }
    }

    /// <remarks/>
    public decimal IdxProcedureIta
    {
        get
        {
            return this.idxProcedureItaField;
        }
        set
        {
            this.idxProcedureItaField = value;
        }
    }

    /// <remarks/>
    public decimal IdxPregiudizievoliIta
    {
        get
        {
            return this.idxPregiudizievoliItaField;
        }
        set
        {
            this.idxPregiudizievoliItaField = value;
        }
    }

    /// <remarks/>
    public decimal IdxTurismoNorm
    {
        get
        {
            return this.idxTurismoNormField;
        }
        set
        {
            this.idxTurismoNormField = value;
        }
    }

    /// <remarks/>
    public decimal IdxTurismoMediaitaliaNorm
    {
        get
        {
            return this.idxTurismoMediaitaliaNormField;
        }
        set
        {
            this.idxTurismoMediaitaliaNormField = value;
        }
    }

    /// <remarks/>
    public ulong Sez2011
    {
        get
        {
            return this.sez2011Field;
        }
        set
        {
            this.sez2011Field = value;
        }
    }

    /// <remarks/>
    public string DescrTipPrev
    {
        get
        {
            return this.descrTipPrevField;
        }
        set
        {
            this.descrTipPrevField = value;
        }
    }

    /// <remarks/>
    public decimal RedPcNorm
    {
        get
        {
            return this.redPcNormField;
        }
        set
        {
            this.redPcNormField = value;
        }
    }

    /// <remarks/>
    public decimal RedPcNazNorm
    {
        get
        {
            return this.redPcNazNormField;
        }
        set
        {
            this.redPcNazNormField = value;
        }
    }

    /// <remarks/>
    public byte CodeAtecoDivisione
    {
        get
        {
            return this.codeAtecoDivisioneField;
        }
        set
        {
            this.codeAtecoDivisioneField = value;
        }
    }

    /// <remarks/>
    public decimal IdxProtestiNormdiv
    {
        get
        {
            return this.idxProtestiNormdivField;
        }
        set
        {
            this.idxProtestiNormdivField = value;
        }
    }

    /// <remarks/>
    public decimal IdxProcedureNormdiv
    {
        get
        {
            return this.idxProcedureNormdivField;
        }
        set
        {
            this.idxProcedureNormdivField = value;
        }
    }

    /// <remarks/>
    public decimal IdxPregiudizievoliNormdiv
    {
        get
        {
            return this.idxPregiudizievoliNormdivField;
        }
        set
        {
            this.idxPregiudizievoliNormdivField = value;
        }
    }

    /// <remarks/>
    public decimal IdxProtestiItaNormdiv
    {
        get
        {
            return this.idxProtestiItaNormdivField;
        }
        set
        {
            this.idxProtestiItaNormdivField = value;
        }
    }

    /// <remarks/>
    public decimal IdxProcedureItaNormdiv
    {
        get
        {
            return this.idxProcedureItaNormdivField;
        }
        set
        {
            this.idxProcedureItaNormdivField = value;
        }
    }

    /// <remarks/>
    public decimal IdxPregiudizievoliItaNormdiv
    {
        get
        {
            return this.idxPregiudizievoliItaNormdivField;
        }
        set
        {
            this.idxPregiudizievoliItaNormdivField = value;
        }
    }

    /// <remarks/>
    public decimal IdxProtestiDiv
    {
        get
        {
            return this.idxProtestiDivField;
        }
        set
        {
            this.idxProtestiDivField = value;
        }
    }

    /// <remarks/>
    public decimal IdxProcedureDiv
    {
        get
        {
            return this.idxProcedureDivField;
        }
        set
        {
            this.idxProcedureDivField = value;
        }
    }

    /// <remarks/>
    public decimal IdxPregiudizievoliDiv
    {
        get
        {
            return this.idxPregiudizievoliDivField;
        }
        set
        {
            this.idxPregiudizievoliDivField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootDocumentJsonOutputNegativita
{

    private string negativitaField;

    private ulong codicefiscaleField;

    private byte numProtestiField;

    private byte numPregTotaleField;

    private byte numPcorField;

    private string flagDomConcordatoField;

    private string fasciaEstesoField;

    private string fasciaField;

    private string flagPregiudizievoliField;

    private string flagProtestiField;

    private string flagProcedureField;

    /// <remarks/>
    public string Negativita
    {
        get
        {
            return this.negativitaField;
        }
        set
        {
            this.negativitaField = value;
        }
    }

    /// <remarks/>
    public ulong Codicefiscale
    {
        get
        {
            return this.codicefiscaleField;
        }
        set
        {
            this.codicefiscaleField = value;
        }
    }

    /// <remarks/>
    public byte NumProtesti
    {
        get
        {
            return this.numProtestiField;
        }
        set
        {
            this.numProtestiField = value;
        }
    }

    /// <remarks/>
    public byte NumPregTotale
    {
        get
        {
            return this.numPregTotaleField;
        }
        set
        {
            this.numPregTotaleField = value;
        }
    }

    /// <remarks/>
    public byte NumPcor
    {
        get
        {
            return this.numPcorField;
        }
        set
        {
            this.numPcorField = value;
        }
    }

    /// <remarks/>
    public string FlagDomConcordato
    {
        get
        {
            return this.flagDomConcordatoField;
        }
        set
        {
            this.flagDomConcordatoField = value;
        }
    }

    /// <remarks/>
    public string FasciaEsteso
    {
        get
        {
            return this.fasciaEstesoField;
        }
        set
        {
            this.fasciaEstesoField = value;
        }
    }

    /// <remarks/>
    public string Fascia
    {
        get
        {
            return this.fasciaField;
        }
        set
        {
            this.fasciaField = value;
        }
    }

    /// <remarks/>
    public string FlagPregiudizievoli
    {
        get
        {
            return this.flagPregiudizievoliField;
        }
        set
        {
            this.flagPregiudizievoliField = value;
        }
    }

    /// <remarks/>
    public string FlagProtesti
    {
        get
        {
            return this.flagProtestiField;
        }
        set
        {
            this.flagProtestiField = value;
        }
    }

    /// <remarks/>
    public string FlagProcedure
    {
        get
        {
            return this.flagProcedureField;
        }
        set
        {
            this.flagProcedureField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootDocumentJsonOutputOutputRatingFido
{

    private ulong codicefiscaleField;

    private uint idAzienda7dField;

    private string codeClasseGiuridicaField;

    private byte ratingField;

    private string classeRatingField;

    private string descClasseRatingField;

    private string sottoclasseField;

    private ushort fidoField;

    private byte scoreBilancioField;

    private ushort annoUltimoBilancioField;

    private string descClasseScoreBilancioField;

    /// <remarks/>
    public ulong Codicefiscale
    {
        get
        {
            return this.codicefiscaleField;
        }
        set
        {
            this.codicefiscaleField = value;
        }
    }

    /// <remarks/>
    public uint IdAzienda7d
    {
        get
        {
            return this.idAzienda7dField;
        }
        set
        {
            this.idAzienda7dField = value;
        }
    }

    /// <remarks/>
    public string CodeClasseGiuridica
    {
        get
        {
            return this.codeClasseGiuridicaField;
        }
        set
        {
            this.codeClasseGiuridicaField = value;
        }
    }

    /// <remarks/>
    public byte Rating
    {
        get
        {
            return this.ratingField;
        }
        set
        {
            this.ratingField = value;
        }
    }

    /// <remarks/>
    public string ClasseRating
    {
        get
        {
            return this.classeRatingField;
        }
        set
        {
            this.classeRatingField = value;
        }
    }

    /// <remarks/>
    public string DescClasseRating
    {
        get
        {
            return this.descClasseRatingField;
        }
        set
        {
            this.descClasseRatingField = value;
        }
    }

    /// <remarks/>
    public string Sottoclasse
    {
        get
        {
            return this.sottoclasseField;
        }
        set
        {
            this.sottoclasseField = value;
        }
    }

    /// <remarks/>
    public ushort Fido
    {
        get
        {
            return this.fidoField;
        }
        set
        {
            this.fidoField = value;
        }
    }

    /// <remarks/>
    public byte ScoreBilancio
    {
        get
        {
            return this.scoreBilancioField;
        }
        set
        {
            this.scoreBilancioField = value;
        }
    }

    /// <remarks/>
    public ushort AnnoUltimoBilancio
    {
        get
        {
            return this.annoUltimoBilancioField;
        }
        set
        {
            this.annoUltimoBilancioField = value;
        }
    }

    /// <remarks/>
    public string DescClasseScoreBilancio
    {
        get
        {
            return this.descClasseScoreBilancioField;
        }
        set
        {
            this.descClasseScoreBilancioField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootDocumentJsonOutputOggetto_sociale
{

    private string oggettoSocialeField;

    /// <remarks/>
    public string OggettoSociale
    {
        get
        {
            return this.oggettoSocialeField;
        }
        set
        {
            this.oggettoSocialeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootInput
{

    private RootInputParameters parametersField;

    private string token_utenteField;

    private object client_idField;

    private string codici_serviziField;

    private object id_richiesta_padreField;

    private byte document_typeField;

    private byte encodingField;

    private object input_negativitaField;

    /// <remarks/>
    public RootInputParameters Parameters
    {
        get
        {
            return this.parametersField;
        }
        set
        {
            this.parametersField = value;
        }
    }

    /// <remarks/>
    public string Token_utente
    {
        get
        {
            return this.token_utenteField;
        }
        set
        {
            this.token_utenteField = value;
        }
    }

    /// <remarks/>
    public object Client_id
    {
        get
        {
            return this.client_idField;
        }
        set
        {
            this.client_idField = value;
        }
    }

    /// <remarks/>
    public string Codici_servizi
    {
        get
        {
            return this.codici_serviziField;
        }
        set
        {
            this.codici_serviziField = value;
        }
    }

    /// <remarks/>
    public object Id_richiesta_padre
    {
        get
        {
            return this.id_richiesta_padreField;
        }
        set
        {
            this.id_richiesta_padreField = value;
        }
    }

    /// <remarks/>
    public byte Document_type
    {
        get
        {
            return this.document_typeField;
        }
        set
        {
            this.document_typeField = value;
        }
    }

    /// <remarks/>
    public byte Encoding
    {
        get
        {
            return this.encodingField;
        }
        set
        {
            this.encodingField = value;
        }
    }

    /// <remarks/>
    public object Input_negativita
    {
        get
        {
            return this.input_negativitaField;
        }
        set
        {
            this.input_negativitaField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootInputParameters
{

    private string nameField;

    private uint valueField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public uint Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class RootAccount_information
{

    private ushort plafondField;

    private object quantitaField;

    private decimal prezzoField;

    private decimal consumatoField;

    private object consumato_flatField;

    private System.DateTime data_scadenzaField;

    private object data_richiestaField;

    private uint id_richiestaField;

    private byte statoField;

    private object stornoField;

    /// <remarks/>
    public ushort Plafond
    {
        get
        {
            return this.plafondField;
        }
        set
        {
            this.plafondField = value;
        }
    }

    /// <remarks/>
    public object Quantita
    {
        get
        {
            return this.quantitaField;
        }
        set
        {
            this.quantitaField = value;
        }
    }

    /// <remarks/>
    public decimal Prezzo
    {
        get
        {
            return this.prezzoField;
        }
        set
        {
            this.prezzoField = value;
        }
    }

    /// <remarks/>
    public decimal Consumato
    {
        get
        {
            return this.consumatoField;
        }
        set
        {
            this.consumatoField = value;
        }
    }

    /// <remarks/>
    public object Consumato_flat
    {
        get
        {
            return this.consumato_flatField;
        }
        set
        {
            this.consumato_flatField = value;
        }
    }

    /// <remarks/>
    public System.DateTime Data_scadenza
    {
        get
        {
            return this.data_scadenzaField;
        }
        set
        {
            this.data_scadenzaField = value;
        }
    }

    /// <remarks/>
    public object Data_richiesta
    {
        get
        {
            return this.data_richiestaField;
        }
        set
        {
            this.data_richiestaField = value;
        }
    }

    /// <remarks/>
    public uint Id_richiesta
    {
        get
        {
            return this.id_richiestaField;
        }
        set
        {
            this.id_richiestaField = value;
        }
    }

    /// <remarks/>
    public byte Stato
    {
        get
        {
            return this.statoField;
        }
        set
        {
            this.statoField = value;
        }
    }

    /// <remarks/>
    public object Storno
    {
        get
        {
            return this.stornoField;
        }
        set
        {
            this.stornoField = value;
        }
    }
}

