using System.Collections.Specialized;

// BORTREMMAD KOD LÅNGT NER

namespace Manicomio.SwosPlayerFinder.Core
{
    public class Countries
    {
        private static NameValueCollection _playerCountries;

        private static NameValueCollection _teamCountries;

        static Countries()
        {
            _playerCountries = new NameValueCollection();

            _playerCountries.Add("0", "ALBANIA");
            _playerCountries.Add("1", "AUSTRIA");
            _playerCountries.Add("2", "BELGIUM");
            _playerCountries.Add("3", "BULGARIA");
            _playerCountries.Add("4", "CROATIA");
            _playerCountries.Add("5", "CYPRUS");
            _playerCountries.Add("6", "CZECH REP");
            _playerCountries.Add("7", "DENMARK");
            _playerCountries.Add("8", "ENGLAND");
            _playerCountries.Add("9", "ESTONIA");
            _playerCountries.Add("10", "FAEROE ISL");
            _playerCountries.Add("11", "FINLAND");
            _playerCountries.Add("12", "FRANCE");
            _playerCountries.Add("13", "GERMANY");
            _playerCountries.Add("14", "GREECE");
            _playerCountries.Add("15", "HUNGARY");
            _playerCountries.Add("16", "ICELAND");
            _playerCountries.Add("17", "ISRAEL");
            _playerCountries.Add("18", "ITALY");
            _playerCountries.Add("19", "LATVIA");

            _playerCountries.Add("20", "LITHUANIA");
            _playerCountries.Add("21", "LUXEMBOURG");
            _playerCountries.Add("22", "MALTA");
            _playerCountries.Add("23", "HOLLAND");
            _playerCountries.Add("24", "NORTHERN IRELAND");
            _playerCountries.Add("25", "NORWAY");
            _playerCountries.Add("26", "POLAND");
            _playerCountries.Add("27", "PORTUGAL");
            _playerCountries.Add("28", "ROMANIA");
            _playerCountries.Add("29", "RUSSIA");
            _playerCountries.Add("30", "SAN MARINO");
            _playerCountries.Add("31", "SCOTLAND");
            _playerCountries.Add("32", "SLOVENIA");
            _playerCountries.Add("33", "SWEDEN");
            _playerCountries.Add("34", "TURKEY");
            _playerCountries.Add("35", "UKRAINE");
            _playerCountries.Add("36", "WALES");
            _playerCountries.Add("37", "SERBIA MONTENEGRO");
            _playerCountries.Add("38", "BELARUS");
            _playerCountries.Add("39", "SLOVAKIA");

            _playerCountries.Add("40", "SPAIN");
            _playerCountries.Add("41", "ARMENIA");
            _playerCountries.Add("42", "BOSNIA HERC");
            _playerCountries.Add("43", "AZERBAIJAN");
            _playerCountries.Add("44", "GEORGIA");
            _playerCountries.Add("45", "SWITZERLAND");
            _playerCountries.Add("46", "REP IRELAND");
            _playerCountries.Add("47", "FYR MACEDONIA");
            _playerCountries.Add("48", "TURKMENISTAN");
            _playerCountries.Add("49", "LIECHTENSTEIN");
            _playerCountries.Add("50", "MOLDOVA");
            _playerCountries.Add("51", "COSTA RICA");
            _playerCountries.Add("52", "EL SALVADOR");
            _playerCountries.Add("53", "GUATEMALA");
            _playerCountries.Add("54", "HONDURAS");
            _playerCountries.Add("55", "BAHAMAS");
            _playerCountries.Add("56", "MEXICO");
            _playerCountries.Add("57", "PANAMA");
            _playerCountries.Add("58", "USA");
            _playerCountries.Add("59", "BAHRAIN");

            _playerCountries.Add("60", "NICARAGUA");
            _playerCountries.Add("61", "BERMUDA");
            _playerCountries.Add("62", "JAMAICA");
            _playerCountries.Add("63", "TRINIDAD TOBAGO");
            _playerCountries.Add("64", "CANADA");
            _playerCountries.Add("65", "BARBADOS");
            _playerCountries.Add("66", "EL SALVADOR");
            _playerCountries.Add("67", "ST VINCENT GREN");
            _playerCountries.Add("68", "ARGENTINA");
            _playerCountries.Add("69", "BOLIVIA");
            _playerCountries.Add("70", "BRAZIL");
            _playerCountries.Add("71", "CHILE");
            _playerCountries.Add("72", "COLOMBIA");
            _playerCountries.Add("73", "ECUADOR");
            _playerCountries.Add("74", "PARAGUAY");
            _playerCountries.Add("75", "SURINAM");
            _playerCountries.Add("76", "URUGUAY");
            _playerCountries.Add("77", "VENEZUELA");
            _playerCountries.Add("78", "GUYANA");
            _playerCountries.Add("79", "PERU");

            _playerCountries.Add("80", "ALGERIA");
            _playerCountries.Add("81", "SOUTH AFRICA");
            _playerCountries.Add("82", "BOTSWANA");
            _playerCountries.Add("83", "BURKINA FASO");
            _playerCountries.Add("84", "BURUNDI");
            _playerCountries.Add("85", "LESOTHO");
            _playerCountries.Add("86", "CONGO ZAIRE");
            _playerCountries.Add("87", "ZAMBIA");
            _playerCountries.Add("88", "GHANA");
            _playerCountries.Add("89", "SENEGAL");
            _playerCountries.Add("90", "IVORY COAST");
            _playerCountries.Add("91", "TUNISIA");
            _playerCountries.Add("92", "MALI");
            _playerCountries.Add("93", "MADAGASCAR");
            _playerCountries.Add("94", "CAMEROON");
            _playerCountries.Add("95", "CHAD");
            _playerCountries.Add("96", "UGANDA");
            _playerCountries.Add("97", "LIBERIA");
            _playerCountries.Add("98", "MOZAMBIQUE");
            _playerCountries.Add("99", "KENYA");

            _playerCountries.Add("100", "SUDAN");
            _playerCountries.Add("101", "SWAZILAND");
            _playerCountries.Add("102", "ANGOLA");
            _playerCountries.Add("103", "TOGO");
            _playerCountries.Add("104", "ZIMBABWE");
            _playerCountries.Add("105", "EGYPT");
            _playerCountries.Add("106", "TANZANIA");
            _playerCountries.Add("107", "NIGERIA");
            _playerCountries.Add("108", "ETHIOPIA");
            _playerCountries.Add("109", "GABON");
            _playerCountries.Add("100", "SIERRA LEONE");
            _playerCountries.Add("111", "BENIN");
            _playerCountries.Add("112", "CONGO");
            _playerCountries.Add("113", "GUINEA");
            _playerCountries.Add("114", "SRI LANKA");
            _playerCountries.Add("115", "MOROCCO");
            _playerCountries.Add("116", "GAMBIA");
            _playerCountries.Add("117", "MALAWI");
            _playerCountries.Add("118", "JAPAN");
            _playerCountries.Add("119", "TAIWAN");

            _playerCountries.Add("120", "INDIA");
            _playerCountries.Add("121", "BANGLADESH");
            _playerCountries.Add("122", "BRUNEI");
            _playerCountries.Add("123", "IRAQ");
            _playerCountries.Add("124", "JORDAN");
            _playerCountries.Add("125", "SRI LANKA");
            _playerCountries.Add("126", "SYRIA");
            _playerCountries.Add("127", "SOUTH KOREA");
            _playerCountries.Add("128", "IRAN");
            _playerCountries.Add("129", "VIETNAM");
            _playerCountries.Add("130", "MALAYSIA");
            _playerCountries.Add("131", "SAUDI ARABIA");
            _playerCountries.Add("132", "YEMEN");
            _playerCountries.Add("133", "KUWAIT");
            _playerCountries.Add("134", "LAOS");
            _playerCountries.Add("135", "NORTH KOREA");
            _playerCountries.Add("136", "OMAN");
            _playerCountries.Add("137", "PAKISTAN");
            _playerCountries.Add("138", "PHILIPPINES");
            _playerCountries.Add("139", "CHINA");

            _playerCountries.Add("140", "SINGAPORE");
            _playerCountries.Add("141", "MAURITIUS");
            _playerCountries.Add("142", "MYANMAR");
            _playerCountries.Add("143", "PAPUA NEW GUINEA");
            _playerCountries.Add("144", "THAILAND");
            _playerCountries.Add("145", "UZBEKISTAN");
            _playerCountries.Add("146", "QATAR");
            _playerCountries.Add("147", "UTD ARAB EMIRATES");
            _playerCountries.Add("148", "AUSTRALIA");
            _playerCountries.Add("149", "NEW ZEALAND");
            _playerCountries.Add("150", "FIJI");
            _playerCountries.Add("151", "SOLOMON ISL");
            _playerCountries.Add("152", "CUSTOM");


            _teamCountries = new NameValueCollection();

            _teamCountries.Add("0", "ALBANIA");
            _teamCountries.Add("1", "AUSTRIA");
            _teamCountries.Add("2", "BELGIUM");
            _teamCountries.Add("3", "BULGARIA");
            _teamCountries.Add("4", "CROATIA");
            _teamCountries.Add("5", "CYPRUS");
            _teamCountries.Add("6", "CZECH REP");
            _teamCountries.Add("7", "DENMARK");
            _teamCountries.Add("8", "ENGLAND");

            _teamCountries.Add("10", "ESTONIA");
            _teamCountries.Add("11", "FAEROE ISL");
            _teamCountries.Add("12", "FINLAND");
            _teamCountries.Add("13", "FRANCE");
            _teamCountries.Add("14", "GERMANY");
            _teamCountries.Add("15", "GREECE");
            _teamCountries.Add("16", "HUNGARY");
            _teamCountries.Add("17", "ICELAND");
            _teamCountries.Add("18", "REP IRELAND");
            _teamCountries.Add("19", "ISRAEL");
            _teamCountries.Add("20", "ITALY");

            _teamCountries.Add("21", "LATVIA");
            _teamCountries.Add("22", "LITHUANIA");
            _teamCountries.Add("23", "LUXEMBOURG");
            _teamCountries.Add("24", "MALTA");
            _teamCountries.Add("25", "HOLLAND");
            _teamCountries.Add("26", "NORTHERN IRELAND");
            _teamCountries.Add("27", "NORWAY");
            _teamCountries.Add("28", "POLAND");
            _teamCountries.Add("29", "PORTUGAL");

            _teamCountries.Add("30", "ROMANIA");
            _teamCountries.Add("31", "RUSSIA");
            _teamCountries.Add("32", "SAN MARINO");
            _teamCountries.Add("33", "SCOTLAND");
            _teamCountries.Add("34", "SLOVENIA");
            _teamCountries.Add("35", "SPAIN");
            _teamCountries.Add("36", "SWEDEN");
            _teamCountries.Add("37", "SWITZERLAND");
            _teamCountries.Add("38", "TURKEY");
            _teamCountries.Add("39", "UKRAINE");

            _teamCountries.Add("40", "WALES");
            _teamCountries.Add("41", "SERBIA MONTENEGRO");
            _teamCountries.Add("42", "ALGERIA");
            _teamCountries.Add("43", "ARGENTINA");
            _teamCountries.Add("44", "AUSTRALIA");
            _teamCountries.Add("45", "BOLIVIA");
            _teamCountries.Add("46", "BRAZIL");
            _teamCountries.Add("47", "COSTA RICA");
            _teamCountries.Add("48", "CHILE");
            _teamCountries.Add("49", "COLOMBIA");

            _teamCountries.Add("50", "ECUADOR");
            _teamCountries.Add("51", "EL SALVADOR");
            _teamCountries.Add("55", "JAPAN");

            _teamCountries.Add("60", "MEXICO");
            _teamCountries.Add("62", "NEW ZEALAND");
            _teamCountries.Add("64", "PARAGUAY");
            _teamCountries.Add("65", "PERU");
            _teamCountries.Add("66", "SURINAM");
            _teamCountries.Add("67", "TAIWAN");
            //_teamCountries.Add( "68", "SOUTH AFRICA" );
            _teamCountries.Add("69", "SOUTH AFRICA");
            //_teamCountries.Add( "69", "URUGUAY" );

            _teamCountries.Add("71", "URUGUAY");
            _teamCountries.Add("73", "USA");
            _teamCountries.Add("75", "INDIA");
            _teamCountries.Add("76", "BELARUS");
            _teamCountries.Add("77", "VENEZUELA");
            _teamCountries.Add("78", "SLOVAKIA");
            _teamCountries.Add("79", "GHANA");

            _teamCountries.Add("83", "EL SALVADOR");
        }

        public static string GetPlayerCountry(byte id)
        {
            return _playerCountries[id.ToString()];
        }

        public static string GetTeamCountry(byte id)
        {
            return _teamCountries[id.ToString()];
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Manicomio.SwosPlayerFinder.Core
//{
//    public enum PlayerCountry
//    {
//  ALBANIA       =           0  ,
//  AUSTRIA               =   1   ,
//  BELGIUM               =   2   ,
//  BULGARIA              =   3   ,
//  CROATIA               =   4   ,
//  CYPRUS                =   5   ,
//  CZECHREP             =   6   ,
//  DENMARK               =   7   ,
//  ENGLAND               =   8   ,
//  ESTONIA               =   9   ,
//   FAEROEISL           =   10  ,
//   FINLAND              =   11  ,
//   FRANCE               =   12  ,
//   GERMANY              =   13  ,
//   GREECE               =   14  ,
//   HUNGARY              =   15  ,
//   ICELAND              =   16  ,
//   ISRAEL               =   17  ,
//   ITALY                =   18  ,
//   LATVIA               =   19  ,

//   LITHUANIA            =   20  ,
//   LUXEMBOURG           =   21  ,
//   MALTA                =   22  ,
//   HOLLAND              =   23  ,
//   NORTHERNIRELAND     =   24  ,
//   NORWAY               =   25  ,
//   POLAND               =   26  ,
//   PORTUGAL             =   27  ,
//   ROMANIA              =   28  ,
//   RUSSIA               =   29  ,
//   SANMARINO           =   30  ,
//   SCOTLAND             =   31  ,
//   SLOVENIA             =   32  ,
//   SWEDEN               =   33  ,
//   TURKEY               =   34  ,
//   UKRAINE              =   35  ,
//   WALES                =   36  ,
//   SERBIAMONTENEGRO    =   37  ,
//   BELARUS              =   38  ,
//   SLOVAKIA             =   39  ,

//   SPAIN                =   40  ,
//   ARMENIA              =   41  ,
//   BOSNIAHERC          =   42  ,
//   AZERBAIJAN           =   43  ,
//   GEORGIA              =   44  ,
//   SWITZERLAND          =   45  ,
//   REPIRELAND          =   46  ,
//   FYRMACEDONIA        =   47  ,
//   TURKMENISTAN         =   48  ,
//   LIECHTENSTEIN        =   49  ,
//   MOLDOVA              =   50  ,
//   COSTARICA           =   51  ,
//   ELSALVADOR          =   52  ,
//   GUATEMALA            =   53  ,
//   HONDURAS             =   54  ,
//   BAHAMAS              =   55  ,
//   MEXICO               =   56  ,
//   PANAMA               =   57  ,
//   USA                  =   58  ,
//   BAHRAIN              =   59  ,

//   NICARAGUA            =   60  ,
//   BERMUDA              =   61  ,
//   JAMAICA              =   62  ,
//   TRINIDADTOBAGO      =   63  ,
//   CANADA               =   64  ,
//   BARBADOS             =   65  ,
//   ELSALVADOR          =   66  ,
//   STVINCENTGREN      =   67  ,
//   ARGENTINA            =   68  ,
//   BOLIVIA              =   69  ,
//   BRAZIL               =   70  ,
//   CHILE                =   71  ,
//   COLOMBIA             =   72  ,
//   ECUADOR              =   73  ,
//   PARAGUAY             =   74  ,
//   SURINAM              =   75  ,
//   URUGUAY              =   76  ,
//   VENEZUELA            =   77  ,
//   GUYANA               =   78  ,
//   PERU                 =   79  ,
//                        =       ,
//   ALGERIA              =   80  ,
//   SOUTH AFRICA         =   81  ,
//   BOTSWANA             =   82  ,
//   BURKINA FASO         =   83  ,
//   BURUNDI              =   84  ,
//   LESOTHO              =   85  ,
//   CONGO ZAIRE          =   86  ,
//   ZAMBIA               =   87  ,
//   GHANA                =   88  ,
//   SENEGAL              =   89  ,
//   IVORY COAST          =   90  ,
//   TUNISIA              =   91  ,
//   MALI                 =   92  ,
//   MADAGASCAR           =   93  ,
//   CAMEROON             =   94  ,
//   CHAD                 =   95  ,
//   UGANDA               =   96  ,
//   LIBERIA              =   97  ,
//   MOZAMBIQUE           =   98  ,
//   KENYA                =   99  ,

//    SUDAN                 =   100 ,
//  SWAZILAND             =   101 ,
//  ANGOLA                =   102 ,
//  TOGO                  =   103 ,
//  ZIMBABWE              =   104 ,
//  EGYPT                 =   105 ,
//  TANZANIA              =   106 ,
//  NIGERIA               =   107 ,
//  ETHIOPIA              =   108 ,
//  GABON                 =   109 ,
//  SIERRA LEONE          =   100 ,
//  BENIN                 =   111 ,
//  CONGO                 =   112 ,
//  GUINEA                =   113 ,
//  SRI LANKA             =   114 ,
//  MOROCCO               =   115 ,
//  GAMBIA                =   116 ,
//  MALAWI                =   117 ,
//  JAPAN                 =   118 ,
//  TAIWAN                =   119 ,
//                        =       ,
//  INDIA                 =   120 ,
//  BANGLADESH            =   121 ,
//  BRUNEI                =   122 ,
//  IRAQ                  =   123 ,
//  JORDAN                =   124 ,
//  SRI LANKA             =   125 ,
//  SYRIA                 =   126 ,
//  SOUTH KOREA           =   127 ,
//  IRAN                  =   128 ,
//  VIETNAM               =   129 ,
//  MALAYSIA              =   130 ,
//  SAUDI ARABIA          =   131 ,
//  YEMEN                 =   132 ,
//  KUWAIT                =   133 ,
//  LAOS                  =   134 ,
//  NORTH KOREA           =   135 ,
//  OMAN                  =   136 ,
//  PAKISTAN              =   137 ,
//  PHILIPPINES           =   138 ,
//  CHINA                 =   139 ,

//  SINGAPORE             =   140 ,
//  MAURITIUS             =   141 ,
//  MYANMAR               =   142 ,
//  PAPUA NEW GUINEA      =   143 ,
//  THAILAND              =   144 ,
//  UZBEKISTAN            =   145 ,
//  QATAR                 =   146 ,
//  UTD ARAB EMIRATES     =   147 ,
//  AUSTRALIA             =   148 ,
//  NEW ZEALAND           =   149 ,
//  FIJI                  =   150 ,
//  SOLOMON ISL           =   151 ,
//  CUSTOM                =   152 ,

//    }
//}
