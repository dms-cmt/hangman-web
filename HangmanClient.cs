using System;
using System.Collections.Generic;
using System.Timers;
using Hangman;

using System.ServiceModel;
using System.ServiceModel.Channels;

namespace HangmanService
{
	/*
	 * Cela klasa je komentarisana na kodu servisa (i u interfejsu)
	 */
	public class HangmanClient : ClientBase<IHangmanService>, IHangmanService
	{
		/*
		 * Konstante
		 */

		/*
		 * Globalne promenjive
		 */

		/*
		 * Konstruktori
		 */

		public HangmanClient (Binding binding, EndpointAddress address) : base (binding, address)
		{
		}

		/*
		 * Igra
		 */

		public int[] PokreniIgru ()
		{
			return Channel.PokreniIgru ();
		}

		public List<int> Provera (char[] slovo)
		{
			return Channel.Provera (slovo);
		}

		public int BrojPokusaja ()
		{
			return Channel.BrojPokusaja ();
		}

		public EStatusIgre Status ()
		{
			return Channel.Status ();
		}

		public long Vreme ()
		{
			return Channel.Vreme ();
		}

		public char[] Resenje ()
		{
			return Channel.Resenje ();
		}

		/*
		 * Rekordi
		 */

		public List<Rekord> PreuzmiRekorde (int? br = null)
		{
			return Channel.PreuzmiRekorde ();
		}

		public void SnimiRekord (String ime)
		{
			Channel.SnimiRekord (ime);
		}
	}
}

