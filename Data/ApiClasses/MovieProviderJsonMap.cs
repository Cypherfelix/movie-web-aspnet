namespace MovieWeb.Data.ApiClasses
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
#pragma warning disable IDE1006 // Naming Styles
    public class AR
    {
        public string? link
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class AT
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class AU
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
    }

    public class BE
    {
        public string? link
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
    }

    public class BR
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
    }

    public class Buy
    {
        public int display_priority
        {
            get; set;
        }
        public string? logo_path
        {
            get; set;
        }
        public int provider_id
        {
            get; set;
        }
        public string? provider_name
        {
            get; set;
        }
    }

    public class CA
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class CH
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
    }

    public class CL
    {
        public string? link
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
    }

    public class CO
    {
        public string? link
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class CZ
    {
        public string? link
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
    }

    public class DE
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class DK
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
    }

    public class EC
    {
        public string? link
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
    }

    public class EE
    {
        public string? link
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
    }

    public class ES
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class FI
    {
        public string? link
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
    }

    public class Flatrate
    {
        public int display_priority
        {
            get; set;
        }
        public string? logo_path
        {
            get; set;
        }
        public int provider_id
        {
            get; set;
        }
        public string? provider_name
        {
            get; set;
        }
    }

    public class FR
    {
        public string? link
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
    }

    public class GB
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class GR
    {
        public string? link
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class HU
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
    }

    public class ID
    {
        public string? link
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class IE
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class IN
    {
        public string? link
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
    }

    public class IT
    {
        public string? link
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
    }

    public class JP
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class KR
    {
        public string? link
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
    }

    public class LT
    {
        public string? link
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
    }

    public class LV
    {
        public string? link
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
    }

    public class MX
    {
        public string? link
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class MY
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class NL
    {
        public string? link
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
    }

    public class NO
    {
        public string? link
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
    }

    public class NZ
    {
        public string? link
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
    }

    public class PE
    {
        public string? link
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class PH
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
    }

    public class PL
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class PT
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class Rent
    {
        public int display_priority
        {
            get; set;
        }
        public string? logo_path
        {
            get; set;
        }
        public int provider_id
        {
            get; set;
        }
        public string? provider_name
        {
            get; set;
        }
    }

    public class Results
    {
        public AR? AR
        {
            get; set;
        }
        public AT? AT
        {
            get; set;
        }
        public AU? AU
        {
            get; set;
        }
        public BE? BE
        {
            get; set;
        }
        public BR? BR
        {
            get; set;
        }
        public CA? CA
        {
            get; set;
        }
        public CH? CH
        {
            get; set;
        }
        public CL? CL
        {
            get; set;
        }
        public CO? CO
        {
            get; set;
        }
        public CZ? CZ
        {
            get; set;
        }
        public DE? DE
        {
            get; set;
        }
        public DK? DK
        {
            get; set;
        }
        public EC? EC
        {
            get; set;
        }
        public EE? EE
        {
            get; set;
        }
        public ES? ES
        {
            get; set;
        }
        public FI? FI
        {
            get; set;
        }
        public FR? FR
        {
            get; set;
        }
        public GB? GB
        {
            get; set;
        }
        public GR? GR
        {
            get; set;
        }
        public HU? HU
        {
            get; set;
        }
        public ID? ID
        {
            get; set;
        }
        public IE? IE
        {
            get; set;
        }
        public IN? IN
        {
            get; set;
        }
        public IT? IT
        {
            get; set;
        }
        public JP? JP
        {
            get; set;
        }
        public KR? KR
        {
            get; set;
        }
        public LT? LT
        {
            get; set;
        }
        public LV? LV
        {
            get; set;
        }
        public MX? MX
        {
            get; set;
        }
        public MY? MY
        {
            get; set;
        }
        public NL? NL
        {
            get; set;
        }
        public NO? NO
        {
            get; set;
        }
        public NZ? NZ
        {
            get; set;
        }
        public PE? PE
        {
            get; set;
        }
        public PH? PH
        {
            get; set;
        }
        public PL? PL
        {
            get; set;
        }
        public PT? PT
        {
            get; set;
        }
        public RO? RO
        {
            get; set;
        }
        public RU? RU
        {
            get; set;
        }
        public SE? SE
        {
            get; set;
        }
        public SG? SG
        {
            get; set;
        }
        public TH? TH
        {
            get; set;
        }
        public TR? TR
        {
            get; set;
        }
        public US? US
        {
            get; set;
        }
        public VE? VE
        {
            get; set;
        }
        public ZA? ZA
        {
            get; set;
        }
    }

    public class RO
    {
        public string? link
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
    }

    public class MovieProviderJsonMap
    {
        public int id
        {
            get; set;
        }
        public Results? results
        {
            get; set;
        }
    }

    public class RU
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class SE
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class SG
    {
        public string? link
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
    }

    public class TH
    {
        public string? link
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class TR
    {
        public string? link
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
    }

    public class US
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
    }

    public class VE
    {
        public string? link
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
    }

    public class ZA
    {
        public string? link
        {
            get; set;
        }
        public List<Rent>? rent
        {
            get; set;
        }
        public List<Buy>? buy
        {
            get; set;
        }
        public List<Flatrate>? flatrate
        {
            get; set;
        }
    }


}
