using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.Adapter
{
	/// <summary>
	/// Adaptee 適合される対象となるクラス 
	/// Adapterを繋ぎたい既存のソース
	/// </summary>
	public class Adaptee
	{
		/// <summary>
		///	信頼性とかもろもろの理由で二度と触れたくないソースその1
		/// </summary>
		/// <returns></returns>
		public bool ComplicatedMethod()
		{
			var methodName = MethodBase.GetCurrentMethod().Name;

			Console.WriteLine(methodName);
			Console.WriteLine("複雑な処理を行ないました。");

			return true;
		}

		/// <summary>
		///	信頼性とかもろもろの理由で二度と触れたくないソースその2
		/// </summary>
		/// <param name="msg"></param>
		/// <returns></returns>
		public bool ComplicatedMethod_2(string msg)
		{
			var methodName = MethodBase.GetCurrentMethod().Name;

			Console.WriteLine(methodName);
			Console.WriteLine("複雑な処理を行ない「{0}」を表示しました。", msg);

			return true;
		}
	}
}
