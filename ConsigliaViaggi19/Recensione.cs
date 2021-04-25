using System;

namespace ConsigliaViaggi19
{
    public class Recensione
    {

		public int IdRecensione { get; set; }
		public int Valutazione { get; set; }
	    public string Commento { get; set; }
		public DateTime DataCreazione { get; set; }
		public string NicknameUtente { get; set; }
		public string NomeUtente { get; set; }
		public string CognomeUtente { get; set; }
		public string StatoApprovazione { get; set; }
		public string NomeStruttura { get; set; }
		public string TipoStruttura { get; set; }
	}
}
