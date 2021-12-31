using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.TemplateMethod
{
	public class Cooking
	{
		private CookingImp lunchTimeImp;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="imp"></param>
		public Cooking(CookingImp imp)
		{
			this.lunchTimeImp = imp;
		}
		
		/// <summary>
		/// 切る
		/// </summary>
		public void Cut()
		{
			this.lunchTimeImp.RawCut();
		}

		/// <summary>
		/// 炒める
		/// </summary>
		public void Fly()
		{
			this.lunchTimeImp.RawFly();
		}

		/// <summary>
		/// 混ぜる
		/// </summary>
		public void Mix()
		{
			this.lunchTimeImp.RawMix();
		}

		/// <summary>
		/// 炒飯
		/// </summary>
		public void FriedRice()
		{
			Console.WriteLine("炒飯作るよ!!!");
			this.Cut();
			this.Fly();
			this.Mix();
			Console.WriteLine("炒飯できたよ!!!");
		}
	}
}
