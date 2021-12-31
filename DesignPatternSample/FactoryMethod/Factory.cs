using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternSample.FactoryMethod
{
	/// <summary>
	/// クラスを生成する工場の抽象クラス
	/// </summary>
	public abstract class Factory
	{
		/// <summary>
		/// TemplateFactoryの大事な部分
		/// TemplateMethodパターンも混ざっている
		/// </summary>
		/// <param name="taste"></param>
		/// <returns></returns>
		public Product Create(string taste)
		{
			var product = this.CreateProduct(taste);
			this.RegisterProduct(product);
			return product;
		}

		/// <summary>
		/// 製品の生成
		/// </summary>
		/// <param name="taste"></param>
		/// <returns></returns>
		protected abstract Product CreateProduct(string taste);

		/// <summary>
		/// 製品の登録
		/// </summary>
		/// <param name="product"></param>
		/// <returns></returns>
		protected abstract void RegisterProduct(Product product);
	}
}
